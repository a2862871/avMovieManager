namespace avMovieManager.UI
{
    partial class Form_Main
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonSetting = new FontAwesome.Sharp.IconButton();
            this.iconButtonTidy = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.iconButtonMovies = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCurrentChildFrom = new System.Windows.Forms.Label();
            this.iconCurrentChildFrom = new FontAwesome.Sharp.IconButton();
            this.panelShashow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButtonSetting);
            this.panelMenu.Controls.Add(this.iconButtonTidy);
            this.panelMenu.Controls.Add(this.iconButtonSearch);
            this.panelMenu.Controls.Add(this.iconButtonMovies);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 697);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonSetting
            // 
            this.iconButtonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSetting.FlatAppearance.BorderSize = 0;
            this.iconButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSetting.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButtonSetting.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSetting.IconSize = 40;
            this.iconButtonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSetting.Location = new System.Drawing.Point(0, 401);
            this.iconButtonSetting.Name = "iconButtonSetting";
            this.iconButtonSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonSetting.Rotation = 0D;
            this.iconButtonSetting.Size = new System.Drawing.Size(200, 60);
            this.iconButtonSetting.TabIndex = 4;
            this.iconButtonSetting.Text = "设置";
            this.iconButtonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSetting.UseVisualStyleBackColor = true;
            this.iconButtonSetting.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButtonTidy
            // 
            this.iconButtonTidy.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonTidy.FlatAppearance.BorderSize = 0;
            this.iconButtonTidy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTidy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonTidy.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonTidy.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonTidy.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.iconButtonTidy.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonTidy.IconSize = 40;
            this.iconButtonTidy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTidy.Location = new System.Drawing.Point(0, 341);
            this.iconButtonTidy.Name = "iconButtonTidy";
            this.iconButtonTidy.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonTidy.Rotation = 0D;
            this.iconButtonTidy.Size = new System.Drawing.Size(200, 60);
            this.iconButtonTidy.TabIndex = 3;
            this.iconButtonTidy.Text = "整理归档";
            this.iconButtonTidy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTidy.UseVisualStyleBackColor = true;
            this.iconButtonTidy.Click += new System.EventHandler(this.IconButtonTidy_Click);
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSearch.FlatAppearance.BorderSize = 0;
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSearch.IconSize = 40;
            this.iconButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSearch.Location = new System.Drawing.Point(0, 281);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonSearch.Rotation = 0D;
            this.iconButtonSearch.Size = new System.Drawing.Size(200, 60);
            this.iconButtonSearch.TabIndex = 2;
            this.iconButtonSearch.Text = "搜索";
            this.iconButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            this.iconButtonSearch.Click += new System.EventHandler(this.IconButtonSearch_Click);
            // 
            // iconButtonMovies
            // 
            this.iconButtonMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMovies.FlatAppearance.BorderSize = 0;
            this.iconButtonMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMovies.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMovies.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonMovies.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMovies.IconChar = FontAwesome.Sharp.IconChar.MediumM;
            this.iconButtonMovies.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMovies.IconSize = 40;
            this.iconButtonMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMovies.Location = new System.Drawing.Point(0, 221);
            this.iconButtonMovies.Name = "iconButtonMovies";
            this.iconButtonMovies.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMovies.Rotation = 0D;
            this.iconButtonMovies.Size = new System.Drawing.Size(200, 60);
            this.iconButtonMovies.TabIndex = 1;
            this.iconButtonMovies.Text = "影片预览";
            this.iconButtonMovies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMovies.UseVisualStyleBackColor = true;
            this.iconButtonMovies.Click += new System.EventHandler(this.iconButtonMovies_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 221);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(10, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(180, 160);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.buttonMinimize);
            this.panelTitleBar.Controls.Add(this.buttonMaximize);
            this.panelTitleBar.Controls.Add(this.buttonExit);
            this.panelTitleBar.Controls.Add(this.labelCurrentChildFrom);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildFrom);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1035, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(936, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(28, 16);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
            this.buttonMaximize.Location = new System.Drawing.Point(970, 3);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(28, 16);
            this.buttonMaximize.TabIndex = 2;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(1004, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(28, 16);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCurrentChildFrom
            // 
            this.labelCurrentChildFrom.AutoSize = true;
            this.labelCurrentChildFrom.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCurrentChildFrom.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCurrentChildFrom.Location = new System.Drawing.Point(64, 26);
            this.labelCurrentChildFrom.Name = "labelCurrentChildFrom";
            this.labelCurrentChildFrom.Size = new System.Drawing.Size(50, 26);
            this.labelCurrentChildFrom.TabIndex = 1;
            this.labelCurrentChildFrom.Text = "主页";
            // 
            // iconCurrentChildFrom
            // 
            this.iconCurrentChildFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildFrom.FlatAppearance.BorderSize = 0;
            this.iconCurrentChildFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCurrentChildFrom.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconCurrentChildFrom.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildFrom.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildFrom.IconSize = 40;
            this.iconCurrentChildFrom.Location = new System.Drawing.Point(21, 20);
            this.iconCurrentChildFrom.Name = "iconCurrentChildFrom";
            this.iconCurrentChildFrom.Rotation = 0D;
            this.iconCurrentChildFrom.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildFrom.TabIndex = 0;
            this.iconCurrentChildFrom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconCurrentChildFrom.UseVisualStyleBackColor = false;
            // 
            // panelShashow
            // 
            this.panelShashow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShashow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShashow.Location = new System.Drawing.Point(200, 75);
            this.panelShashow.Name = "panelShashow";
            this.panelShashow.Size = new System.Drawing.Size(1035, 9);
            this.panelShashow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1035, 613);
            this.panelDesktop.TabIndex = 3;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 697);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShashow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonMovies;
        private FontAwesome.Sharp.IconButton iconButtonSetting;
        private FontAwesome.Sharp.IconButton iconButtonTidy;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton iconCurrentChildFrom;
        private System.Windows.Forms.Label labelCurrentChildFrom;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelShashow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

