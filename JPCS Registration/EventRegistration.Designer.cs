namespace JPCS_Registration
{
    partial class EventRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventRegistration));
            this.btnRegister = new Telerik.WinControls.UI.RadButton();
            this.mtbStudNum = new System.Windows.Forms.MaskedTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lblEventName = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEventName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRegister.Location = new System.Drawing.Point(234, 373);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(134, 39);
            this.btnRegister.TabIndex = 43;
            this.btnRegister.Text = "Register";
            this.btnRegister.ThemeName = "VisualStudio2012Dark";
            // 
            // mtbStudNum
            // 
            this.mtbStudNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.mtbStudNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbStudNum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtbStudNum.ForeColor = System.Drawing.Color.White;
            this.mtbStudNum.Location = new System.Drawing.Point(280, 261);
            this.mtbStudNum.Mask = "00\\-00000";
            this.mtbStudNum.Name = "mtbStudNum";
            this.mtbStudNum.PromptChar = 'x';
            this.mtbStudNum.Size = new System.Drawing.Size(114, 34);
            this.mtbStudNum.TabIndex = 41;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(173, 261);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(103, 31);
            this.radLabel1.TabIndex = 42;
            this.radLabel1.Text = "Student #:";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // lblEventName
            // 
            this.lblEventName.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblEventName.Location = new System.Drawing.Point(192, 80);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(224, 51);
            this.lblEventName.TabIndex = 40;
            this.lblEventName.Text = "lblEventName";
            this.lblEventName.ThemeName = "VisualStudio2012Dark";
            // 
            // EventRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 536);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.mtbStudNum);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.lblEventName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventRegistration";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventRegistration";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.btnRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEventName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnRegister;
        private System.Windows.Forms.MaskedTextBox mtbStudNum;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel lblEventName;
    }
}
