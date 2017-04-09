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
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // log_btn_login
            // 
            this.log_btn_login.Location = new System.Drawing.Point(86, 191);
            this.log_btn_login.Name = "log_btn_login";
            this.log_btn_login.Size = new System.Drawing.Size(110, 67);
            this.log_btn_login.TabIndex = 0;
            this.log_btn_login.Text = "Login";
            this.log_btn_login.Click += new System.EventHandler(this.log_btn_login_Click);
            // 
            // log_btn_main
            // 
            this.log_btn_main.Location = new System.Drawing.Point(86, 118);
            this.log_btn_main.Name = "log_btn_main";
            this.log_btn_main.Size = new System.Drawing.Size(110, 67);
            this.log_btn_main.TabIndex = 1;
            this.log_btn_main.Text = "Main";
            this.log_btn_main.Click += new System.EventHandler(this.log_btn_main_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.log_btn_main);
            this.Controls.Add(this.log_btn_login);
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_btn_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton log_btn_login;
        private Telerik.WinControls.UI.RadButton log_btn_main;
    }
}
