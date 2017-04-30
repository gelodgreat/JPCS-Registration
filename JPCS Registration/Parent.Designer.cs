namespace JPCS_Registration
{
    partial class Parent
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
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(649, 18);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            this.radMenu1.ThemeName = "VisualStudio2012Dark";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "&Member";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "&View";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "&Edit";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "radMenuItem4";
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 461);
            this.Controls.Add(this.radMenu1);
            this.IsMdiContainer = true;
            this.Name = "Parent";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parent";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
    }
}
