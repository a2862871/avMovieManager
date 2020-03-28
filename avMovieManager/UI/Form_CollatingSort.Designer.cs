namespace avMovieManager.UI
{
    partial class Form_CollatingSort
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
            this.dataGridViewVideo = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textSaveVideoPath = new System.Windows.Forms.TextBox();
            this.iconButtonOpenFolder = new FontAwesome.Sharp.IconButton();
            this.iconButtonStarSort = new FontAwesome.Sharp.IconButton();
            this.textBox_log = new System.Windows.Forms.RichTextBox();
            this.iconButtonRefresh = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVideo
            // 
            this.dataGridViewVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVideo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnPath});
            this.dataGridViewVideo.Location = new System.Drawing.Point(210, 76);
            this.dataGridViewVideo.Name = "dataGridViewVideo";
            this.dataGridViewVideo.RowHeadersWidth = 51;
            this.dataGridViewVideo.RowTemplate.Height = 23;
            this.dataGridViewVideo.Size = new System.Drawing.Size(672, 276);
            this.dataGridViewVideo.TabIndex = 4;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "文件名";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 150;
            // 
            // ColumnPath
            // 
            this.ColumnPath.HeaderText = "文件路径";
            this.ColumnPath.MinimumWidth = 6;
            this.ColumnPath.Name = "ColumnPath";
            this.ColumnPath.ReadOnly = true;
            this.ColumnPath.Width = 522;
            // 
            // textSaveVideoPath
            // 
            this.textSaveVideoPath.BackColor = System.Drawing.Color.White;
            this.textSaveVideoPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSaveVideoPath.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textSaveVideoPath.Location = new System.Drawing.Point(210, 30);
            this.textSaveVideoPath.Name = "textSaveVideoPath";
            this.textSaveVideoPath.ReadOnly = true;
            this.textSaveVideoPath.Size = new System.Drawing.Size(672, 27);
            this.textSaveVideoPath.TabIndex = 5;
            // 
            // iconButtonOpenFolder
            // 
            this.iconButtonOpenFolder.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonOpenFolder.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButtonOpenFolder.IconColor = System.Drawing.Color.Black;
            this.iconButtonOpenFolder.IconSize = 24;
            this.iconButtonOpenFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOpenFolder.Location = new System.Drawing.Point(895, 27);
            this.iconButtonOpenFolder.Name = "iconButtonOpenFolder";
            this.iconButtonOpenFolder.Rotation = 0D;
            this.iconButtonOpenFolder.Size = new System.Drawing.Size(97, 32);
            this.iconButtonOpenFolder.TabIndex = 6;
            this.iconButtonOpenFolder.Text = "选择文件夹";
            this.iconButtonOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonOpenFolder.UseVisualStyleBackColor = true;
            this.iconButtonOpenFolder.Click += new System.EventHandler(this.iconButtonOpenFolder_Click);
            // 
            // iconButtonStarSort
            // 
            this.iconButtonStarSort.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonStarSort.IconChar = FontAwesome.Sharp.IconChar.StackOverflow;
            this.iconButtonStarSort.IconColor = System.Drawing.Color.Black;
            this.iconButtonStarSort.IconSize = 24;
            this.iconButtonStarSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStarSort.Location = new System.Drawing.Point(895, 320);
            this.iconButtonStarSort.Name = "iconButtonStarSort";
            this.iconButtonStarSort.Rotation = 0D;
            this.iconButtonStarSort.Size = new System.Drawing.Size(97, 32);
            this.iconButtonStarSort.TabIndex = 6;
            this.iconButtonStarSort.Text = "开始整理";
            this.iconButtonStarSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonStarSort.UseVisualStyleBackColor = true;
            this.iconButtonStarSort.Click += new System.EventHandler(this.iconButtonStarSort_Click);
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(210, 358);
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(672, 269);
            this.textBox_log.TabIndex = 7;
            this.textBox_log.Text = "";
            // 
            // iconButtonRefresh
            // 
            this.iconButtonRefresh.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonRefresh.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.iconButtonRefresh.IconColor = System.Drawing.Color.Black;
            this.iconButtonRefresh.IconSize = 24;
            this.iconButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRefresh.Location = new System.Drawing.Point(895, 76);
            this.iconButtonRefresh.Name = "iconButtonRefresh";
            this.iconButtonRefresh.Rotation = 0D;
            this.iconButtonRefresh.Size = new System.Drawing.Size(97, 32);
            this.iconButtonRefresh.TabIndex = 6;
            this.iconButtonRefresh.Text = "刷新";
            this.iconButtonRefresh.UseVisualStyleBackColor = true;
            this.iconButtonRefresh.Click += new System.EventHandler(this.iconButtonRefresh_Click);
            // 
            // Form_CollatingSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1261, 636);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.iconButtonStarSort);
            this.Controls.Add(this.iconButtonRefresh);
            this.Controls.Add(this.iconButtonOpenFolder);
            this.Controls.Add(this.textSaveVideoPath);
            this.Controls.Add(this.dataGridViewVideo);
            this.Name = "Form_CollatingSort";
            this.Text = "Form_CollatingSort";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVideo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.TextBox textSaveVideoPath;
        private FontAwesome.Sharp.IconButton iconButtonOpenFolder;
        private FontAwesome.Sharp.IconButton iconButtonStarSort;
        private System.Windows.Forms.RichTextBox textBox_log;
        private FontAwesome.Sharp.IconButton iconButtonRefresh;
    }
}