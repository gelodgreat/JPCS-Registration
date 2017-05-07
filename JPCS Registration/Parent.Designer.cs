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
            this.lbl_User = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_User)).BeginInit();
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
            this.radMenu1.Size = new System.Drawing.Size(794, 27);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "VisualStudio2012Dark";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Tools";
            // 
            // lbl_User
            // 
            this.lbl_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_User.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbl_User.Location = new System.Drawing.Point(12, 462);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(103, 41);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "lbl_user";
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JPCS_Registration.Properties.Resources.jpcs1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(794, 515);
            this.Controls.Add(this.lbl_User);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Parent_FormClosed);
            this.Load += new System.EventHandler(this.Parent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_User)).EndInit();
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
        private Telerik.WinControls.UI.RadLabel lbl_User;
    }
}
