namespace JPCS_Registration
{
    partial class ViewMembers
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.lbl_schoolyear = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radGridMembers = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_schoolyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridMembers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(97, 25);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "School Year:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel2.Location = new System.Drawing.Point(12, 52);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(60, 25);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Search:";
            // 
            // lbl_schoolyear
            // 
            this.lbl_schoolyear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_schoolyear.Location = new System.Drawing.Point(115, 12);
            this.lbl_schoolyear.Name = "lbl_schoolyear";
            this.lbl_schoolyear.Size = new System.Drawing.Size(117, 25);
            this.lbl_schoolyear.TabIndex = 2;
            this.lbl_schoolyear.Text = "lbl_schoolyear";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radTextBox1.Location = new System.Drawing.Point(78, 52);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(153, 27);
            this.radTextBox1.TabIndex = 3;
            // 
            // radGridMembers
            // 
            this.radGridMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridMembers.AutoScroll = true;
            this.radGridMembers.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically;
            this.radGridMembers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radGridMembers.Location = new System.Drawing.Point(9, 146);
            // 
            // 
            // 
            this.radGridMembers.MasterTemplate.AllowAddNewRow = false;
            this.radGridMembers.MasterTemplate.AllowDeleteRow = false;
            this.radGridMembers.MasterTemplate.AllowDragToGroup = false;
            this.radGridMembers.MasterTemplate.AllowEditRow = false;
            this.radGridMembers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridMembers.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridMembers.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridMembers.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridMembers.Name = "radGridMembers";
            this.radGridMembers.ReadOnly = true;
            this.radGridMembers.Size = new System.Drawing.Size(948, 354);
            this.radGridMembers.TabIndex = 4;
            this.radGridMembers.Text = "radGridView1";
            // 
            // ViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 512);
            this.Controls.Add(this.radGridMembers);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.lbl_schoolyear);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "ViewMembers";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMembers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_schoolyear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridMembers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel lbl_schoolyear;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadGridView radGridMembers;
    }
}
