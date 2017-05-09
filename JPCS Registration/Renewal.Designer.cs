﻿namespace JPCS_Registration
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
            this.mtbOrNum = new System.Windows.Forms.MaskedTextBox();
            this.radLabel15 = new Telerik.WinControls.UI.RadLabel();
            this.mtbStudNum = new System.Windows.Forms.MaskedTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txt_payment = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnRegister = new Telerik.WinControls.UI.RadButton();
            this.ddlCoyesec = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCoyesec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbOrNum
            // 
            this.mtbOrNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.mtbOrNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbOrNum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbOrNum.ForeColor = System.Drawing.Color.White;
            this.mtbOrNum.Location = new System.Drawing.Point(218, 148);
            this.mtbOrNum.Mask = "JP\\CS\\-0000";
            this.mtbOrNum.Name = "mtbOrNum";
            this.mtbOrNum.PromptChar = 'x';
            this.mtbOrNum.Size = new System.Drawing.Size(113, 29);
            this.mtbOrNum.TabIndex = 33;
            // 
            // radLabel15
            // 
            this.radLabel15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel15.Location = new System.Drawing.Point(109, 148);
            this.radLabel15.Name = "radLabel15";
            this.radLabel15.Size = new System.Drawing.Size(103, 25);
            this.radLabel15.TabIndex = 34;
            this.radLabel15.Text = "OR Number: ";
            this.radLabel15.ThemeName = "VisualStudio2012Dark";
            // 
            // mtbStudNum
            // 
            this.mtbStudNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.mtbStudNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbStudNum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbStudNum.ForeColor = System.Drawing.Color.White;
            this.mtbStudNum.Location = new System.Drawing.Point(219, 99);
            this.mtbStudNum.Mask = "00\\-00000";
            this.mtbStudNum.Name = "mtbStudNum";
            this.mtbStudNum.PromptChar = 'x';
            this.mtbStudNum.Size = new System.Drawing.Size(114, 29);
            this.mtbStudNum.TabIndex = 35;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(130, 99);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(83, 25);
            this.radLabel1.TabIndex = 36;
            this.radLabel1.Text = "Student #:";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel2.Location = new System.Drawing.Point(130, 231);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(75, 25);
            this.radLabel2.TabIndex = 34;
            this.radLabel2.Text = "Payment:";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // txt_payment
            // 
            this.txt_payment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_payment.Location = new System.Drawing.Point(218, 231);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(113, 28);
            this.txt_payment.TabIndex = 37;
            this.txt_payment.ThemeName = "VisualStudio2012Dark";
            this.txt_payment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_payment_KeyPress);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel3.Location = new System.Drawing.Point(17, 190);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(188, 25);
            this.radLabel3.TabIndex = 38;
            this.radLabel3.Text = "Course, Year and Section";
            this.radLabel3.ThemeName = "VisualStudio2012Dark";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRegister.Location = new System.Drawing.Point(169, 324);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(117, 31);
            this.btnRegister.TabIndex = 40;
            this.btnRegister.Text = "Update";
            this.btnRegister.ThemeName = "VisualStudio2012Dark";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // ddlCoyesec
            // 
            this.ddlCoyesec.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ddlCoyesec.Location = new System.Drawing.Point(219, 190);
            this.ddlCoyesec.Name = "ddlCoyesec";
            this.ddlCoyesec.Size = new System.Drawing.Size(112, 31);
            this.ddlCoyesec.TabIndex = 41;
            this.ddlCoyesec.ThemeName = "VisualStudio2012Dark";
            // 
            // Renewal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 375);
            this.Controls.Add(this.ddlCoyesec);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.mtbStudNum);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.mtbOrNum);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel15);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "Renewal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Update";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.Renewal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCoyesec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbOrNum;
        private Telerik.WinControls.UI.RadLabel radLabel15;
        private System.Windows.Forms.MaskedTextBox mtbStudNum;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txt_payment;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnRegister;
        private Telerik.WinControls.UI.RadDropDownList ddlCoyesec;
    }
}
