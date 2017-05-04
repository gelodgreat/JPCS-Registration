namespace JPCS_Registration
{
    partial class Renewal
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
            this.reg_tb_ornumber = new System.Windows.Forms.MaskedTextBox();
            this.radLabel15 = new Telerik.WinControls.UI.RadLabel();
            this.reg_tb_studno = new System.Windows.Forms.MaskedTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txt_payment = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_tb_ornumber
            // 
            this.reg_tb_ornumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.reg_tb_ornumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_tb_ornumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reg_tb_ornumber.ForeColor = System.Drawing.Color.White;
            this.reg_tb_ornumber.Location = new System.Drawing.Point(151, 93);
            this.reg_tb_ornumber.Mask = "JP\\CS\\-0000";
            this.reg_tb_ornumber.Name = "reg_tb_ornumber";
            this.reg_tb_ornumber.PromptChar = 'x';
            this.reg_tb_ornumber.Size = new System.Drawing.Size(113, 29);
            this.reg_tb_ornumber.TabIndex = 33;
            // 
            // radLabel15
            // 
            this.radLabel15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel15.Location = new System.Drawing.Point(43, 94);
            this.radLabel15.Name = "radLabel15";
            this.radLabel15.Size = new System.Drawing.Size(103, 25);
            this.radLabel15.TabIndex = 34;
            this.radLabel15.Text = "OR Number: ";
            this.radLabel15.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_tb_studno
            // 
            this.reg_tb_studno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.reg_tb_studno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_tb_studno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reg_tb_studno.ForeColor = System.Drawing.Color.White;
            this.reg_tb_studno.Location = new System.Drawing.Point(152, 44);
            this.reg_tb_studno.Mask = "00\\-00000";
            this.reg_tb_studno.Name = "reg_tb_studno";
            this.reg_tb_studno.PromptChar = 'x';
            this.reg_tb_studno.Size = new System.Drawing.Size(114, 29);
            this.reg_tb_studno.TabIndex = 35;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(63, 47);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(83, 25);
            this.radLabel1.TabIndex = 36;
            this.radLabel1.Text = "Student #:";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel2.Location = new System.Drawing.Point(43, 142);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(75, 25);
            this.radLabel2.TabIndex = 34;
            this.radLabel2.Text = "Payment:";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // txt_payment
            // 
            this.txt_payment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_payment.Location = new System.Drawing.Point(151, 142);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(113, 28);
            this.txt_payment.TabIndex = 37;
            this.txt_payment.ThemeName = "VisualStudio2012Dark";
            this.txt_payment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_payment_KeyPress);
            // 
            // Renewal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 265);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.reg_tb_studno);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.reg_tb_ornumber);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel15);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "Renewal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Renewal";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.Renewal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox reg_tb_ornumber;
        private Telerik.WinControls.UI.RadLabel radLabel15;
        private System.Windows.Forms.MaskedTextBox reg_tb_studno;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txt_payment;
    }
}
