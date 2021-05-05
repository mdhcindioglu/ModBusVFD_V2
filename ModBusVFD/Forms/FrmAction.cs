using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBusV1.Forms
{
    public partial class FrmAction : Form
    {
        private readonly DataGridViewRow row;

        public FrmAction(DataGridViewRow _row)
        {
            InitializeComponent();
            row = _row;
            RadStop.Checked = row.Cells[0].Value.ToString().ToLower() == "stop";
            RadLeft.Checked = row.Cells[0].Value.ToString().ToLower() == "left";
            RadRight.Checked = row.Cells[0].Value.ToString().ToLower() == "right";

            if (row.Cells[1].Value.ToString() == "")
            {
                ValSpeed.Enabled = false;
                ValSpeed.Value = 0;
            }
            else
            {
                ValSpeed.Enabled = true;
                ValSpeed.Value = Convert.ToDecimal(row.Cells[1].Value.ToString());
            }

            ValTime.Value = Convert.ToDecimal(row.Cells[2].Value.ToString());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValTime.Value == 0)
                MessageBox.Show("Period must be greeter that zero!");
            else if (ValSpeed.Value == 0 && !RadStop.Checked)
                MessageBox.Show("Speed must be greeter that zero!");
            else
            {
                if (RadStop.Checked)
                    row.Cells[0].Value = "Stop";
                else if (RadLeft.Checked)
                    row.Cells[0].Value = "Left";
                else
                    row.Cells[0].Value = "Right";

                if (ValSpeed.Value > 0)
                    row.Cells[1].Value = ValSpeed.Value.ToString();
                else
                    row.Cells[1].Value = "";

                row.Cells[2].Value = ValTime.Value.ToString();

                Close();
            }
        }

        private void Rad_CheckedChanged(object sender, EventArgs e)
        {
            ValSpeed.Enabled = !RadStop.Checked;

            if (RadStop.Checked)
                ValSpeed.Value = 0;
        }
    }
}
