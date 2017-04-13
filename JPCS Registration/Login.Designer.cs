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
            this.log_btn_login = new Telerik.WinControls.UI.RadButton();
            this.log_btn_main = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.log_tb_password = new Telerik.WinControls.UI.RadTextBox();
            this.log_tb_username = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_tb_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_tb_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // log_btn_login
            // 
            this.log_btn_login.Location = new System.Drawing.Point(5, 129);
            this.log_btn_login.Name = "log_btn_login";
            this.log_btn_login.Size = new System.Drawing.Size(317, 41);
            this.log_btn_login.TabIndex = 0;
            this.log_btn_login.Text = "Officer Login";
            this.log_btn_login.Click += new System.EventHandler(this.log_btn_login_Click);
            // 
            // log_btn_main
            // 
            this.log_btn_main.Location = new System.Drawing.Point(5, 176);
            this.log_btn_main.Name = "log_btn_main";
            this.log_btn_main.Size = new System.Drawing.Size(154, 67);
            this.log_btn_main.TabIndex = 1;
            this.log_btn_main.Text = "Member Registration";
            this.log_btn_main.Click += new System.EventHandler(this.log_btn_main_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Controls.Add(this.log_btn_main);
            this.radGroupBox1.Controls.Add(this.log_tb_password);
            this.radGroupBox1.Controls.Add(this.log_btn_login);
            this.radGroupBox1.Controls.Add(this.log_tb_username);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Login Box";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 49);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(327, 255);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Login Box";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(165, 176);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(157, 67);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "Forgot Password?\r\n";
            // 
            // log_tb_password
            // 
            this.log_tb_password.Location = new System.Drawing.Point(88, 85);
            this.log_tb_password.Name = "log_tb_password";
            this.log_tb_password.PasswordChar = '*';
            this.log_tb_password.Size = new System.Drawing.Size(216, 20);
            this.log_tb_password.TabIndex = 3;
            // 
            // log_tb_username
            // 
            this.log_tb_username.Location = new System.Drawing.Point(88, 38);
            this.log_tb_username.Name = "log_tb_username";
            this.log_tb_username.Size = new System.Drawing.Size(216, 20);
            this.log_tb_username.TabIndex = 2;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(26, 87);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(56, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Password:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(23, 40);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(59, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Username:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(261, 25);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(74, 18);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Bypass BITCH";
            this.radLabel3.Click += new System.EventHandler(this.radLabel3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 308);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_tb_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_tb_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton log_btn_login;
        private Telerik.WinControls.UI.RadButton log_btn_main;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadTextBox log_tb_password;
        private Telerik.WinControls.UI.RadTextBox log_tb_username;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}
