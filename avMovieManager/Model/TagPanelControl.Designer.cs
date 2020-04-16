namespace avMovieManager.Model
{
    partial class TagPanelControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTag = new System.Windows.Forms.Panel();
            this.panelSelectLabel = new System.Windows.Forms.Panel();
            this.buttonSearchTags = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // panelTag
            // 
            this.panelTag.AutoScroll = true;
            this.panelTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTag.Location = new System.Drawing.Point(0, 0);
            this.panelTag.Margin = new System.Windows.Forms.Padding(2);
            this.panelTag.Name = "panelTag";
            this.panelTag.Size = new System.Drawing.Size(1036, 160);
            this.panelTag.TabIndex = 3;
            // 
            // panelSelectLabel
            // 
            this.panelSelectLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSelectLabel.Location = new System.Drawing.Point(0, 160);
            this.panelSelectLabel.Name = "panelSelectLabel";
            this.panelSelectLabel.Size = new System.Drawing.Size(911, 42);
            this.panelSelectLabel.TabIndex = 4;
            // 
            // buttonSearchTags
            // 
            this.buttonSearchTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchTags.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSearchTags.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearchTags.IconColor = System.Drawing.Color.Black;
            this.buttonSearchTags.IconSize = 16;
            this.buttonSearchTags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchTags.Location = new System.Drawing.Point(935, 169);
            this.buttonSearchTags.Name = "buttonSearchTags";
            this.buttonSearchTags.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSearchTags.Rotation = 0D;
            this.buttonSearchTags.Size = new System.Drawing.Size(87, 25);
            this.buttonSearchTags.TabIndex = 3;
            this.buttonSearchTags.Text = "搜索";
            this.buttonSearchTags.UseVisualStyleBackColor = true;
            this.buttonSearchTags.Click += new System.EventHandler(this.buttonSearchTags_Click);
            // 
            // TagPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.buttonSearchTags);
            this.Controls.Add(this.panelSelectLabel);
            this.Controls.Add(this.panelTag);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TagPanelControl";
            this.Size = new System.Drawing.Size(1036, 202);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTag;
        private System.Windows.Forms.Panel panelSelectLabel;
        private FontAwesome.Sharp.IconButton buttonSearchTags;
    }
}
