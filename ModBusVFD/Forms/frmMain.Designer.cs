
namespace ModBusV1
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip mnuMain;
            System.Windows.Forms.ToolStripMenuItem mnuFile;
            System.Windows.Forms.ToolStripSeparator mnuFile_1;
            System.Windows.Forms.ToolStripSeparator mnuFile_2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuFileConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileDisConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.LblSpeed2 = new System.Windows.Forms.Label();
            this.LblF = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.stsComPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsDataBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsParity = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsStopBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsState = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblSpeed = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.LblAmper = new System.Windows.Forms.Label();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BarSpeed = new System.Windows.Forms.TrackBar();
            this.GrpMain = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.RadAuto = new System.Windows.Forms.RadioButton();
            this.RadManual = new System.Windows.Forms.RadioButton();
            this.GrpDetails = new System.Windows.Forms.GroupBox();
            this.ChkLoop = new System.Windows.Forms.CheckBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ValTime = new System.Windows.Forms.NumericUpDown();
            this.RadRight = new System.Windows.Forms.RadioButton();
            this.RadLeft = new System.Windows.Forms.RadioButton();
            this.RadStop = new System.Windows.Forms.RadioButton();
            this.ValSpeed = new System.Windows.Forms.NumericUpDown();
            this.DgActions = new System.Windows.Forms.DataGridView();
            this.TmrAuto = new System.Windows.Forms.Timer(this.components);
            this.LblFreq = new System.Windows.Forms.Label();
            this.ColAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mnuMain = new System.Windows.Forms.MenuStrip();
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuFile_1 = new System.Windows.Forms.ToolStripSeparator();
            mnuFile_2 = new System.Windows.Forms.ToolStripSeparator();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            mnuMain.SuspendLayout();
            this.stsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarSpeed)).BeginInit();
            this.GrpMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GrpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgActions)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuFile});
            mnuMain.Location = new System.Drawing.Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new System.Drawing.Size(965, 24);
            mnuMain.TabIndex = 2;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileConnect,
            this.mnuFileDisConnect,
            mnuFile_1,
            this.mnuFileSettings,
            mnuFile_2,
            this.mnuFileExit});
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(37, 20);
            mnuFile.Text = "File";
            // 
            // mnuFileConnect
            // 
            this.mnuFileConnect.Name = "mnuFileConnect";
            this.mnuFileConnect.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.mnuFileConnect.Size = new System.Drawing.Size(209, 22);
            this.mnuFileConnect.Text = "Connect";
            this.mnuFileConnect.Click += new System.EventHandler(this.MnuFileConnect_Click);
            // 
            // mnuFileDisConnect
            // 
            this.mnuFileDisConnect.Enabled = false;
            this.mnuFileDisConnect.Name = "mnuFileDisConnect";
            this.mnuFileDisConnect.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.mnuFileDisConnect.Size = new System.Drawing.Size(209, 22);
            this.mnuFileDisConnect.Text = "DisConnect";
            this.mnuFileDisConnect.Click += new System.EventHandler(this.MnuFileDisConnect_Click);
            // 
            // mnuFile_1
            // 
            mnuFile_1.Name = "mnuFile_1";
            mnuFile_1.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuFileSettings
            // 
            this.mnuFileSettings.Name = "mnuFileSettings";
            this.mnuFileSettings.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuFileSettings.Size = new System.Drawing.Size(209, 22);
            this.mnuFileSettings.Text = "Settings";
            this.mnuFileSettings.Click += new System.EventHandler(this.MnuFileSettings_Click);
            // 
            // mnuFile_2
            // 
            mnuFile_2.Name = "mnuFile_2";
            mnuFile_2.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(209, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.MnuFileExit_Click);
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 289);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 13);
            label1.TabIndex = 6;
            label1.Text = "Action";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(162, 286);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 13);
            label3.TabIndex = 8;
            label3.Text = "Period";
            // 
            // LblSpeed2
            // 
            this.LblSpeed2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblSpeed2.AutoSize = true;
            this.LblSpeed2.Location = new System.Drawing.Point(214, 286);
            this.LblSpeed2.Name = "LblSpeed2";
            this.LblSpeed2.Size = new System.Drawing.Size(37, 13);
            this.LblSpeed2.TabIndex = 7;
            this.LblSpeed2.Text = "Speed";
            // 
            // LblF
            // 
            this.LblF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LblF.Font = new System.Drawing.Font("DS-Digital", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblF.ForeColor = System.Drawing.Color.Red;
            this.LblF.Location = new System.Drawing.Point(21, 34);
            this.LblF.Margin = new System.Windows.Forms.Padding(0);
            this.LblF.Name = "LblF";
            this.LblF.Size = new System.Drawing.Size(77, 132);
            this.LblF.TabIndex = 14;
            this.LblF.Text = "F";
            this.LblF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblA
            // 
            this.LblA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LblA.Font = new System.Drawing.Font("DS-Digital", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblA.Location = new System.Drawing.Point(558, 66);
            this.LblA.Margin = new System.Windows.Forms.Padding(0);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(79, 100);
            this.LblA.TabIndex = 15;
            this.LblA.Text = "A";
            this.LblA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsComPort,
            this.stsAddress,
            this.stsBaudRate,
            this.stsDataBits,
            this.stsParity,
            this.stsStopBits,
            this.stsState});
            this.stsMain.Location = new System.Drawing.Point(0, 572);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(965, 39);
            this.stsMain.TabIndex = 3;
            this.stsMain.Text = "statusStrip1";
            // 
            // stsComPort
            // 
            this.stsComPort.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsComPort.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsComPort.Name = "stsComPort";
            this.stsComPort.Size = new System.Drawing.Size(4, 34);
            this.stsComPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsAddress
            // 
            this.stsAddress.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsAddress.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsAddress.Name = "stsAddress";
            this.stsAddress.Size = new System.Drawing.Size(4, 34);
            this.stsAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsBaudRate
            // 
            this.stsBaudRate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsBaudRate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsBaudRate.Name = "stsBaudRate";
            this.stsBaudRate.Size = new System.Drawing.Size(4, 34);
            this.stsBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsDataBits
            // 
            this.stsDataBits.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsDataBits.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsDataBits.Name = "stsDataBits";
            this.stsDataBits.Size = new System.Drawing.Size(4, 34);
            this.stsDataBits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsParity
            // 
            this.stsParity.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsParity.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsParity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stsParity.Name = "stsParity";
            this.stsParity.Size = new System.Drawing.Size(4, 34);
            // 
            // stsStopBits
            // 
            this.stsStopBits.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsStopBits.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsStopBits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stsStopBits.Name = "stsStopBits";
            this.stsStopBits.Size = new System.Drawing.Size(4, 34);
            // 
            // stsState
            // 
            this.stsState.AutoSize = false;
            this.stsState.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsState.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsState.ForeColor = System.Drawing.Color.DarkRed;
            this.stsState.Name = "stsState";
            this.stsState.Size = new System.Drawing.Size(926, 34);
            this.stsState.Spring = true;
            this.stsState.Text = "Disconnected";
            this.stsState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSpeed
            // 
            this.LblSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LblSpeed.Font = new System.Drawing.Font("DS-Digital", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSpeed.ForeColor = System.Drawing.Color.Red;
            this.LblSpeed.Location = new System.Drawing.Point(98, 34);
            this.LblSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.LblSpeed.Name = "LblSpeed";
            this.LblSpeed.Size = new System.Drawing.Size(284, 132);
            this.LblSpeed.TabIndex = 4;
            this.LblSpeed.Text = "16.5";
            this.LblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // LblAmper
            // 
            this.LblAmper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LblAmper.Font = new System.Drawing.Font("DS-Digital", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblAmper.Location = new System.Drawing.Point(407, 66);
            this.LblAmper.Margin = new System.Windows.Forms.Padding(0);
            this.LblAmper.Name = "LblAmper";
            this.LblAmper.Size = new System.Drawing.Size(156, 100);
            this.LblAmper.TabIndex = 8;
            this.LblAmper.Text = "1.5";
            this.LblAmper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pic
            // 
            this.Pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic.Image = ((System.Drawing.Image)(resources.GetObject("Pic.Image")));
            this.Pic.Location = new System.Drawing.Point(0, 27);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(965, 559);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 13;
            this.Pic.TabStop = false;
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.Maroon;
            this.BtnStop.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.ForeColor = System.Drawing.Color.White;
            this.BtnStop.Location = new System.Drawing.Point(19, 333);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(613, 92);
            this.BtnStop.TabIndex = 16;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnRight.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.ForeColor = System.Drawing.Color.White;
            this.BtnRight.Location = new System.Drawing.Point(330, 229);
            this.BtnRight.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(302, 92);
            this.BtnRight.TabIndex = 17;
            this.BtnRight.Text = "Right";
            this.BtnRight.UseVisualStyleBackColor = false;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.BackColor = System.Drawing.Color.Navy;
            this.BtnLeft.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.ForeColor = System.Drawing.Color.White;
            this.BtnLeft.Location = new System.Drawing.Point(19, 229);
            this.BtnLeft.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(311, 92);
            this.BtnLeft.TabIndex = 18;
            this.BtnLeft.Text = "Left";
            this.BtnLeft.UseVisualStyleBackColor = false;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BarSpeed
            // 
            this.BarSpeed.LargeChange = 10;
            this.BarSpeed.Location = new System.Drawing.Point(19, 178);
            this.BarSpeed.Maximum = 5000;
            this.BarSpeed.Name = "BarSpeed";
            this.BarSpeed.Size = new System.Drawing.Size(613, 45);
            this.BarSpeed.TabIndex = 19;
            this.BarSpeed.TabStop = false;
            this.BarSpeed.TickFrequency = 10;
            this.BarSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BarSpeed.Scroll += new System.EventHandler(this.BarSpeed_Scroll);
            // 
            // GrpMain
            // 
            this.GrpMain.BackColor = System.Drawing.Color.Transparent;
            this.GrpMain.Controls.Add(label4);
            this.GrpMain.Controls.Add(this.LblFreq);
            this.GrpMain.Controls.Add(label2);
            this.GrpMain.Controls.Add(this.groupBox1);
            this.GrpMain.Controls.Add(this.GrpDetails);
            this.GrpMain.Controls.Add(this.LblA);
            this.GrpMain.Controls.Add(this.BarSpeed);
            this.GrpMain.Controls.Add(this.LblF);
            this.GrpMain.Controls.Add(this.LblAmper);
            this.GrpMain.Controls.Add(this.BtnLeft);
            this.GrpMain.Controls.Add(this.LblSpeed);
            this.GrpMain.Controls.Add(this.BtnStop);
            this.GrpMain.Controls.Add(this.BtnRight);
            this.GrpMain.Location = new System.Drawing.Point(12, 39);
            this.GrpMain.Name = "GrpMain";
            this.GrpMain.Size = new System.Drawing.Size(941, 435);
            this.GrpMain.TabIndex = 20;
            this.GrpMain.TabStop = false;
            this.GrpMain.Text = "Control VFD";
            this.GrpMain.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnStart);
            this.groupBox1.Controls.Add(this.RadAuto);
            this.groupBox1.Controls.Add(this.RadManual);
            this.groupBox1.Location = new System.Drawing.Point(662, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 44);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Work";
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnStart.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(122, 8);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(143, 32);
            this.BtnStart.TabIndex = 25;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Visible = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // RadAuto
            // 
            this.RadAuto.AutoSize = true;
            this.RadAuto.Location = new System.Drawing.Point(71, 15);
            this.RadAuto.Name = "RadAuto";
            this.RadAuto.Size = new System.Drawing.Size(48, 17);
            this.RadAuto.TabIndex = 1;
            this.RadAuto.Text = "Auto";
            this.RadAuto.UseVisualStyleBackColor = true;
            // 
            // RadManual
            // 
            this.RadManual.AutoSize = true;
            this.RadManual.Checked = true;
            this.RadManual.Location = new System.Drawing.Point(6, 15);
            this.RadManual.Name = "RadManual";
            this.RadManual.Size = new System.Drawing.Size(59, 17);
            this.RadManual.TabIndex = 0;
            this.RadManual.TabStop = true;
            this.RadManual.Text = "Manual";
            this.RadManual.UseVisualStyleBackColor = true;
            this.RadManual.CheckedChanged += new System.EventHandler(this.RadManualAuto_CheckedChanged);
            // 
            // GrpDetails
            // 
            this.GrpDetails.Controls.Add(this.ChkLoop);
            this.GrpDetails.Controls.Add(this.BtnDelete);
            this.GrpDetails.Controls.Add(label3);
            this.GrpDetails.Controls.Add(this.BtnAdd);
            this.GrpDetails.Controls.Add(this.LblSpeed2);
            this.GrpDetails.Controls.Add(label1);
            this.GrpDetails.Controls.Add(this.ValTime);
            this.GrpDetails.Controls.Add(this.RadRight);
            this.GrpDetails.Controls.Add(this.RadLeft);
            this.GrpDetails.Controls.Add(this.RadStop);
            this.GrpDetails.Controls.Add(this.ValSpeed);
            this.GrpDetails.Controls.Add(this.DgActions);
            this.GrpDetails.Location = new System.Drawing.Point(662, 66);
            this.GrpDetails.Name = "GrpDetails";
            this.GrpDetails.Size = new System.Drawing.Size(270, 363);
            this.GrpDetails.TabIndex = 20;
            this.GrpDetails.TabStop = false;
            this.GrpDetails.Text = "Auto Work";
            this.GrpDetails.Visible = false;
            // 
            // ChkLoop
            // 
            this.ChkLoop.AutoSize = true;
            this.ChkLoop.Location = new System.Drawing.Point(167, 334);
            this.ChkLoop.Name = "ChkLoop";
            this.ChkLoop.Size = new System.Drawing.Size(74, 17);
            this.ChkLoop.TabIndex = 24;
            this.ChkLoop.Text = "Continuas";
            this.ChkLoop.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.BackColor = System.Drawing.Color.Maroon;
            this.BtnDelete.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(83, 325);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(79, 32);
            this.BtnDelete.TabIndex = 23;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnAdd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(6, 325);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(77, 32);
            this.BtnAdd.TabIndex = 22;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ValTime
            // 
            this.ValTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ValTime.Location = new System.Drawing.Point(165, 302);
            this.ValTime.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.ValTime.Name = "ValTime";
            this.ValTime.Size = new System.Drawing.Size(47, 20);
            this.ValTime.TabIndex = 5;
            this.ValTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RadRight
            // 
            this.RadRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadRight.AutoSize = true;
            this.RadRight.Location = new System.Drawing.Point(109, 305);
            this.RadRight.Name = "RadRight";
            this.RadRight.Size = new System.Drawing.Size(50, 17);
            this.RadRight.TabIndex = 4;
            this.RadRight.Text = "Right";
            this.RadRight.UseVisualStyleBackColor = true;
            this.RadRight.CheckedChanged += new System.EventHandler(this.Action_CheckedChanged);
            // 
            // RadLeft
            // 
            this.RadLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadLeft.AutoSize = true;
            this.RadLeft.Location = new System.Drawing.Point(59, 305);
            this.RadLeft.Name = "RadLeft";
            this.RadLeft.Size = new System.Drawing.Size(44, 17);
            this.RadLeft.TabIndex = 3;
            this.RadLeft.Text = "Left";
            this.RadLeft.UseVisualStyleBackColor = true;
            this.RadLeft.CheckedChanged += new System.EventHandler(this.Action_CheckedChanged);
            // 
            // RadStop
            // 
            this.RadStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadStop.AutoSize = true;
            this.RadStop.Checked = true;
            this.RadStop.Location = new System.Drawing.Point(6, 305);
            this.RadStop.Name = "RadStop";
            this.RadStop.Size = new System.Drawing.Size(47, 17);
            this.RadStop.TabIndex = 2;
            this.RadStop.TabStop = true;
            this.RadStop.Text = "Stop";
            this.RadStop.UseVisualStyleBackColor = true;
            this.RadStop.CheckedChanged += new System.EventHandler(this.Action_CheckedChanged);
            // 
            // ValSpeed
            // 
            this.ValSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ValSpeed.Location = new System.Drawing.Point(217, 302);
            this.ValSpeed.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ValSpeed.Name = "ValSpeed";
            this.ValSpeed.Size = new System.Drawing.Size(47, 20);
            this.ValSpeed.TabIndex = 1;
            this.ValSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValSpeed.Visible = false;
            // 
            // DgActions
            // 
            this.DgActions.AllowUserToAddRows = false;
            this.DgActions.AllowUserToDeleteRows = false;
            this.DgActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgActions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAction,
            this.ColSpeed,
            this.ColPeriod});
            this.DgActions.Location = new System.Drawing.Point(3, 16);
            this.DgActions.MultiSelect = false;
            this.DgActions.Name = "DgActions";
            this.DgActions.ReadOnly = true;
            this.DgActions.RowHeadersVisible = false;
            this.DgActions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgActions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgActions.Size = new System.Drawing.Size(262, 270);
            this.DgActions.TabIndex = 0;
            this.DgActions.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgActions_RowsAdded);
            this.DgActions.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgActions_RowsRemoved);
            this.DgActions.SelectionChanged += new System.EventHandler(this.DgActions_SelectionChanged);
            this.DgActions.DoubleClick += new System.EventHandler(this.DgActions_DoubleClick);
            // 
            // TmrAuto
            // 
            this.TmrAuto.Tick += new System.EventHandler(this.TmrAuto_Tick);
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(255, 200);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 23);
            label2.TabIndex = 25;
            label2.Text = "Freq:";
            // 
            // LblFreq
            // 
            this.LblFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblFreq.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFreq.ForeColor = System.Drawing.Color.Brown;
            this.LblFreq.Location = new System.Drawing.Point(310, 200);
            this.LblFreq.Name = "LblFreq";
            this.LblFreq.Size = new System.Drawing.Size(52, 23);
            this.LblFreq.TabIndex = 26;
            this.LblFreq.Text = "0";
            this.LblFreq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(361, 200);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(35, 23);
            label4.TabIndex = 27;
            label4.Text = "Hz";
            // 
            // ColAction
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColAction.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColAction.HeaderText = "Action";
            this.ColAction.Name = "ColAction";
            this.ColAction.ReadOnly = true;
            this.ColAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColAction.Width = 75;
            // 
            // ColSpeed
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSpeed.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColSpeed.HeaderText = "Speed";
            this.ColSpeed.Name = "ColSpeed";
            this.ColSpeed.ReadOnly = true;
            this.ColSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSpeed.Width = 75;
            // 
            // ColPeriod
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColPeriod.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColPeriod.HeaderText = "Period";
            this.ColPeriod.Name = "ColPeriod";
            this.ColPeriod.ReadOnly = true;
            this.ColPeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColPeriod.Width = 75;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 611);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(mnuMain);
            this.Controls.Add(this.GrpMain);
            this.Controls.Add(this.Pic);
            this.MainMenuStrip = mnuMain;
            this.Name = "FrmMain";
            this.Text = "Modbus Comunication";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarSpeed)).EndInit();
            this.GrpMain.ResumeLayout(false);
            this.GrpMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpDetails.ResumeLayout(false);
            this.GrpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgActions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuFileConnect;
        private System.Windows.Forms.ToolStripMenuItem mnuFileDisConnect;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel stsComPort;
        private System.Windows.Forms.ToolStripStatusLabel stsBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel stsDataBits;
        private System.Windows.Forms.ToolStripStatusLabel stsParity;
        private System.Windows.Forms.ToolStripStatusLabel stsStopBits;
        private System.Windows.Forms.ToolStripStatusLabel stsState;
        private System.Windows.Forms.Label LblSpeed;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label LblAmper;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Label LblF;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.TrackBar BarSpeed;
        private System.Windows.Forms.ToolStripStatusLabel stsAddress;
        private System.Windows.Forms.GroupBox GrpMain;
        private System.Windows.Forms.GroupBox GrpDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadAuto;
        private System.Windows.Forms.RadioButton RadManual;
        private System.Windows.Forms.NumericUpDown ValTime;
        private System.Windows.Forms.RadioButton RadRight;
        private System.Windows.Forms.RadioButton RadLeft;
        private System.Windows.Forms.RadioButton RadStop;
        private System.Windows.Forms.NumericUpDown ValSpeed;
        private System.Windows.Forms.DataGridView DgActions;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.CheckBox ChkLoop;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LblSpeed2;
        private System.Windows.Forms.Timer TmrAuto;
        private System.Windows.Forms.Label LblFreq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPeriod;
    }
}

