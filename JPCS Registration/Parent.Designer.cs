namespace JPCS_Registration
{
    partial class Parent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent));
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.MemberAdd = new Telerik.WinControls.UI.RadMenuItem();
            this.MemberRenew = new Telerik.WinControls.UI.RadMenuItem();
            this.MemberManage = new Telerik.WinControls.UI.RadMenuItem();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuManageAccount = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSchoolYear = new Telerik.WinControls.UI.RadMenuItem();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelMode = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radLabelServer = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.MemberAdd,
            this.MemberRenew,
            this.MemberManage});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "&Member";
            // 
            // MemberAdd
            // 
            this.MemberAdd.Name = "MemberAdd";
            this.MemberAdd.Text = "&Add Member";
            this.MemberAdd.Click += new System.EventHandler(this.MemberAdd_Click);
            // 
            // MemberRenew
            // 
            this.MemberRenew.Name = "MemberRenew";
            this.MemberRenew.Text = "&Renew Membership";
            this.MemberRenew.Click += new System.EventHandler(this.MemberRenew_Click);
            // 
            // MemberManage
            // 
            this.MemberManage.Name = "MemberManage";
            this.MemberManage.Text = "&Manage Members";
            this.MemberManage.Click += new System.EventHandler(this.MemberManage_Click);
            // 
            // radMenu1
            // 
            this.radMenu1.AllowShowFocusCues = true;
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(794, 33);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "VisualStudio2012Dark";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuManageAccount,
            this.radMenuSchoolYear});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Tools";
            // 
            // radMenuManageAccount
            // 
            this.radMenuManageAccount.Name = "radMenuManageAccount";
            this.radMenuManageAccount.Text = "Manage Accounts";
            this.radMenuManageAccount.Click += new System.EventHandler(this.radMenuManageAccount_Click);
            // 
            // radMenuSchoolYear
            // 
            this.radMenuSchoolYear.Name = "radMenuSchoolYear";
            this.radMenuSchoolYear.Text = "Manage School Year";
            this.radMenuSchoolYear.Click += new System.EventHandler(this.radMenuSchoolYear_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelMode,
            this.commandBarSeparator1,
            this.radLabelServer});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 476);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(794, 39);
            this.radStatusStrip1.TabIndex = 4;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabelMode
            // 
            this.radLabelMode.Name = "radLabelMode";
            this.radStatusStrip1.SetSpring(this.radLabelMode, false);
            this.radLabelMode.Text = "radLabelMode";
            this.radLabelMode.TextWrap = true;
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator1, false);
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // radLabelServer
            // 
            this.radLabelServer.Name = "radLabelServer";
            this.radStatusStrip1.SetSpring(this.radLabelServer, false);
            this.radLabelServer.Text = "radLabelServer";
            this.radLabelServer.TextWrap = true;
            this.radLabelServer.Click += new System.EventHandler(this.radLabelServer_Click);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JPCS_Registration.Properties.Resources.jpcs1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(794, 515);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Parent";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Junior Philippine Computer Society Student Records Management System";
            this.ThemeName = "VisualStudio2012Dark";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Parent_FormClosed);
            this.Load += new System.EventHandler(this.Parent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem MemberAdd;
        private Telerik.WinControls.UI.RadMenuItem MemberManage;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem MemberRenew;
        private Telerik.WinControls.UI.RadMenuItem radMenuSchoolYear;
        private Telerik.WinControls.UI.RadMenuItem radMenuManageAccount;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelMode;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.RadLabelElement radLabelServer;
    }
}
