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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolYearManagement));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lblActiveSchoolYear = new Telerik.WinControls.UI.RadLabel();
            this.btnActivate = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.mtbSchoolYear = new System.Windows.Forms.MaskedTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.lvSchoolYear = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblActiveSchoolYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActivate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSchoolYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
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
            // btnActivate
            // 
            this.btnActivate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnActivate.Location = new System.Drawing.Point(30, 341);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(207, 35);
            this.btnActivate.TabIndex = 3;
            this.btnActivate.Text = "Activate School Year";
            this.btnActivate.ThemeName = "VisualStudio2012Dark";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.Location = new System.Drawing.Point(30, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete School Year";
            this.btnDelete.ThemeName = "VisualStudio2012Dark";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mtbSchoolYear
            // 
            this.mtbSchoolYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.mtbSchoolYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbSchoolYear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbSchoolYear.ForeColor = System.Drawing.Color.White;
            this.mtbSchoolYear.Location = new System.Drawing.Point(448, 194);
            this.mtbSchoolYear.Mask = "0000\\-0000";
            this.mtbSchoolYear.Name = "mtbSchoolYear";
            this.mtbSchoolYear.PromptChar = 'x';
            this.mtbSchoolYear.Size = new System.Drawing.Size(113, 34);
            this.mtbSchoolYear.TabIndex = 5;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel2.Location = new System.Drawing.Point(326, 194);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(116, 31);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "School Year";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.Location = new System.Drawing.Point(354, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(207, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add School Year";
            this.btnAdd.ThemeName = "VisualStudio2012Dark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvSchoolYear
            // 
            this.lvSchoolYear.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.lvSchoolYear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvSchoolYear.Location = new System.Drawing.Point(17, 45);
            this.lvSchoolYear.Name = "lvSchoolYear";
            this.lvSchoolYear.Size = new System.Drawing.Size(199, 36);
            this.lvSchoolYear.TabIndex = 7;
            this.lvSchoolYear.Text = "radDropDownList1";
            this.lvSchoolYear.ThemeName = "VisualStudio2012Dark";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.radGroupBox1.Controls.Add(this.lvSchoolYear);
            this.radGroupBox1.HeaderText = "Available School Year";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 194);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(250, 125);
            this.radGroupBox1.TabIndex = 8;
            this.radGroupBox1.Text = "Available School Year";
            this.radGroupBox1.ThemeName = "VisualStudio2012Dark";
            // 
            // SchoolYearManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 548);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.mtbSchoolYear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.lblActiveSchoolYear);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchoolYearManagement";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolYearManagement";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.SchoolYearManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblActiveSchoolYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActivate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvSchoolYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel lblActiveSchoolYear;
        private Telerik.WinControls.UI.RadButton btnActivate;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private System.Windows.Forms.MaskedTextBox mtbSchoolYear;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadDropDownList lvSchoolYear;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}
