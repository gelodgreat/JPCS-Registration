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
            this.reg_cb_coursesect = new Telerik.WinControls.UI.RadDropDownList();
            this.reg_name = new System.Windows.Forms.TextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.reg_tb_studno = new System.Windows.Forms.TextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.reg_address = new System.Windows.Forms.TextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.reg_cn = new System.Windows.Forms.TextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.reg_btn_save = new Telerik.WinControls.UI.RadButton();
            this.reg_btn_secnotfound = new Telerik.WinControls.UI.RadButton();
            this.timersec = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reg_cb_coursesect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_btn_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_btn_secnotfound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_cb_coursesect
            // 
            this.reg_cb_coursesect.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.reg_cb_coursesect.Location = new System.Drawing.Point(123, 120);
            this.reg_cb_coursesect.Name = "reg_cb_coursesect";
            this.reg_cb_coursesect.Size = new System.Drawing.Size(301, 20);
            this.reg_cb_coursesect.TabIndex = 3;
            // 
            // reg_name
            // 
            this.reg_name.Location = new System.Drawing.Point(123, 94);
            this.reg_name.Name = "reg_name";
            this.reg_name.Size = new System.Drawing.Size(301, 20);
            this.reg_name.TabIndex = 2;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(59, 70);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(58, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Student #:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(58, 96);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(59, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Full Name:";
            // 
            // reg_tb_studno
            // 
            this.reg_tb_studno.Location = new System.Drawing.Point(123, 68);
            this.reg_tb_studno.Name = "reg_tb_studno";
            this.reg_tb_studno.Size = new System.Drawing.Size(122, 20);
            this.reg_tb_studno.TabIndex = 1;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 122);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(105, 18);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "Course and Section:";
            // 
            // reg_address
            // 
            this.reg_address.Location = new System.Drawing.Point(123, 178);
            this.reg_address.Multiline = true;
            this.reg_address.Name = "reg_address";
            this.reg_address.Size = new System.Drawing.Size(301, 47);
            this.reg_address.TabIndex = 4;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(68, 178);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(49, 18);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "Address:";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(60, 233);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(57, 18);
            this.radLabel5.TabIndex = 7;
            this.radLabel5.Text = "Contact #:";
            // 
            // reg_cn
            // 
            this.reg_cn.Location = new System.Drawing.Point(123, 231);
            this.reg_cn.MaxLength = 11;
            this.reg_cn.Name = "reg_cn";
            this.reg_cn.Size = new System.Drawing.Size(301, 20);
            this.reg_cn.TabIndex = 5;
            this.reg_cn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reg_cn_KeyPress);
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.radLabel6.Location = new System.Drawing.Point(123, 22);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(191, 33);
            this.radLabel6.TabIndex = 8;
            this.radLabel6.Text = "JPCS Registration";
            // 
            // reg_btn_save
            // 
            this.reg_btn_save.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.reg_btn_save.Location = new System.Drawing.Point(314, 257);
            this.reg_btn_save.Name = "reg_btn_save";
            this.reg_btn_save.Size = new System.Drawing.Size(110, 58);
            this.reg_btn_save.TabIndex = 7;
            this.reg_btn_save.Text = "Register";
            this.reg_btn_save.Click += new System.EventHandler(this.reg_btn_save_Click);
            // 
            // reg_btn_secnotfound
            // 
            this.reg_btn_secnotfound.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.reg_btn_secnotfound.Location = new System.Drawing.Point(123, 146);
            this.reg_btn_secnotfound.Name = "reg_btn_secnotfound";
            this.reg_btn_secnotfound.Size = new System.Drawing.Size(110, 26);
            this.reg_btn_secnotfound.TabIndex = 6;
            this.reg_btn_secnotfound.Text = "Section Not Found?";
            this.reg_btn_secnotfound.Click += new System.EventHandler(this.reg_btn_secnotfound_Click);
            // 
            // timersec
            // 
            this.timersec.Enabled = true;
            this.timersec.Tick += new System.EventHandler(this.timersec_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 326);
            this.Controls.Add(this.reg_btn_secnotfound);
            this.Controls.Add(this.reg_btn_save);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.reg_cn);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.reg_address);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.reg_tb_studno);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.reg_name);
            this.Controls.Add(this.reg_cb_coursesect);
            this.Name = "Main";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reg_cb_coursesect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_btn_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reg_btn_secnotfound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList reg_cb_coursesect;
        private System.Windows.Forms.TextBox reg_name;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.TextBox reg_tb_studno;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.TextBox reg_address;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.TextBox reg_cn;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadButton reg_btn_save;
        private Telerik.WinControls.UI.RadButton reg_btn_secnotfound;
        private System.Windows.Forms.Timer timersec;
    }
}
