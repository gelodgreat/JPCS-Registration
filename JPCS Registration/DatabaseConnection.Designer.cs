namespace JPCS_Registration
{
    partial class DatabaseConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConnection));
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewCurrentConnection = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.lblUsername = new Telerik.WinControls.UI.RadLabel();
            this.lblPort = new Telerik.WinControls.UI.RadLabel();
            this.lblHostname = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radPageViewLocalhosts = new Telerik.WinControls.UI.RadPageViewPage();
            this.lblLocalHosts = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewCurrentConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHostname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.radPageViewLocalhosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocalHosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewCurrentConnection);
            this.radPageView1.Controls.Add(this.radPageViewLocalhosts);
            this.radPageView1.DefaultPage = this.radPageViewCurrentConnection;
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewCurrentConnection;
            this.radPageView1.Size = new System.Drawing.Size(500, 375);
            this.radPageView1.TabIndex = 1;
            this.radPageView1.Text = "All";
            this.radPageView1.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // radPageViewCurrentConnection
            // 
            this.radPageViewCurrentConnection.Controls.Add(this.radLabel3);
            this.radPageViewCurrentConnection.Controls.Add(this.radLabel2);
            this.radPageViewCurrentConnection.Controls.Add(this.lblUsername);
            this.radPageViewCurrentConnection.Controls.Add(this.lblPort);
            this.radPageViewCurrentConnection.Controls.Add(this.lblHostname);
            this.radPageViewCurrentConnection.Controls.Add(this.radLabel1);
            this.radPageViewCurrentConnection.ItemSize = new System.Drawing.SizeF(305F, 37F);
            this.radPageViewCurrentConnection.Location = new System.Drawing.Point(5, 43);
            this.radPageViewCurrentConnection.Name = "radPageViewCurrentConnection";
            this.radPageViewCurrentConnection.Size = new System.Drawing.Size(490, 327);
            this.radPageViewCurrentConnection.Text = "Current Connection Information";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel3.Location = new System.Drawing.Point(87, 158);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(105, 31);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Username:";
            this.radLabel3.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel2.Location = new System.Drawing.Point(64, 121);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(128, 31);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "TCP / IP Port:";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUsername.Location = new System.Drawing.Point(198, 158);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(123, 31);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "lblUsername";
            this.lblUsername.ThemeName = "VisualStudio2012Dark";
            // 
            // lblPort
            // 
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPort.Location = new System.Drawing.Point(198, 121);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(69, 31);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "lblPort";
            this.lblPort.ThemeName = "VisualStudio2012Dark";
            // 
            // lblHostname
            // 
            this.lblHostname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblHostname.Location = new System.Drawing.Point(198, 84);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(124, 31);
            this.lblHostname.TabIndex = 0;
            this.lblHostname.Text = "lblHostname";
            this.lblHostname.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(7, 84);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(192, 31);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Host / Server Name:";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // radPageViewLocalhosts
            // 
            this.radPageViewLocalhosts.Controls.Add(this.lblLocalHosts);
            this.radPageViewLocalhosts.ItemSize = new System.Drawing.SizeF(202F, 37F);
            this.radPageViewLocalhosts.Location = new System.Drawing.Point(5, 43);
            this.radPageViewLocalhosts.Name = "radPageViewLocalhosts";
            this.radPageViewLocalhosts.Size = new System.Drawing.Size(490, 327);
            this.radPageViewLocalhosts.Text = "Host / Server Names";
            // 
            // lblLocalHosts
            // 
            this.lblLocalHosts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLocalHosts.Location = new System.Drawing.Point(7, 77);
            this.lblLocalHosts.Name = "lblLocalHosts";
            this.lblLocalHosts.Size = new System.Drawing.Size(243, 31);
            this.lblLocalHosts.TabIndex = 1;
            this.lblLocalHosts.Text = "Possible Server names:     ";
            this.lblLocalHosts.ThemeName = "VisualStudio2012Dark";
            // 
            // DatabaseConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 375);
            this.Controls.Add(this.radPageView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseConnection";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Connection Information";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.DatabaseConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewCurrentConnection.ResumeLayout(false);
            this.radPageViewCurrentConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHostname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.radPageViewLocalhosts.ResumeLayout(false);
            this.radPageViewLocalhosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocalHosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewCurrentConnection;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel lblUsername;
        private Telerik.WinControls.UI.RadLabel lblPort;
        private Telerik.WinControls.UI.RadLabel lblHostname;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewLocalhosts;
        private Telerik.WinControls.UI.RadLabel lblLocalHosts;
    }
}
