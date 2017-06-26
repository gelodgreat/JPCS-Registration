namespace JPCS_Registration
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.log_btn_login = new Telerik.WinControls.UI.RadButton();
            this.log_btn_main = new Telerik.WinControls.UI.RadButton();
            this.log_rgb_container = new Telerik.WinControls.UI.RadGroupBox();
            this.log_btn_forgotpass = new Telerik.WinControls.UI.RadButton();
            this.log_tb_password = new Telerik.WinControls.UI.RadTextBox();
            this.log_tb_username = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.log_btn_settings = new Telerik.WinControls.UI.RadButton();
            this.log_server_status = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_rgb_container)).BeginInit();
            this.log_rgb_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_forgotpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_tb_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_tb_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_server_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // log_btn_login
            // 
            this.log_btn_login.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.log_btn_login.Location = new System.Drawing.Point(49, 143);
            this.log_btn_login.Name = "log_btn_login";
            this.log_btn_login.Size = new System.Drawing.Size(317, 41);
            this.log_btn_login.TabIndex = 0;
            this.log_btn_login.Text = "Officer Login";
            this.log_btn_login.ThemeName = "VisualStudio2012Dark";
            this.log_btn_login.Click += new System.EventHandler(this.log_btn_login_Click);
            // 
            // log_btn_main
            // 
            this.log_btn_main.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.log_btn_main.Location = new System.Drawing.Point(5, 214);
            this.log_btn_main.Name = "log_btn_main";
            this.log_btn_main.Size = new System.Drawing.Size(154, 67);
            this.log_btn_main.TabIndex = 1;
            this.log_btn_main.Text = "Guest Access";
            this.log_btn_main.ThemeName = "VisualStudio2012Dark";
            this.log_btn_main.Click += new System.EventHandler(this.log_btn_main_Click);
            // 
            // log_rgb_container
            // 
            this.log_rgb_container.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.log_rgb_container.Controls.Add(this.log_btn_forgotpass);
            this.log_rgb_container.Controls.Add(this.log_btn_main);
            this.log_rgb_container.Controls.Add(this.log_tb_password);
            this.log_rgb_container.Controls.Add(this.log_btn_login);
            this.log_rgb_container.Controls.Add(this.log_tb_username);
            this.log_rgb_container.Controls.Add(this.radLabel2);
            this.log_rgb_container.Controls.Add(this.radLabel1);
            this.log_rgb_container.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.log_rgb_container.HeaderText = "Login";
            this.log_rgb_container.Location = new System.Drawing.Point(13, 49);
            this.log_rgb_container.Name = "log_rgb_container";
            this.log_rgb_container.Size = new System.Drawing.Size(404, 298);
            this.log_rgb_container.TabIndex = 2;
            this.log_rgb_container.Text = "Login";
            this.log_rgb_container.ThemeName = "VisualStudio2012Dark";
            this.log_rgb_container.Enter += new System.EventHandler(this.log_rgb_container_Enter);
            // 
            // log_btn_forgotpass
            // 
            this.log_btn_forgotpass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.log_btn_forgotpass.Location = new System.Drawing.Point(211, 214);
            this.log_btn_forgotpass.Name = "log_btn_forgotpass";
            this.log_btn_forgotpass.Size = new System.Drawing.Size(179, 67);
            this.log_btn_forgotpass.TabIndex = 4;
            this.log_btn_forgotpass.Text = "Forgot Password?\r\n";
            this.log_btn_forgotpass.ThemeName = "VisualStudio2012Dark";
            this.log_btn_forgotpass.Click += new System.EventHandler(this.log_btn_forgotpass_Click);
            // 
            // log_tb_password
            // 
            this.log_tb_password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.log_tb_password.Location = new System.Drawing.Point(131, 85);
            this.log_tb_password.MaxLength = 255;
            this.log_tb_password.Name = "log_tb_password";
            this.log_tb_password.PasswordChar = '*';
            this.log_tb_password.Size = new System.Drawing.Size(216, 33);
            this.log_tb_password.TabIndex = 3;
            this.log_tb_password.ThemeName = "VisualStudio2012Dark";
            // 
            // log_tb_username
            // 
            this.log_tb_username.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.log_tb_username.Location = new System.Drawing.Point(131, 38);
            this.log_tb_username.MaxLength = 255;
            this.log_tb_username.Name = "log_tb_username";
            this.log_tb_username.Size = new System.Drawing.Size(216, 33);
            this.log_tb_username.TabIndex = 2;
            this.log_tb_username.ThemeName = "VisualStudio2012Dark";
            this.log_tb_username.MouseEnter += new System.EventHandler(this.log_tb_username_MouseEnter);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel2.Location = new System.Drawing.Point(26, 87);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(99, 31);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Password:";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(23, 40);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(105, 31);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Username:";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // log_btn_settings
            // 
            this.log_btn_settings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.log_btn_settings.Location = new System.Drawing.Point(328, 13);
            this.log_btn_settings.Name = "log_btn_settings";
            this.log_btn_settings.Size = new System.Drawing.Size(89, 30);
            this.log_btn_settings.TabIndex = 1;
            this.log_btn_settings.Text = "Settings";
            this.log_btn_settings.ThemeName = "VisualStudio2012Dark";
            this.log_btn_settings.Click += new System.EventHandler(this.log_btn_settings_Click);
            this.log_btn_settings.MouseEnter += new System.EventHandler(this.log_btn_settings_MouseEnter);
            // 
            // log_server_status
            // 
            this.log_server_status.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.log_server_status.Location = new System.Drawing.Point(18, 12);
            this.log_server_status.Name = "log_server_status";
            this.log_server_status.Size = new System.Drawing.Size(127, 31);
            this.log_server_status.TabIndex = 4;
            this.log_server_status.Text = "Server Status";
            this.log_server_status.ThemeName = "VisualStudio2012Dark";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 359);
            this.Controls.Add(this.log_server_status);
            this.Controls.Add(this.log_btn_settings);
            this.Controls.Add(this.log_rgb_container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ThemeName = "VisualStudio2012Dark";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_rgb_container)).EndInit();
            this.log_rgb_container.ResumeLayout(false);
            this.log_rgb_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_forgotpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_tb_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_tb_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_server_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton log_btn_login;
        private Telerik.WinControls.UI.RadButton log_btn_main;
        private Telerik.WinControls.UI.RadGroupBox log_rgb_container;
        private Telerik.WinControls.UI.RadButton log_btn_forgotpass;
        private Telerik.WinControls.UI.RadTextBox log_tb_password;
        private Telerik.WinControls.UI.RadTextBox log_tb_username;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadButton log_btn_settings;
        private Telerik.WinControls.UI.RadLabel log_server_status;
    }
}
