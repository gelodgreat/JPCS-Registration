namespace JPCS_Registration
{
    partial class SchoolYearManagement
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
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup1 = new Telerik.WinControls.UI.ListViewDataItemGroup("Test");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolYearManagement));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lblActiveSchoolYear = new Telerik.WinControls.UI.RadLabel();
            this.lvSchoolYear = new Telerik.WinControls.UI.RadListView();
            this.btnActivate = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblActiveSchoolYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSchoolYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActivate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(12, 100);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(181, 31);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Active School Year:";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // lblActiveSchoolYear
            // 
            this.lblActiveSchoolYear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblActiveSchoolYear.Location = new System.Drawing.Point(199, 100);
            this.lblActiveSchoolYear.Name = "lblActiveSchoolYear";
            this.lblActiveSchoolYear.Size = new System.Drawing.Size(188, 31);
            this.lblActiveSchoolYear.TabIndex = 1;
            this.lblActiveSchoolYear.Text = "lblActiveSchoolYear";
            this.lblActiveSchoolYear.ThemeName = "VisualStudio2012Dark";
            // 
            // lvSchoolYear
            // 
            this.lvSchoolYear.Font = new System.Drawing.Font("Segoe UI", 12F);
            listViewDataItemGroup1.Text = "Test";
            this.lvSchoolYear.Groups.AddRange(new Telerik.WinControls.UI.ListViewDataItemGroup[] {
            listViewDataItemGroup1});
            this.lvSchoolYear.Location = new System.Drawing.Point(22, 176);
            this.lvSchoolYear.Name = "lvSchoolYear";
            this.lvSchoolYear.Size = new System.Drawing.Size(180, 202);
            this.lvSchoolYear.TabIndex = 2;
            this.lvSchoolYear.Text = "radListView1";
            this.lvSchoolYear.ThemeName = "VisualStudio2012Dark";
            // 
            // btnActivate
            // 
            this.btnActivate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnActivate.Location = new System.Drawing.Point(13, 445);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(207, 35);
            this.btnActivate.TabIndex = 3;
            this.btnActivate.Text = "Activate School Year";
            this.btnActivate.ThemeName = "VisualStudio2012Dark";
            // 
            // SchoolYearManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 548);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.lvSchoolYear);
            this.Controls.Add(this.lblActiveSchoolYear);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchoolYearManagement";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "SchoolYearManagement";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.SchoolYearManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblActiveSchoolYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSchoolYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActivate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel lblActiveSchoolYear;
        private Telerik.WinControls.UI.RadListView lvSchoolYear;
        private Telerik.WinControls.UI.RadButton btnActivate;
    }
}
