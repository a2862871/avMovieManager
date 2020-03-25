namespace avMovieManager.UI
{
    partial class Form_MoviePreview
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
            this.panelChildBtnMenu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelChildBtnMenu
            // 
            this.panelChildBtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChildBtnMenu.Location = new System.Drawing.Point(0, 0);
            this.panelChildBtnMenu.Name = "panelChildBtnMenu";
            this.panelChildBtnMenu.Size = new System.Drawing.Size(140, 614);
            this.panelChildBtnMenu.TabIndex = 0;
            // 
            // Form_MoviePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1061, 614);
            this.Controls.Add(this.panelChildBtnMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_MoviePreview";
            this.Text = "Form_MoviePreview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildBtnMenu;
    }
}