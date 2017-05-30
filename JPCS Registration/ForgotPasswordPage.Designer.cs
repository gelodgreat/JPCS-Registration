namespace JPCS_Registration
{
    partial class ForgotPasswordPage
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordPage));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.fp_tb_userstudno = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel15 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel14 = new Telerik.WinControls.UI.RadLabel();
            this.fp_tb_securityans = new Telerik.WinControls.UI.RadTextBox();
            this.fp_cb_securityques = new Telerik.WinControls.UI.RadDropDownList();
            this.fp_lbl_status = new Telerik.WinControls.UI.RadLabel();
            this.fp_btn_confirm = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.fp_tb_new_pass = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.fp_tb_conf_new_pass = new Telerik.WinControls.UI.RadTextBox();
            this.fp_btn_changepass = new Telerik.WinControls.UI.RadButton();
            this.fp_timer_studnouser = new System.Windows.Forms.Timer(this.components);
            this.fp_rgb_secmeas = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.fp_rgb_changepass = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_tb_userstudno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_tb_securityans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_cb_securityques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_lbl_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_btn_confirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_tb_new_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_tb_conf_new_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_btn_changepass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_rgb_secmeas)).BeginInit();
            this.fp_rgb_secmeas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fp_rgb_changepass)).BeginInit();
            this.fp_rgb_changepass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(20, 36);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(95, 40);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Student # or \r\nUsername:";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // fp_tb_userstudno
            // 
            this.fp_tb_userstudno.Location = new System.Drawing.Point(103, 49);
            this.fp_tb_userstudno.Name = "fp_tb_userstudno";
            this.fp_tb_userstudno.Size = new System.Drawing.Size(263, 25);
            this.fp_tb_userstudno.TabIndex = 1;
            this.fp_tb_userstudno.ThemeName = "VisualStudio2012Dark";
            this.fp_tb_userstudno.TextChanged += new System.EventHandler(this.fp_tb_userstudno_TextChanged);
            // 
            // radLabel15
            // 
            this.radLabel15.Location = new System.Drawing.Point(59, 64);
            this.radLabel15.Name = "radLabel15";
            this.radLabel15.Size = new System.Drawing.Size(56, 22);
            this.radLabel15.TabIndex = 18;
            this.radLabel15.Text = "Answer:";
            this.radLabel15.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel14
            // 
            this.radLabel14.Location = new System.Drawing.Point(7, 34);
            this.radLabel14.Name = "radLabel14";
            this.radLabel14.Size = new System.Drawing.Size(120, 22);
            this.radLabel14.TabIndex = 17;
            this.radLabel14.Text = "Security Question:";
            this.radLabel14.ThemeName = "VisualStudio2012Dark";
            // 
            // fp_tb_securityans
            // 
            this.fp_tb_securityans.AutoSize = false;
            this.fp_tb_securityans.Location = new System.Drawing.Point(110, 64);
            this.fp_tb_securityans.Multiline = true;
            this.fp_tb_securityans.Name = "fp_tb_securityans";
            this.fp_tb_securityans.Size = new System.Drawing.Size(263, 57);
            this.fp_tb_securityans.TabIndex = 15;
            this.fp_tb_securityans.ThemeName = "VisualStudio2012Dark";
            // 
            // fp_cb_securityques
            // 
            this.fp_cb_securityques.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "What is your Mother\'s maiden name?";
            radListDataItem2.Text = "What is your dream job?";
            radListDataItem3.Text = "Who is your favorite artist?";
            radListDataItem4.Text = "What is your favorite song?";
            radListDataItem5.Text = "What is your favorite programming language?";
            this.fp_cb_securityques.Items.Add(radListDataItem1);
            this.fp_cb_securityques.Items.Add(radListDataItem2);
            this.fp_cb_securityques.Items.Add(radListDataItem3);
            this.fp_cb_securityques.Items.Add(radListDataItem4);
            this.fp_cb_securityques.Items.Add(radListDataItem5);
            this.fp_cb_securityques.Location = new System.Drawing.Point(110, 34);
            this.fp_cb_securityques.Name = "fp_cb_securityques";
            this.fp_cb_securityques.Size = new System.Drawing.Size(263, 28);
            this.fp_cb_securityques.TabIndex = 16;
            this.fp_cb_securityques.ThemeName = "VisualStudio2012Dark";
            // 
            // fp_lbl_status
            // 
            this.fp_lbl_status.Location = new System.Drawing.Point(265, 25);
            this.fp_lbl_status.Name = "fp_lbl_status";
            this.fp_lbl_status.Size = new System.Drawing.Size(45, 22);
            this.fp_lbl_status.TabIndex = 19;
            this.fp_lbl_status.Text = "Status";
            this.fp_lbl_status.ThemeName = "VisualStudio2012Dark";
            // 
            // fp_btn_confirm
            // 
            this.fp_btn_confirm.Location = new System.Drawing.Point(263, 127);
            this.fp_btn_confirm.Name = "fp_btn_confirm";
            this.fp_btn_confirm.Size = new System.Drawing.Size(110, 44);
            this.fp_btn_confirm.TabIndex = 20;
            this.fp_btn_confirm.Text = "Confirm";
            this.fp_btn_confirm.ThemeName = "VisualStudio2012Dark";
            this.fp_btn_confirm.Click += new System.EventHandler(this.fp_btn_confirm_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(23, 32);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(101, 22);
            this.radLabel2.TabIndex = 22;
            this.radLabel2.Text = "New Password:";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // fp_tb_new_pass
            // 
            this.fp_tb_new_pass.Location = new System.Drawing.Point(110, 30);
            this.fp_tb_new_pass.Name = "fp_tb_new_pass";
            this.fp_tb_new_pass.PasswordChar = '*';
            this.fp_tb_new_pass.Size = new System.Drawing.Size(263, 25);
            this.fp_tb_new_pass.TabIndex = 21;
            this.fp_tb_new_pass.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(5, 62);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(123, 22);
            this.radLabel3.TabIndex = 24;
            this.radLabel3.Text = "Confirm Password:";
            this.radLabel3.ThemeName = "VisualStudio2012Dark";
            // 
            // fp_tb_conf_new_pass
            // 
            this.fp_tb_conf_new_pass.Location = new System.Drawing.Point(110, 60);
            this.fp_tb_conf_new_pass.Name = "fp_tb_conf_new_pass";
            this.fp_tb_conf_new_pass.PasswordChar = '*';
            this.fp_tb_conf_new_pass.Size = new System.Drawing.Size(263, 25);
            this.fp_tb_conf_new_pass.TabIndex = 23;
            this.fp_tb_conf_new_pass.ThemeName = "VisualStudio2012Dark";
            // 
            // fp_btn_changepass
            // 
            this.fp_btn_changepass.Location = new System.Drawing.Point(263, 90);
            this.fp_btn_changepass.Name = "fp_btn_changepass";
            this.fp_btn_changepass.Size = new System.Drawing.Size(110, 44);
            this.fp_btn_changepass.TabIndex = 21;
            this.fp_btn_changepass.Text = "Change Password\r\n";
            this.fp_btn_changepass.ThemeName = "VisualStudio2012Dark";
            this.fp_btn_changepass.Click += new System.EventHandler(this.fp_btn_changepass_Click);
            // 
            // fp_timer_studnouser
            // 
            this.fp_timer_studnouser.Tick += new System.EventHandler(this.fp_timer_studnouser_Tick);
            // 
            // fp_rgb_secmeas
            // 
            this.fp_rgb_secmeas.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.fp_rgb_secmeas.Controls.Add(this.fp_cb_securityques);
            this.fp_rgb_secmeas.Controls.Add(this.fp_tb_securityans);
            this.fp_rgb_secmeas.Controls.Add(this.radLabel14);
            this.fp_rgb_secmeas.Controls.Add(this.radLabel15);
            this.fp_rgb_secmeas.Controls.Add(this.fp_btn_confirm);
            this.fp_rgb_secmeas.HeaderText = "Security Measures";
            this.fp_rgb_secmeas.Location = new System.Drawing.Point(19, 129);
            this.fp_rgb_secmeas.Name = "fp_rgb_secmeas";
            this.fp_rgb_secmeas.Size = new System.Drawing.Size(389, 188);
            this.fp_rgb_secmeas.TabIndex = 25;
            this.fp_rgb_secmeas.Text = "Security Measures";
            this.fp_rgb_secmeas.ThemeName = "VisualStudio2012Dark";
            this.fp_rgb_secmeas.Visible = false;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.Controls.Add(this.fp_tb_userstudno);
            this.radGroupBox2.Controls.Add(this.fp_lbl_status);
            this.radGroupBox2.HeaderText = "Account Status";
            this.radGroupBox2.Location = new System.Drawing.Point(19, 23);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(389, 100);
            this.radGroupBox2.TabIndex = 26;
            this.radGroupBox2.Text = "Account Status";
            this.radGroupBox2.ThemeName = "VisualStudio2012Dark";
            // 
            // fp_rgb_changepass
            // 
            this.fp_rgb_changepass.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.fp_rgb_changepass.Controls.Add(this.fp_tb_new_pass);
            this.fp_rgb_changepass.Controls.Add(this.radLabel2);
            this.fp_rgb_changepass.Controls.Add(this.fp_tb_conf_new_pass);
            this.fp_rgb_changepass.Controls.Add(this.fp_btn_changepass);
            this.fp_rgb_changepass.Controls.Add(this.radLabel3);
            this.fp_rgb_changepass.HeaderText = "Change Password";
            this.fp_rgb_changepass.Location = new System.Drawing.Point(19, 323);
            this.fp_rgb_changepass.Name = "fp_rgb_changepass";
            this.fp_rgb_changepass.Size = new System.Drawing.Size(389, 150);
            this.fp_rgb_changepass.TabIndex = 27;
            this.fp_rgb_changepass.Text = "Change Password";
            this.fp_rgb_changepass.ThemeName = "VisualStudio2012Dark";
            this.fp_rgb_changepass.Visible = false;
            // 
            // ForgotPasswordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 478);
            this.Controls.Add(this.fp_rgb_changepass);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.fp_rgb_secmeas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPasswordPage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ForgotPasswordPage";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.ForgotPasswordPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_tb_userstudno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_tb_securityans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_cb_securityques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_lbl_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_btn_confirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_tb_new_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_tb_conf_new_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_btn_changepass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fp_rgb_secmeas)).EndInit();
            this.fp_rgb_secmeas.ResumeLayout(false);
            this.fp_rgb_secmeas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fp_rgb_changepass)).EndInit();
            this.fp_rgb_changepass.ResumeLayout(false);
            this.fp_rgb_changepass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox fp_tb_userstudno;
        private Telerik.WinControls.UI.RadLabel radLabel15;
        private Telerik.WinControls.UI.RadLabel radLabel14;
        private Telerik.WinControls.UI.RadTextBox fp_tb_securityans;
        private Telerik.WinControls.UI.RadDropDownList fp_cb_securityques;
        private Telerik.WinControls.UI.RadLabel fp_lbl_status;
        private Telerik.WinControls.UI.RadButton fp_btn_confirm;
        private Telerik.WinControls.UI.RadTextBox fp_tb_new_pass;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox fp_tb_conf_new_pass;
        private Telerik.WinControls.UI.RadButton fp_btn_changepass;
        private System.Windows.Forms.Timer fp_timer_studnouser;
        private Telerik.WinControls.UI.RadGroupBox fp_rgb_secmeas;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGroupBox fp_rgb_changepass;
    }
}
