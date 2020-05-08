namespace avMovieManager.UI
{
    partial class Form_SearchMovie
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
            this.iconButtonSearchVideoNo = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearchActor = new FontAwesome.Sharp.IconButton();
            this.textBoxSearchData = new System.Windows.Forms.TextBox();
            this.buttonSearchTags = new FontAwesome.Sharp.IconButton();
            this.panelShowTag = new System.Windows.Forms.Panel();
            this.panelPicSubMenu = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panelButton);
            this.panel1.Controls.Add(this.iconButtonSearchVideoNo);
            this.panel1.Controls.Add(this.iconButtonSearchActor);
            this.panel1.Controls.Add(this.textBoxSearchData);
            this.panel1.Controls.Add(this.buttonSearchTags);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 852);
            this.panel1.TabIndex = 0;
            // 
            // iconButtonSearchVideoNo
            // 
            this.iconButtonSearchVideoNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.iconButtonSearchVideoNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSearchVideoNo.FlatAppearance.BorderSize = 0;
            this.iconButtonSearchVideoNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearchVideoNo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSearchVideoNo.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonSearchVideoNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSearchVideoNo.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSearchVideoNo.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSearchVideoNo.IconSize = 30;
            this.iconButtonSearchVideoNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSearchVideoNo.Location = new System.Drawing.Point(0, 158);
            this.iconButtonSearchVideoNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonSearchVideoNo.Name = "iconButtonSearchVideoNo";
            this.iconButtonSearchVideoNo.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.iconButtonSearchVideoNo.Rotation = 0D;
            this.iconButtonSearchVideoNo.Size = new System.Drawing.Size(200, 59);
            this.iconButtonSearchVideoNo.TabIndex = 4;
            this.iconButtonSearchVideoNo.Text = "番号";
            this.iconButtonSearchVideoNo.UseVisualStyleBackColor = false;
            this.iconButtonSearchVideoNo.Click += new System.EventHandler(this.iconButtonSearchVideoNo_Click);
            // 
            // iconButtonSearchActor
            // 
            this.iconButtonSearchActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.iconButtonSearchActor.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSearchActor.FlatAppearance.BorderSize = 0;
            this.iconButtonSearchActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearchActor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSearchActor.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonSearchActor.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSearchActor.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSearchActor.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSearchActor.IconSize = 30;
            this.iconButtonSearchActor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSearchActor.Location = new System.Drawing.Point(0, 99);
            this.iconButtonSearchActor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonSearchActor.Name = "iconButtonSearchActor";
            this.iconButtonSearchActor.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.iconButtonSearchActor.Rotation = 0D;
            this.iconButtonSearchActor.Size = new System.Drawing.Size(200, 59);
            this.iconButtonSearchActor.TabIndex = 3;
            this.iconButtonSearchActor.Text = "演员";
            this.iconButtonSearchActor.UseVisualStyleBackColor = false;
            this.iconButtonSearchActor.Click += new System.EventHandler(this.iconButtonSearchActor_Click);
            // 
            // textBoxSearchData
            // 
            this.textBoxSearchData.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSearchData.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSearchData.Location = new System.Drawing.Point(0, 59);
            this.textBoxSearchData.Name = "textBoxSearchData";
            this.textBoxSearchData.Size = new System.Drawing.Size(200, 40);
            this.textBoxSearchData.TabIndex = 2;
            this.textBoxSearchData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchData_KeyDown);
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
            this.buttonSearchTags.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearchTags.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonSearchTags.IconSize = 30;
            this.buttonSearchTags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchTags.Location = new System.Drawing.Point(0, 0);
            this.buttonSearchTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchTags.Name = "buttonSearchTags";
            this.buttonSearchTags.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonSearchTags.Rotation = 0D;
            this.buttonSearchTags.Size = new System.Drawing.Size(200, 59);
            this.buttonSearchTags.TabIndex = 1;
            this.buttonSearchTags.Text = "标签搜索";
            this.buttonSearchTags.UseVisualStyleBackColor = false;
            this.buttonSearchTags.Click += new System.EventHandler(this.buttonSearchTags_Click);
            // 
            // panelShowTag
            // 
            this.panelShowTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowTag.Location = new System.Drawing.Point(200, 0);
            this.panelShowTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShowTag.Name = "panelShowTag";
            this.panelShowTag.Size = new System.Drawing.Size(1381, 250);
            this.panelShowTag.TabIndex = 1;
            // 
            // panelPicSubMenu
            // 
            this.panelPicSubMenu.AutoScroll = true;
            this.panelPicSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicSubMenu.Location = new System.Drawing.Point(200, 250);
            this.panelPicSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelPicSubMenu.Name = "panelPicSubMenu";
            this.panelPicSubMenu.Size = new System.Drawing.Size(1381, 602);
            this.panelPicSubMenu.TabIndex = 2;
            // 
            // panelButton
            // 
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Location = new System.Drawing.Point(0, 217);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(200, 635);
            this.panelButton.TabIndex = 5;
            // 
            // Form_SearchMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1581, 852);
            this.Controls.Add(this.panelPicSubMenu);
            this.Controls.Add(this.panelShowTag);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_SearchMovie";
            this.Text = "Form_SearchMovie";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonSearchTags;
        private System.Windows.Forms.Panel panelShowTag;
        private System.Windows.Forms.Panel panelPicSubMenu;
        private FontAwesome.Sharp.IconButton iconButtonSearchVideoNo;
        private FontAwesome.Sharp.IconButton iconButtonSearchActor;
        private System.Windows.Forms.TextBox textBoxSearchData;
        private System.Windows.Forms.Panel panelButton;
    }
}