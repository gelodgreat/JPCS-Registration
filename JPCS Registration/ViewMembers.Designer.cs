﻿namespace JPCS_Registration
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radGridMembers = new Telerik.WinControls.UI.RadGridView();
            this.txtSearch = new Telerik.WinControls.UI.RadTextBox();
            this.lbl_schoolyear = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtSearch_All = new Telerik.WinControls.UI.RadTextBox();
            this.radGridAllMembers = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridMembers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_schoolyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.radPageViewPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridAllMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridAllMembers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(969, 482);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.Text = "All";
            this.radPageView1.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Top;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ShowItemCloseButton = false;
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.radLabel3);
            this.radPageViewPage1.Controls.Add(this.radGridMembers);
            this.radPageViewPage1.Controls.Add(this.txtSearch);
            this.radPageViewPage1.Controls.Add(this.lbl_schoolyear);
            this.radPageViewPage1.Controls.Add(this.radLabel2);
            this.radPageViewPage1.Controls.Add(this.radLabel1);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(571F, 37F);
            this.radPageViewPage1.Location = new System.Drawing.Point(5, 43);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(959, 434);
            this.radPageViewPage1.Text = "Current Members List";
            this.radPageViewPage1.Enter += new System.EventHandler(this.radPageViewPage1_Enter);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel3.Location = new System.Drawing.Point(7, 123);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(257, 31);
            this.radLabel3.TabIndex = 10;
            this.radLabel3.Text = "Double-Click row to delete.";
            this.radLabel3.ThemeName = "VisualStudio2012Dark";
            // 
            // radGridMembers
            // 
            this.radGridMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridMembers.AutoScroll = true;
            this.radGridMembers.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically;
            this.radGridMembers.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.radGridMembers.Location = new System.Drawing.Point(0, 160);
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
            this.radGridMembers.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridMembers.Name = "radGridMembers";
            this.radGridMembers.ReadOnly = true;
            this.radGridMembers.Size = new System.Drawing.Size(959, 274);
            this.radGridMembers.TabIndex = 9;
            this.radGridMembers.Text = "radGridView1";
            this.radGridMembers.ThemeName = "VisualStudio2012Dark";
            this.radGridMembers.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridMembers_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(166, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(153, 33);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.ThemeName = "VisualStudio2012Dark";
            this.txtSearch.CausesValidationChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            this.txtSearch.TextChanged += new System.EventHandler(this.radTextBox1_TextChanged);
            this.txtSearch.Validating += new System.ComponentModel.CancelEventHandler(this.txtSearch_Validating);
            // 
            // lbl_schoolyear
            // 
            this.lbl_schoolyear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_schoolyear.Location = new System.Drawing.Point(106, 23);
            this.lbl_schoolyear.Name = "lbl_schoolyear";
            this.lbl_schoolyear.Size = new System.Drawing.Size(146, 31);
            this.lbl_schoolyear.TabIndex = 7;
            this.lbl_schoolyear.Text = "lbl_schoolyear";
            this.lbl_schoolyear.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel2.Location = new System.Drawing.Point(3, 63);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(157, 31);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Search Member:";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(3, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(120, 31);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "School Year:";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Controls.Add(this.radLabel4);
            this.radPageViewPage2.Controls.Add(this.txtSearch_All);
            this.radPageViewPage2.Controls.Add(this.radGridAllMembers);
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(398F, 37F);
            this.radPageViewPage2.Location = new System.Drawing.Point(5, 43);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(959, 434);
            this.radPageViewPage2.Text = "All";
            this.radPageViewPage2.Enter += new System.EventHandler(this.radPageViewPage2_Enter);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel4.Location = new System.Drawing.Point(7, 43);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(74, 31);
            this.radLabel4.TabIndex = 12;
            this.radLabel4.Text = "Search:";
            this.radLabel4.ThemeName = "VisualStudio2012Dark";
            // 
            // txtSearch_All
            // 
            this.txtSearch_All.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch_All.Location = new System.Drawing.Point(97, 43);
            this.txtSearch_All.Name = "txtSearch_All";
            this.txtSearch_All.Size = new System.Drawing.Size(220, 33);
            this.txtSearch_All.TabIndex = 11;
            this.txtSearch_All.ThemeName = "VisualStudio2012Dark";
            this.txtSearch_All.TextChanged += new System.EventHandler(this.txtSearch_All_TextChanged);
            this.txtSearch_All.Validating += new System.ComponentModel.CancelEventHandler(this.txtSearch_All_Validating);
            // 
            // radGridAllMembers
            // 
            this.radGridAllMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridAllMembers.AutoScroll = true;
            this.radGridAllMembers.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically;
            this.radGridAllMembers.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.radGridAllMembers.Location = new System.Drawing.Point(-1, 118);
            // 
            // 
            // 
            this.radGridAllMembers.MasterTemplate.AllowAddNewRow = false;
            this.radGridAllMembers.MasterTemplate.AllowDeleteRow = false;
            this.radGridAllMembers.MasterTemplate.AllowDragToGroup = false;
            this.radGridAllMembers.MasterTemplate.AllowEditRow = false;
            this.radGridAllMembers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.radGridAllMembers.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridAllMembers.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridAllMembers.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridAllMembers.Name = "radGridAllMembers";
            this.radGridAllMembers.ReadOnly = true;
            this.radGridAllMembers.Size = new System.Drawing.Size(959, 305);
            this.radGridAllMembers.TabIndex = 10;
            this.radGridAllMembers.Text = "radGridView1";
            this.radGridAllMembers.ThemeName = "VisualStudio2012Dark";
            // 
            // ViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 482);
            this.Controls.Add(this.radPageView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "ViewMembers";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMembers";
            this.ThemeName = "VisualStudio2012Dark";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            this.radPageViewPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridMembers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_schoolyear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.radPageViewPage2.ResumeLayout(false);
            this.radPageViewPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridAllMembers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridAllMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadGridView radGridMembers;
        private Telerik.WinControls.UI.RadTextBox txtSearch;
        private Telerik.WinControls.UI.RadLabel lbl_schoolyear;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private Telerik.WinControls.UI.RadGridView radGridAllMembers;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtSearch_All;
    }
}
