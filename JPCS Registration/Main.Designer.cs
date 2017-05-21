namespace JPCS_Registration
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.reg_cb_coursesect = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.reg_btn_save = new Telerik.WinControls.UI.RadButton();
            this.timersec = new System.Windows.Forms.Timer(this.components);
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.reg_tb_lname = new Telerik.WinControls.UI.RadTextBox();
            this.reg_tb_fname = new Telerik.WinControls.UI.RadTextBox();
            this.reg_tb_mname = new Telerik.WinControls.UI.RadTextBox();
            this.reg_tb_email = new Telerik.WinControls.UI.RadTextBox();
            this.reg_tb_bday = new Telerik.WinControls.UI.RadDateTimePicker();
            this.reg_tb_nationality = new Telerik.WinControls.UI.RadTextBox();
            this.reg_tb_cityaddress = new Telerik.WinControls.UI.RadTextBox();
            this.reg_tb_provaddress = new Telerik.WinControls.UI.RadTextBox();
            this.reg_tb_contactnum = new Telerik.WinControls.UI.RadTextBox();
            this.reg_tb_emergencycontactname = new Telerik.WinControls.UI.RadTextBox();
            this.reg_tb_emergenctcontactnumber = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel11 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel14 = new Telerik.WinControls.UI.RadLabel();
            this.reg_tb_studno = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            ((System.ComponentModel.ISupportInitialize)(this.reg_cb_coursesect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_btn_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_lname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_fname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_mname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_bday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_nationality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_cityaddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_provaddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_contactnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_emergencycontactname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_emergenctcontactnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_cb_coursesect
            // 
            this.reg_cb_coursesect.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.reg_cb_coursesect.Font = new System.Drawing.Font("Segoe UI", 10F);
            radListDataItem1.Text = "Information Technology";
            radListDataItem2.Text = "Computer Science";
            radListDataItem3.Text = "Computer Engineering";
            this.reg_cb_coursesect.Items.Add(radListDataItem1);
            this.reg_cb_coursesect.Items.Add(radListDataItem2);
            this.reg_cb_coursesect.Items.Add(radListDataItem3);
            this.reg_cb_coursesect.Location = new System.Drawing.Point(227, 146);
            this.reg_cb_coursesect.Name = "reg_cb_coursesect";
            this.reg_cb_coursesect.Size = new System.Drawing.Size(272, 32);
            this.reg_cb_coursesect.TabIndex = 6;
            this.reg_cb_coursesect.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(135, 10);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(86, 26);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Student #:";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(130, 43);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(92, 26);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Last Name:";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(77, 146);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(146, 26);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Course / Program:";
            this.radLabel3.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_btn_save
            // 
            this.reg_btn_save.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_btn_save.Location = new System.Drawing.Point(251, 575);
            this.reg_btn_save.Name = "reg_btn_save";
            this.reg_btn_save.Size = new System.Drawing.Size(194, 51);
            this.reg_btn_save.TabIndex = 15;
            this.reg_btn_save.Text = "Register";
            this.reg_btn_save.ThemeName = "VisualStudio2012Dark";
            this.reg_btn_save.Click += new System.EventHandler(this.reg_btn_save_Click);
            // 
            // timersec
            // 
            this.timersec.Enabled = true;
            this.timersec.Tick += new System.EventHandler(this.timersec_Tick);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(128, 77);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(93, 26);
            this.radLabel4.TabIndex = 10;
            this.radLabel4.Text = "First Name:";
            this.radLabel4.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel5.Location = new System.Drawing.Point(108, 112);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(115, 26);
            this.radLabel5.TabIndex = 11;
            this.radLabel5.Text = "Middle Name:";
            this.radLabel5.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_tb_lname
            // 
            this.reg_tb_lname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.reg_tb_lname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_tb_lname.Location = new System.Drawing.Point(227, 40);
            this.reg_tb_lname.Name = "reg_tb_lname";
            this.reg_tb_lname.Size = new System.Drawing.Size(272, 29);
            this.reg_tb_lname.TabIndex = 3;
            this.reg_tb_lname.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_tb_fname
            // 
            this.reg_tb_fname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.reg_tb_fname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_tb_fname.Location = new System.Drawing.Point(227, 74);
            this.reg_tb_fname.Name = "reg_tb_fname";
            this.reg_tb_fname.Size = new System.Drawing.Size(272, 29);
            this.reg_tb_fname.TabIndex = 4;
            this.reg_tb_fname.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_tb_mname
            // 
            this.reg_tb_mname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.reg_tb_mname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_tb_mname.Location = new System.Drawing.Point(227, 109);
            this.reg_tb_mname.Name = "reg_tb_mname";
            this.reg_tb_mname.Size = new System.Drawing.Size(272, 29);
            this.reg_tb_mname.TabIndex = 5;
            this.reg_tb_mname.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_tb_email
            // 
            this.reg_tb_email.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_tb_email.Location = new System.Drawing.Point(227, 187);
            this.reg_tb_email.Name = "reg_tb_email";
            this.reg_tb_email.Size = new System.Drawing.Size(272, 29);
            this.reg_tb_email.TabIndex = 7;
            this.reg_tb_email.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_tb_bday
            // 
            this.reg_tb_bday.CustomFormat = "yyyy-MM-dd";
            this.reg_tb_bday.Enabled = false;
            this.reg_tb_bday.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_tb_bday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reg_tb_bday.Location = new System.Drawing.Point(228, 224);
            this.reg_tb_bday.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.reg_tb_bday.Name = "reg_tb_bday";
            this.reg_tb_bday.NullText = "YYYY-MM-dd";
            this.reg_tb_bday.ShowUpDown = true;
            this.reg_tb_bday.Size = new System.Drawing.Size(148, 27);
            this.reg_tb_bday.TabIndex = 8;
            this.reg_tb_bday.TabStop = false;
            this.reg_tb_bday.ThemeName = "VisualStudio2012Dark";
            this.reg_tb_bday.Value = new System.DateTime(((long)(0)));
            this.reg_tb_bday.ValueChanged += new System.EventHandler(this.reg_tb_bday_ValueChanged);
            // 
            // reg_tb_nationality
            // 
            this.reg_tb_nationality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_tb_nationality.Location = new System.Drawing.Point(225, 264);
            this.reg_tb_nationality.Name = "reg_tb_nationality";
            this.reg_tb_nationality.Size = new System.Drawing.Size(164, 29);
            this.reg_tb_nationality.TabIndex = 9;
            this.reg_tb_nationality.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_tb_cityaddress
            // 
            this.reg_tb_cityaddress.AutoSize = false;
            this.reg_tb_cityaddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_tb_cityaddress.Location = new System.Drawing.Point(221, 304);
            this.reg_tb_cityaddress.Multiline = true;
            this.reg_tb_cityaddress.Name = "reg_tb_cityaddress";
            this.reg_tb_cityaddress.Size = new System.Drawing.Size(334, 53);
            this.reg_tb_cityaddress.TabIndex = 10;
            this.reg_tb_cityaddress.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_tb_provaddress
            // 
            this.reg_tb_provaddress.AutoSize = false;
            this.reg_tb_provaddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_tb_provaddress.Location = new System.Drawing.Point(221, 368);
            this.reg_tb_provaddress.Multiline = true;
            this.reg_tb_provaddress.Name = "reg_tb_provaddress";
            this.reg_tb_provaddress.Size = new System.Drawing.Size(330, 53);
            this.reg_tb_provaddress.TabIndex = 11;
            this.reg_tb_provaddress.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_tb_contactnum
            // 
            this.reg_tb_contactnum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_tb_contactnum.Location = new System.Drawing.Point(221, 435);
            this.reg_tb_contactnum.Name = "reg_tb_contactnum";
            this.reg_tb_contactnum.Size = new System.Drawing.Size(330, 29);
            this.reg_tb_contactnum.TabIndex = 12;
            this.reg_tb_contactnum.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_tb_emergencycontactname
            // 
            this.reg_tb_emergencycontactname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_tb_emergencycontactname.Location = new System.Drawing.Point(227, 486);
            this.reg_tb_emergencycontactname.Name = "reg_tb_emergencycontactname";
            this.reg_tb_emergencycontactname.Size = new System.Drawing.Size(328, 29);
            this.reg_tb_emergencycontactname.TabIndex = 13;
            this.reg_tb_emergencycontactname.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_tb_emergenctcontactnumber
            // 
            this.reg_tb_emergenctcontactnumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_tb_emergenctcontactnumber.Location = new System.Drawing.Point(233, 530);
            this.reg_tb_emergenctcontactnumber.Name = "reg_tb_emergenctcontactnumber";
            this.reg_tb_emergenctcontactnumber.Size = new System.Drawing.Size(322, 29);
            this.reg_tb_emergenctcontactnumber.TabIndex = 14;
            this.reg_tb_emergenctcontactnumber.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel7.Location = new System.Drawing.Point(98, 190);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(125, 26);
            this.radLabel7.TabIndex = 23;
            this.radLabel7.Text = "E-mail Address:";
            this.radLabel7.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel8.Location = new System.Drawing.Point(146, 227);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(74, 26);
            this.radLabel8.TabIndex = 24;
            this.radLabel8.Text = "Birthday:";
            this.radLabel8.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel9
            // 
            this.radLabel9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel9.Location = new System.Drawing.Point(127, 267);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(94, 26);
            this.radLabel9.TabIndex = 25;
            this.radLabel9.Text = "Nationality:";
            this.radLabel9.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel10
            // 
            this.radLabel10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel10.Location = new System.Drawing.Point(108, 318);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(106, 26);
            this.radLabel10.TabIndex = 26;
            this.radLabel10.Text = "City Address:";
            this.radLabel10.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel11
            // 
            this.radLabel11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel11.Location = new System.Drawing.Point(69, 385);
            this.radLabel11.Name = "radLabel11";
            this.radLabel11.Size = new System.Drawing.Size(150, 26);
            this.radLabel11.TabIndex = 27;
            this.radLabel11.Text = "Provincial Address:";
            this.radLabel11.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel12
            // 
            this.radLabel12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel12.Location = new System.Drawing.Point(76, 436);
            this.radLabel12.Name = "radLabel12";
            this.radLabel12.Size = new System.Drawing.Size(138, 26);
            this.radLabel12.TabIndex = 28;
            this.radLabel12.Text = "Contact Number:";
            this.radLabel12.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel13
            // 
            this.radLabel13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel13.Location = new System.Drawing.Point(3, 467);
            this.radLabel13.Name = "radLabel13";
            this.radLabel13.Size = new System.Drawing.Size(219, 48);
            this.radLabel13.TabIndex = 29;
            this.radLabel13.Text = "Name of person to contact\r\nin case of Emergency:";
            this.radLabel13.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel14
            // 
            this.radLabel14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel14.Location = new System.Drawing.Point(3, 533);
            this.radLabel14.Name = "radLabel14";
            this.radLabel14.Size = new System.Drawing.Size(223, 26);
            this.radLabel14.TabIndex = 30;
            this.radLabel14.Text = "Emergency Contact number:";
            this.radLabel14.ThemeName = "VisualStudio2012Dark";
            // 
            // reg_tb_studno
            // 
            this.reg_tb_studno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.reg_tb_studno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_tb_studno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reg_tb_studno.ForeColor = System.Drawing.Color.White;
            this.reg_tb_studno.Location = new System.Drawing.Point(227, 7);
            this.reg_tb_studno.Mask = "00\\-00000";
            this.reg_tb_studno.Name = "reg_tb_studno";
            this.reg_tb_studno.PromptChar = 'x';
            this.reg_tb_studno.Size = new System.Drawing.Size(161, 30);
            this.reg_tb_studno.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 7F);
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(274, 224);
            this.dateTimePicker1.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 25);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 637);
            this.Controls.Add(this.reg_tb_bday);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reg_tb_studno);
            this.Controls.Add(this.reg_btn_save);
            this.Controls.Add(this.reg_tb_emergencycontactname);
            this.Controls.Add(this.reg_tb_email);
            this.Controls.Add(this.radLabel14);
            this.Controls.Add(this.radLabel13);
            this.Controls.Add(this.radLabel12);
            this.Controls.Add(this.radLabel11);
            this.Controls.Add(this.radLabel10);
            this.Controls.Add(this.radLabel9);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.reg_tb_emergenctcontactnumber);
            this.Controls.Add(this.reg_tb_contactnum);
            this.Controls.Add(this.reg_tb_provaddress);
            this.Controls.Add(this.reg_tb_cityaddress);
            this.Controls.Add(this.reg_tb_nationality);
            this.Controls.Add(this.reg_tb_mname);
            this.Controls.Add(this.reg_tb_fname);
            this.Controls.Add(this.reg_tb_lname);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.reg_cb_coursesect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JPCS Membership Registration";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reg_cb_coursesect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_btn_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_lname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_fname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_mname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_bday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_nationality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_cityaddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_provaddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_contactnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_emergencycontactname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_tb_emergenctcontactnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList reg_cb_coursesect;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton reg_btn_save;
        private System.Windows.Forms.Timer timersec;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox reg_tb_lname;
        private Telerik.WinControls.UI.RadTextBox reg_tb_fname;
        private Telerik.WinControls.UI.RadTextBox reg_tb_mname;
        private Telerik.WinControls.UI.RadTextBox reg_tb_email;
        private Telerik.WinControls.UI.RadDateTimePicker reg_tb_bday;
        private Telerik.WinControls.UI.RadTextBox reg_tb_nationality;
        private Telerik.WinControls.UI.RadTextBox reg_tb_cityaddress;
        private Telerik.WinControls.UI.RadTextBox reg_tb_provaddress;
        private Telerik.WinControls.UI.RadTextBox reg_tb_contactnum;
        private Telerik.WinControls.UI.RadTextBox reg_tb_emergencycontactname;
        private Telerik.WinControls.UI.RadTextBox reg_tb_emergenctcontactnumber;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private Telerik.WinControls.UI.RadLabel radLabel11;
        private Telerik.WinControls.UI.RadLabel radLabel12;
        private Telerik.WinControls.UI.RadLabel radLabel13;
        private Telerik.WinControls.UI.RadLabel radLabel14;
        private System.Windows.Forms.MaskedTextBox reg_tb_studno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
    }
}
