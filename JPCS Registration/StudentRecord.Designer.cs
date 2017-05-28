namespace JPCS_Registration
{
    partial class StudentRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecord));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lblstudno = new Telerik.WinControls.UI.RadLabel();
            this.radGridRecords = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblstudno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridRecords.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(3, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(171, 31);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Student Number: ";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // lblstudno
            // 
            this.lblstudno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblstudno.Location = new System.Drawing.Point(157, 12);
            this.lblstudno.Name = "lblstudno";
            this.lblstudno.Size = new System.Drawing.Size(94, 31);
            this.lblstudno.TabIndex = 0;
            this.lblstudno.Text = "lblstudno";
            this.lblstudno.ThemeName = "VisualStudio2012Dark";
            // 
            // radGridRecords
            // 
            this.radGridRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridRecords.AutoScroll = true;
            this.radGridRecords.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically;
            this.radGridRecords.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.radGridRecords.Location = new System.Drawing.Point(3, 93);
            // 
            // 
            // 
            this.radGridRecords.MasterTemplate.AllowAddNewRow = false;
            this.radGridRecords.MasterTemplate.AllowCellContextMenu = false;
            this.radGridRecords.MasterTemplate.AllowDeleteRow = false;
            this.radGridRecords.MasterTemplate.AllowDragToGroup = false;
            this.radGridRecords.MasterTemplate.AllowEditRow = false;
            this.radGridRecords.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridRecords.MasterTemplate.ClipboardCopyMode = Telerik.WinControls.UI.GridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.radGridRecords.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridRecords.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridRecords.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridRecords.Name = "radGridRecords";
            this.radGridRecords.ReadOnly = true;
            this.radGridRecords.Size = new System.Drawing.Size(325, 287);
            this.radGridRecords.TabIndex = 11;
            this.radGridRecords.Text = "0";
            this.radGridRecords.ThemeName = "VisualStudio2012Dark";
            // 
            // StudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 382);
            this.Controls.Add(this.radGridRecords);
            this.Controls.Add(this.lblstudno);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentRecord";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentRecord";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.StudentRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblstudno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridRecords.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel lblstudno;
        private Telerik.WinControls.UI.RadGridView radGridRecords;
    }
}
