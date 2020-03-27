namespace avMovieManager.Model
{
    partial class PreviewPicControl
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
            this.components = new System.ComponentModel.Container();
            this.buttonPlayer = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.labelVideoSn = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javDbSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javLibrarySearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avMooSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avSoxSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javBusSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlayer
            // 
            this.buttonPlayer.BackgroundImage = global::avMovieManager.Properties.Resources.playermovie;
            this.buttonPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlayer.FlatAppearance.BorderSize = 0;
            this.buttonPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayer.Location = new System.Drawing.Point(451, 417);
            this.buttonPlayer.Name = "buttonPlayer";
            this.buttonPlayer.Size = new System.Drawing.Size(41, 37);
            this.buttonPlayer.TabIndex = 1;
            this.buttonPlayer.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(600, 404);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 0;
            this.pictureBoxCover.TabStop = false;
            // 
            // labelVideoSn
            // 
            this.labelVideoSn.AutoSize = true;
            this.labelVideoSn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVideoSn.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelVideoSn.Location = new System.Drawing.Point(208, 430);
            this.labelVideoSn.Name = "labelVideoSn";
            this.labelVideoSn.Size = new System.Drawing.Size(55, 21);
            this.labelVideoSn.TabIndex = 2;
            this.labelVideoSn.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFolderToolStripMenuItem,
            this.javDbSearchToolStripMenuItem,
            this.javLibrarySearchToolStripMenuItem,
            this.avMooSearchToolStripMenuItem,
            this.avSoxSearchToolStripMenuItem,
            this.javBusSearchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 158);
                       
            // 
            // OpenFolderToolStripMenuItem
            // 
            this.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem";
            this.OpenFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenFolderToolStripMenuItem.Text = "打开文件夹";
            this.OpenFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenFolderToolStripMenuItem_Click);
            // 
            // javDbSearchToolStripMenuItem
            // 
            this.javDbSearchToolStripMenuItem.Name = "javDbSearchToolStripMenuItem";
            this.javDbSearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.javDbSearchToolStripMenuItem.Text = "JavDb搜索(推荐)";
            this.javDbSearchToolStripMenuItem.Click += new System.EventHandler(this.javDbSearchToolStripMenuItem_Click);
            // 
            // javLibrarySearchToolStripMenuItem
            // 
            this.javLibrarySearchToolStripMenuItem.Name = "javLibrarySearchToolStripMenuItem";
            this.javLibrarySearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.javLibrarySearchToolStripMenuItem.Text = "JavLibrary搜索";
            this.javLibrarySearchToolStripMenuItem.Click += new System.EventHandler(this.javLibrarySearchToolStripMenuItem_Click);
            // 
            // avMooSearchToolStripMenuItem
            // 
            this.avMooSearchToolStripMenuItem.Name = "avMooSearchToolStripMenuItem";
            this.avMooSearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avMooSearchToolStripMenuItem.Text = "AvMoo搜索";
            this.avMooSearchToolStripMenuItem.Click += new System.EventHandler(this.avMooSearchToolStripMenuItem_Click);
            // 
            // avSoxSearchToolStripMenuItem
            // 
            this.avSoxSearchToolStripMenuItem.Name = "avSoxSearchToolStripMenuItem";
            this.avSoxSearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avSoxSearchToolStripMenuItem.Text = "AvSox搜索(无码)";
            this.avSoxSearchToolStripMenuItem.Click += new System.EventHandler(this.avSoxSearchToolStripMenuItem_Click);
            // 
            // javBusSearchToolStripMenuItem
            // 
            this.javBusSearchToolStripMenuItem.Name = "javBusSearchToolStripMenuItem";
            this.javBusSearchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.javBusSearchToolStripMenuItem.Text = "JavBus搜索";
            this.javBusSearchToolStripMenuItem.Click += new System.EventHandler(this.javBusSearchToolStripMenuItem_Click);
            // 
            // PreviewPicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.labelVideoSn);
            this.Controls.Add(this.buttonPlayer);
            this.Controls.Add(this.pictureBoxCover);
            this.Name = "PreviewPicControl";
            this.Size = new System.Drawing.Size(600, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Button buttonPlayer;
        private System.Windows.Forms.Label labelVideoSn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javDbSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javLibrarySearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avMooSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avSoxSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javBusSearchToolStripMenuItem;
    }
}
