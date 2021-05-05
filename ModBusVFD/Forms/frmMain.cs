using Modbus.Device;
using ModBusV1.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace ModBusV1
{
    public partial class FrmMain : Form
    {
        VFD vfd;
        Delta delta;
        byte slaveAddress = Properties.Settings.Default.Address;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UpdateStatus();
            tmr.Interval = Properties.Settings.Default.Refresh;
            GrpDetails.Visible = RadAuto.Checked;
        }

        private void MnuFileSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            var result = frmSettings.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.PortName = frmSettings.cmbComPort.Text;
                Properties.Settings.Default.Baudrate = int.Parse(frmSettings.cmbBaudrate.Text);
                Properties.Settings.Default.DataBits = int.Parse(frmSettings.cmbDataBits.Text);
                Properties.Settings.Default.ParityBits = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), frmSettings.cmbParityBits.Text);
                Properties.Settings.Default.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), frmSettings.cmbStopBits.Text);
                Properties.Settings.Default.Refresh = int.Parse(frmSettings.NumRefresh.Value.ToString());
                Properties.Settings.Default.Address = byte.Parse(frmSettings.NumAddress.Value.ToString());
                slaveAddress = Properties.Settings.Default.Address;
                tmr.Interval = Properties.Settings.Default.Refresh;

                Properties.Settings.Default.Save();
                UpdateStatus();
            }

            frmSettings.Dispose();
        }

        private void UpdateStatus()
        {
            stsComPort.Text = "Port: " + Properties.Settings.Default.PortName;
            stsAddress.Text = "Address: " + Properties.Settings.Default.Address;
            stsBaudRate.Text = "Baud Rate: " + Properties.Settings.Default.Baudrate;
            stsDataBits.Text = "Data Bits: " + Properties.Settings.Default.DataBits;
            stsParity.Text = "Patity: " + (Parity)Properties.Settings.Default.ParityBits;
            stsStopBits.Text = "Stop Bits: " + (StopBits)Properties.Settings.Default.StopBits;
        }

        private void MnuFileConnect_Click(object sender, EventArgs e)
        {
            try
            {
                vfd = new VFD(
                    Properties.Settings.Default.PortName,
                    Properties.Settings.Default.Baudrate,
                    Properties.Settings.Default.DataBits,
                    Properties.Settings.Default.StopBits,
                    Properties.Settings.Default.ParityBits,
                    Properties.Settings.Default.Address);
                vfd.OpenSerialPort();
                delta = new Delta(vfd);

                stsState.Text = "Connected";
                stsState.ForeColor = Color.DarkGreen;
                mnuFileConnect.Enabled = false;
                mnuFileSettings.Enabled = false;
                mnuFileDisConnect.Enabled = true;
                GrpMain.Visible = true;

                BackgroundImage = null;

                tmr.Interval = Properties.Settings.Default.Refresh;
                tmr.Start();
            }
            catch (IOException exIO)
            {
                if (exIO.HResult == -2146232800)
                    MessageBox.Show(this, "SerialPort is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show(this, exIO.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to close?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                vfd.CloseSerialPort();
                this.Dispose();
            }
        }

        private void MnuFileDisConnect_Click(object sender, EventArgs e)
        {
            try
            {
                tmr.Stop();
                delta.Stop();
                vfd.CloseSerialPort();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            stsState.Text = "Disconnected";
            stsState.ForeColor = Color.DarkRed;
            mnuFileConnect.Enabled = true;
            mnuFileSettings.Enabled = true;
            mnuFileDisConnect.Enabled = false;
            GrpMain.Visible = false;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            try
            {
                delta.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error happened:\r\n\r\n{ex.Message}");
            }
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            try
            {
                delta.Right();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error happened:\r\n\r\n{ex.Message}");
            }
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                delta.Left();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error happened:\r\n\r\n{ex.Message}");
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                int speed = delta.GetSpeed;
                BarSpeed.Value = speed;
                speed /= 100;
                LblSpeed.Text = speed.ToString("0.0");
                LblFreq.Text = LblSpeed.Text;

                decimal amper = delta.GetAmper;
                amper /= 10;
                LblAmper.Text = amper.ToString("0.0");
            }
            catch (Exception ex)
            {
                MnuFileDisConnect_Click(this, new EventArgs());

                if (ex.HResult == -2146233083)
                    MessageBox.Show(this, "Check SlaveAddress then try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BarSpeed_Scroll(object sender, EventArgs e)
        {
            try
            {
                delta.Speed((ushort)BarSpeed.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error happened:\r\n\r\n{ex.Message}");
            }
        }

        private void RadManualAuto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var rows = JsonSerializer.Deserialize<List<Action>>(Properties.Settings.Default.Actions);
                DgActions.Rows.Clear();
                foreach (var row in rows)
                    DgActions.Rows.Add(row.ActionType.ToString(), row.Speed == 0 ? "" : row.Speed.ToString(), row.Period.ToString());

                BarSpeed.Enabled = RadManual.Checked;
                BtnLeft.Enabled = RadManual.Checked;
                BtnRight.Enabled = RadManual.Checked;
                BtnStop.Enabled = RadManual.Checked;
            }
            catch (Exception) { }
            GrpDetails.Visible = RadAuto.Checked;
            BtnStart.Visible = RadAuto.Checked && DgActions.SelectedRows.Count > 0;
        }

        private void Action_CheckedChanged(object sender, EventArgs e)
        {
            ValSpeed.Visible = RadLeft.Checked || RadRight.Checked;
            LblSpeed2.Visible = RadLeft.Checked || RadRight.Checked;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValTime.Value > 0)
            {
                DgActions.Rows.Add(
                    RadStop.Checked ? Actions.Stop.ToString() : RadLeft.Checked ? Actions.Left.ToString() : Actions.Right.ToString(),
                    RadStop.Checked ? "" : ValSpeed.Value.ToString(),
                    ValTime.Value.ToString());
            }
            else
                MessageBox.Show("Add time please!");
        }

        private void DgActions_SelectionChanged(object sender, EventArgs e)
        {
            if (DgActions.SelectedRows.Count > 0)
            {
                BtnStart.Visible = true;
                BtnDelete.Visible = true;
            }
            else
            {
                BtnStart.Visible = false;
                BtnDelete.Visible = false;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DgActions.SelectedRows.Count > 0)
                if (MessageBox.Show("Do you want to delete this action?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    DgActions.Rows.RemoveAt(DgActions.SelectedRows[0].Index);
        }

        private int indexer = 0;

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgActions.Rows.Count > 0)
                    if (BtnStart.Text.ToLower() == "start")
                    {
                        indexer = 0;
                        BtnStart.Text = "Stop";
                        BtnStart.BackColor = BtnStop.BackColor;
                        GrpDetails.Enabled = false;
                        TmrAuto.Interval = 1;
                        TmrAuto.Enabled = true;
                        TmrAuto.Start();
                    }
                    else
                    {
                        BtnStart.Text = "Start";
                        BtnStart.BackColor = BtnRight.BackColor;
                        GrpDetails.Enabled = true;
                        TmrAuto.Stop();
                        delta.Stop();
                    }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void TmrAuto_Tick(object sender, EventArgs e)
        {
            if (DgActions.Rows.Count > 0)
            {
                if (indexer > DgActions.Rows.Count - 1)
                {
                    indexer = 0;
                    if (!ChkLoop.Checked)
                    {
                        BtnStart_Click(this, new EventArgs());
                        TmrAuto.Stop();
                        return;
                    }
                }

                DgActions.Rows[indexer].Selected = true;
                TmrAuto.Interval = Convert.ToInt32(DgActions.Rows[indexer].Cells[2].Value);
                BarSpeed.Value = DgActions.Rows[indexer].Cells[1].Value.ToString() == "" ? 0 : Convert.ToInt32(DgActions.Rows[indexer].Cells[2].Value);

                try
                {
                    string action = DgActions.Rows[indexer].Cells[0].Value.ToString();
                    ushort speed = DgActions.Rows[indexer].Cells[1].Value.ToString() != "" ? Convert.ToUInt16(DgActions.Rows[indexer].Cells[1].Value.ToString()) : ushort.MinValue;
                    switch (action)
                    {
                        case "Stop":
                            delta.Stop();
                            break;
                        case "Left":
                            delta.Left(speed);
                            break;
                        case "Right":
                        default:
                            delta.Right(speed);
                            break;
                    }
                    TmrAuto.Stop();
                    TmrAuto.Start();
                }
                catch (Exception ex)
                {
                    TmrAuto.Stop();
                    MessageBox.Show($"Error happened:\r\n\r\n{ex.Message}");
                }

                indexer++;
            }
        }

        private void DgActions_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateRow();
        }

        private void DgActions_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateRow();
        }

        private void UpdateRow()
        {
            var actions = new List<Action>();
            foreach (DataGridViewRow row in DgActions.Rows)
            {
                actions.Add(new Action
                {
                    ActionType = (Actions)Enum.Parse(typeof(Actions), row.Cells[0].Value.ToString(), true),
                    Speed = row.Cells[1].Value.ToString() != "" ? Convert.ToInt32(row.Cells[1].Value) : 0,
                    Period = Convert.ToInt32(row.Cells[2].Value),
                });
            }
            Properties.Settings.Default.Actions = JsonSerializer.Serialize(actions);
            Properties.Settings.Default.Save();
        }

        private void DgActions_DoubleClick(object sender, EventArgs e)
        {
            if (DgActions.SelectedRows.Count > 0)
            {
                FrmAction frmAction = new FrmAction(DgActions.SelectedRows[0]);
                frmAction.ShowDialog();
                UpdateRow();
            }
        }
    }
}
