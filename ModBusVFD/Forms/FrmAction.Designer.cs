
namespace ModBusV1.Forms
{
    partial class FrmAction
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
            System.Windows.Forms.Label label3;
            this.label1 = new System.Windows.Forms.Label();
            this.LblSpeed2 = new System.Windows.Forms.Label();
            this.ValTime = new System.Windows.Forms.NumericUpDown();
            this.ValSpeed = new System.Windows.Forms.NumericUpDown();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.RadRight = new System.Windows.Forms.RadioButton();
            this.RadLeft = new System.Windows.Forms.RadioButton();
            this.RadStop = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ValTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 41);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 13);
            label3.TabIndex = 12;
            label3.Text = "Period:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Action:";
            // 
            // LblSpeed2
            // 
            this.LblSpeed2.AutoSize = true;
            this.LblSpeed2.Location = new System.Drawing.Point(12, 67);
            this.LblSpeed2.Name = "LblSpeed2";
            this.LblSpeed2.Size = new System.Drawing.Size(41, 13);
            this.LblSpeed2.TabIndex = 11;
            this.LblSpeed2.Text = "Speed:";
            // 
            // ValTime
            // 
            this.ValTime.Location = new System.Drawing.Point(59, 39);
            this.ValTime.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.ValTime.Name = "ValTime";
            this.ValTime.Size = new System.Drawing.Size(61, 20);
            this.ValTime.TabIndex = 10;
            this.ValTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ValSpeed
            // 
            this.ValSpeed.Location = new System.Drawing.Point(59, 65);
            this.ValSpeed.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ValSpeed.Name = "ValSpeed";
            this.ValSpeed.Size = new System.Drawing.Size(61, 20);
            this.ValSpeed.TabIndex = 9;
            this.ValSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSave.Location = new System.Drawing.Point(222, 15);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(222, 62);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // RadRight
            // 
            this.RadRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadRight.AutoSize = true;
            this.RadRight.Location = new System.Drawing.Point(162, 15);
            this.RadRight.Name = "RadRight";
            this.RadRight.Size = new System.Drawing.Size(50, 17);
            this.RadRight.TabIndex = 17;
            this.RadRight.Text = "Right";
            this.RadRight.UseVisualStyleBackColor = true;
            this.RadRight.CheckedChanged += new System.EventHandler(this.Rad_CheckedChanged);
            // 
            // RadLeft
            // 
            this.RadLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadLeft.AutoSize = true;
            this.RadLeft.Location = new System.Drawing.Point(112, 15);
            this.RadLeft.Name = "RadLeft";
            this.RadLeft.Size = new System.Drawing.Size(44, 17);
            this.RadLeft.TabIndex = 16;
            this.RadLeft.Text = "Left";
            this.RadLeft.UseVisualStyleBackColor = true;
            this.RadLeft.CheckedChanged += new System.EventHandler(this.Rad_CheckedChanged);
            // 
            // RadStop
            // 
            this.RadStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RadStop.AutoSize = true;
            this.RadStop.Checked = true;
            this.RadStop.Location = new System.Drawing.Point(59, 15);
            this.RadStop.Name = "RadStop";
            this.RadStop.Size = new System.Drawing.Size(47, 17);
            this.RadStop.TabIndex = 15;
            this.RadStop.TabStop = true;
            this.RadStop.Text = "Stop";
            this.RadStop.UseVisualStyleBackColor = true;
            this.RadStop.CheckedChanged += new System.EventHandler(this.Rad_CheckedChanged);
            // 
            // FrmAction
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 97);
            this.Controls.Add(this.RadRight);
            this.Controls.Add(this.RadLeft);
            this.Controls.Add(this.RadStop);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(label3);
            this.Controls.Add(this.LblSpeed2);
            this.Controls.Add(this.ValTime);
            this.Controls.Add(this.ValSpeed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAction";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Action";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ValTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSpeed2;
        private System.Windows.Forms.NumericUpDown ValTime;
        private System.Windows.Forms.NumericUpDown ValSpeed;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.RadioButton RadRight;
        private System.Windows.Forms.RadioButton RadLeft;
        private System.Windows.Forms.RadioButton RadStop;
    }
}