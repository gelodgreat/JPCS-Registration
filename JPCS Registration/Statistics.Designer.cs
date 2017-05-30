namespace JPCS_Registration
{
    partial class Statistics
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lblTotalCash = new Telerik.WinControls.UI.RadLabel();
            this.radGridStat = new Telerik.WinControls.UI.RadGridView();
            this.lblSchoolYear = new Telerik.WinControls.UI.RadLabel();
            this.lblTotalRows = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridStat.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSchoolYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(12, 140);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(108, 31);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Total Cash:";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // lblTotalCash
            // 
            this.lblTotalCash.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalCash.Location = new System.Drawing.Point(112, 140);
            this.lblTotalCash.Name = "lblTotalCash";
            this.lblTotalCash.Size = new System.Drawing.Size(120, 31);
            this.lblTotalCash.TabIndex = 1;
            this.lblTotalCash.Text = "lblTotalCash";
            this.lblTotalCash.ThemeName = "VisualStudio2012Dark";
            // 
            // radGridStat
            // 
            this.radGridStat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridStat.AutoScroll = true;
            this.radGridStat.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically;
            this.radGridStat.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.radGridStat.Location = new System.Drawing.Point(12, 207);
            // 
            // 
            // 
            this.radGridStat.MasterTemplate.AllowAddNewRow = false;
            this.radGridStat.MasterTemplate.AllowDeleteRow = false;
            this.radGridStat.MasterTemplate.AllowDragToGroup = false;
            this.radGridStat.MasterTemplate.AllowEditRow = false;
            this.radGridStat.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridStat.MasterTemplate.ClipboardCopyMode = Telerik.WinControls.UI.GridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.radGridStat.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridStat.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridStat.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridStat.Name = "radGridStat";
            this.radGridStat.ReadOnly = true;
            this.radGridStat.Size = new System.Drawing.Size(364, 269);
            this.radGridStat.TabIndex = 10;
            this.radGridStat.Text = "0";
            this.radGridStat.ThemeName = "VisualStudio2012Dark";
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblSchoolYear.Location = new System.Drawing.Point(87, 12);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.Size = new System.Drawing.Size(219, 51);
            this.lblSchoolYear.TabIndex = 11;
            this.lblSchoolYear.Text = "lblSchoolYear";
            this.lblSchoolYear.ThemeName = "VisualStudio2012Dark";
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalRows.Location = new System.Drawing.Point(13, 81);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(125, 31);
            this.lblTotalRows.TabIndex = 12;
            this.lblTotalRows.Text = "lblTotalRows";
            this.lblTotalRows.ThemeName = "VisualStudio2012Dark";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 488);
            this.Controls.Add(this.lblTotalRows);
            this.Controls.Add(this.lblSchoolYear);
            this.Controls.Add(this.radGridStat);
            this.Controls.Add(this.lblTotalCash);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Statistics";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridStat.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSchoolYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel lblTotalCash;
        private Telerik.WinControls.UI.RadGridView radGridStat;
        private Telerik.WinControls.UI.RadLabel lblSchoolYear;
        private Telerik.WinControls.UI.RadLabel lblTotalRows;
    }
}
