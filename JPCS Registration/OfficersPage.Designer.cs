﻿namespace JPCS_Registration
{
    partial class OfficersPage
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
            this.rgv_registeredmembers = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgb_courses = new Telerik.WinControls.UI.RadGroupBox();
            this.op_rb_bscpe = new Telerik.WinControls.UI.RadRadioButton();
            this.op_rb_bscs = new Telerik.WinControls.UI.RadRadioButton();
            this.op_rb_bsit = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.op_cb_combosections = new Telerik.WinControls.UI.RadDropDownList();
            this.op_btn_clearselection = new Telerik.WinControls.UI.RadButton();
            this.op_btn_add_account = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_registeredmembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_registeredmembers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgb_courses)).BeginInit();
            this.rgb_courses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.op_rb_bscpe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_rb_bscs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_rb_bsit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_cb_combosections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_btn_clearselection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_btn_add_account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgv_registeredmembers
            // 
            this.rgv_registeredmembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgv_registeredmembers.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.rgv_registeredmembers.MasterTemplate.AllowAddNewRow = false;
            this.rgv_registeredmembers.MasterTemplate.AllowDeleteRow = false;
            this.rgv_registeredmembers.MasterTemplate.AllowEditRow = false;
            this.rgv_registeredmembers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.rgv_registeredmembers.MasterTemplate.EnableGrouping = false;
            this.rgv_registeredmembers.MasterTemplate.ShowRowHeaderColumn = false;
            this.rgv_registeredmembers.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgv_registeredmembers.Name = "rgv_registeredmembers";
            this.rgv_registeredmembers.ReadOnly = true;
            this.rgv_registeredmembers.Size = new System.Drawing.Size(1028, 341);
            this.rgv_registeredmembers.TabIndex = 0;
            this.rgv_registeredmembers.Text = "radGridView1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.rgv_registeredmembers);
            this.radGroupBox1.HeaderText = "Registered Members";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 47);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1032, 361);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Registered Members";
            // 
            // rgb_courses
            // 
            this.rgb_courses.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgb_courses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rgb_courses.Controls.Add(this.op_rb_bscpe);
            this.rgb_courses.Controls.Add(this.op_rb_bscs);
            this.rgb_courses.Controls.Add(this.op_rb_bsit);
            this.rgb_courses.HeaderText = "";
            this.rgb_courses.Location = new System.Drawing.Point(254, 12);
            this.rgb_courses.Name = "rgb_courses";
            this.rgb_courses.Size = new System.Drawing.Size(162, 31);
            this.rgb_courses.TabIndex = 2;
            // 
            // op_rb_bscpe
            // 
            this.op_rb_bscpe.Location = new System.Drawing.Point(106, 8);
            this.op_rb_bscpe.Name = "op_rb_bscpe";
            this.op_rb_bscpe.Size = new System.Drawing.Size(52, 18);
            this.op_rb_bscpe.TabIndex = 1;
            this.op_rb_bscpe.TabStop = false;
            this.op_rb_bscpe.Text = "BSCPE";
            this.op_rb_bscpe.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.op_rb_bsit_ToggleStateChanged);
            // 
            // op_rb_bscs
            // 
            this.op_rb_bscs.Location = new System.Drawing.Point(54, 8);
            this.op_rb_bscs.Name = "op_rb_bscs";
            this.op_rb_bscs.Size = new System.Drawing.Size(46, 18);
            this.op_rb_bscs.TabIndex = 1;
            this.op_rb_bscs.TabStop = false;
            this.op_rb_bscs.Text = "BSCS";
            this.op_rb_bscs.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.op_rb_bscs_ToggleStateChanged);
            // 
            // op_rb_bsit
            // 
            this.op_rb_bsit.Location = new System.Drawing.Point(6, 8);
            this.op_rb_bsit.Name = "op_rb_bsit";
            this.op_rb_bsit.Size = new System.Drawing.Size(42, 18);
            this.op_rb_bsit.TabIndex = 0;
            this.op_rb_bsit.TabStop = false;
            this.op_rb_bsit.Text = "BSIT";
            this.op_rb_bsit.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.op_rb_bsit_ToggleStateChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Location = new System.Drawing.Point(210, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(38, 18);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Filters:";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel2.Location = new System.Drawing.Point(484, 20);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(50, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Sections:";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton1.Location = new System.Drawing.Point(897, 414);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(147, 81);
            this.radButton1.TabIndex = 6;
            this.radButton1.Text = "Print";
            // 
            // op_cb_combosections
            // 
            this.op_cb_combosections.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.op_cb_combosections.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.op_cb_combosections.Location = new System.Drawing.Point(540, 18);
            this.op_cb_combosections.Name = "op_cb_combosections";
            this.op_cb_combosections.Size = new System.Drawing.Size(327, 20);
            this.op_cb_combosections.TabIndex = 7;
            this.op_cb_combosections.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.op_cb_combosections_SelectedIndexChanged);
            // 
            // op_btn_clearselection
            // 
            this.op_btn_clearselection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.op_btn_clearselection.Location = new System.Drawing.Point(422, 13);
            this.op_btn_clearselection.Name = "op_btn_clearselection";
            this.op_btn_clearselection.Size = new System.Drawing.Size(56, 30);
            this.op_btn_clearselection.TabIndex = 7;
            this.op_btn_clearselection.Text = "Clear";
            this.op_btn_clearselection.Click += new System.EventHandler(this.op_btn_clearselection_Click);
            // 
            // op_btn_add_account
            // 
            this.op_btn_add_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.op_btn_add_account.Location = new System.Drawing.Point(744, 414);
            this.op_btn_add_account.Name = "op_btn_add_account";
            this.op_btn_add_account.Size = new System.Drawing.Size(147, 81);
            this.op_btn_add_account.TabIndex = 7;
            this.op_btn_add_account.Text = "Add New Authorized \r\nAccount";
            this.op_btn_add_account.Click += new System.EventHandler(this.op_btn_add_account_Click);
            // 
            // OfficersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 618);
            this.Controls.Add(this.op_btn_add_account);
            this.Controls.Add(this.op_btn_clearselection);
            this.Controls.Add(this.op_cb_combosections);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rgb_courses);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "OfficersPage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OfficersPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OfficersPage_FormClosed);
            this.Load += new System.EventHandler(this.OfficersPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgv_registeredmembers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgv_registeredmembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgb_courses)).EndInit();
            this.rgb_courses.ResumeLayout(false);
            this.rgb_courses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.op_rb_bscpe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_rb_bscs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_rb_bsit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_cb_combosections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_btn_clearselection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_btn_add_account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgv_registeredmembers;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox rgb_courses;
        private Telerik.WinControls.UI.RadRadioButton op_rb_bscpe;
        private Telerik.WinControls.UI.RadRadioButton op_rb_bscs;
        private Telerik.WinControls.UI.RadRadioButton op_rb_bsit;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadDropDownList op_cb_combosections;
        private Telerik.WinControls.UI.RadButton op_btn_clearselection;
        private Telerik.WinControls.UI.RadButton op_btn_add_account;
    }
}
