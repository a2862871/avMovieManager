﻿namespace avMovieManager.UI
{
    partial class Form_Setting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearchTags = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.buttonSearchTags);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 591);
            this.panel1.TabIndex = 0;
            // 
            // buttonSearchTags
            // 
            this.buttonSearchTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.buttonSearchTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSearchTags.FlatAppearance.BorderSize = 0;
            this.buttonSearchTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchTags.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSearchTags.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearchTags.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSearchTags.IconChar = FontAwesome.Sharp.IconChar.Audible;
            this.buttonSearchTags.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonSearchTags.IconSize = 30;
            this.buttonSearchTags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchTags.Location = new System.Drawing.Point(0, 0);
            this.buttonSearchTags.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchTags.Name = "buttonSearchTags";
            this.buttonSearchTags.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSearchTags.Rotation = 0D;
            this.buttonSearchTags.Size = new System.Drawing.Size(157, 53);
            this.buttonSearchTags.TabIndex = 2;
            this.buttonSearchTags.Text = "地址设置";
            this.buttonSearchTags.UseVisualStyleBackColor = false;
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1045, 591);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Setting";
            this.Text = "Form_Setting";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonSearchTags;
    }
}