using avMovieManager.DAL;

namespace avMovieManager.UI_SeachModel
{
    partial class SetLocalControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelVideoPath = new System.Windows.Forms.Label();
            this.labelWaitClassify = new System.Windows.Forms.Label();
            this.labelClassifyOut = new System.Windows.Forms.Label();
            this.ucSwitch1 = new HZH_Controls.Controls.UCSwitch();
            this.label9 = new System.Windows.Forms.Label();
            this.ucBtnPlayer = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnVideoPath = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnWaitClassify = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExtv = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(58, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "播放软件位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(58, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "分类输出路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(58, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "影片存放路径";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(58, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "待分类路径";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPlayer.ForeColor = System.Drawing.Color.Gray;
            this.labelPlayer.Location = new System.Drawing.Point(58, 72);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(161, 27);
            this.labelPlayer.TabIndex = 4;
            this.labelPlayer.Text = "C:\\poptplay.exe";
            // 
            // labelVideoPath
            // 
            this.labelVideoPath.AutoSize = true;
            this.labelVideoPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVideoPath.ForeColor = System.Drawing.Color.Gray;
            this.labelVideoPath.Location = new System.Drawing.Point(58, 143);
            this.labelVideoPath.Name = "labelVideoPath";
            this.labelVideoPath.Size = new System.Drawing.Size(161, 27);
            this.labelVideoPath.TabIndex = 5;
            this.labelVideoPath.Text = "C:\\poptplay.exe";
            // 
            // labelWaitClassify
            // 
            this.labelWaitClassify.AutoSize = true;
            this.labelWaitClassify.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWaitClassify.ForeColor = System.Drawing.Color.Gray;
            this.labelWaitClassify.Location = new System.Drawing.Point(58, 212);
            this.labelWaitClassify.Name = "labelWaitClassify";
            this.labelWaitClassify.Size = new System.Drawing.Size(161, 27);
            this.labelWaitClassify.TabIndex = 6;
            this.labelWaitClassify.Text = "C:\\poptplay.exe";
            // 
            // labelClassifyOut
            // 
            this.labelClassifyOut.AutoSize = true;
            this.labelClassifyOut.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelClassifyOut.ForeColor = System.Drawing.Color.Gray;
            this.labelClassifyOut.Location = new System.Drawing.Point(58, 280);
            this.labelClassifyOut.Name = "labelClassifyOut";
            this.labelClassifyOut.Size = new System.Drawing.Size(161, 27);
            this.labelClassifyOut.TabIndex = 7;
            this.labelClassifyOut.Text = "C:\\poptplay.exe";
            // 
            // ucSwitch1
            // 
            this.ucSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.ucSwitch1.Checked = LocalPathParam.PicIsLoadALL;
            this.ucSwitch1.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucSwitch1.FalseTextColr = System.Drawing.Color.White;
            this.ucSwitch1.Location = new System.Drawing.Point(692, 351);
            this.ucSwitch1.Name = "ucSwitch1";
            this.ucSwitch1.Size = new System.Drawing.Size(83, 31);
            this.ucSwitch1.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucSwitch1.TabIndex = 8;
            this.ucSwitch1.Texts = null;
            this.ucSwitch1.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.ucSwitch1.TrueTextColr = System.Drawing.Color.White;
            this.ucSwitch1.CheckedChanged += new System.EventHandler(this.ucSwitch1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(58, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(588, 27);
            this.label9.TabIndex = 9;
            this.label9.Text = "启动时是否加载全部图片(提高加载速度，但会导致内存占用巨大)";
            // 
            // ucBtnPlayer
            // 
            this.ucBtnPlayer.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnPlayer.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnPlayer.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnPlayer.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.ucBtnPlayer.BtnText = "更改";
            this.ucBtnPlayer.ConerRadius = 25;
            this.ucBtnPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnPlayer.EnabledMouseEffect = true;
            this.ucBtnPlayer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.ucBtnPlayer.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnPlayer.IsRadius = true;
            this.ucBtnPlayer.IsShowRect = true;
            this.ucBtnPlayer.IsShowTips = false;
            this.ucBtnPlayer.Location = new System.Drawing.Point(692, 39);
            this.ucBtnPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnPlayer.Name = "ucBtnPlayer";
            this.ucBtnPlayer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.ucBtnPlayer.RectWidth = 1;
            this.ucBtnPlayer.Size = new System.Drawing.Size(76, 38);
            this.ucBtnPlayer.TabIndex = 10;
            this.ucBtnPlayer.TabStop = false;
            this.ucBtnPlayer.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(7)))), ((int)(((byte)(132)))));
            this.ucBtnPlayer.TipsText = "";
            this.ucBtnPlayer.BtnClick += new System.EventHandler(this.ucBtnPlayer_BtnClick);
            // 
            // ucBtnVideoPath
            // 
            this.ucBtnVideoPath.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnVideoPath.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnVideoPath.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnVideoPath.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.ucBtnVideoPath.BtnText = "更改";
            this.ucBtnVideoPath.ConerRadius = 25;
            this.ucBtnVideoPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnVideoPath.EnabledMouseEffect = true;
            this.ucBtnVideoPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.ucBtnVideoPath.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnVideoPath.IsRadius = true;
            this.ucBtnVideoPath.IsShowRect = true;
            this.ucBtnVideoPath.IsShowTips = false;
            this.ucBtnVideoPath.Location = new System.Drawing.Point(692, 111);
            this.ucBtnVideoPath.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnVideoPath.Name = "ucBtnVideoPath";
            this.ucBtnVideoPath.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.ucBtnVideoPath.RectWidth = 1;
            this.ucBtnVideoPath.Size = new System.Drawing.Size(76, 38);
            this.ucBtnVideoPath.TabIndex = 11;
            this.ucBtnVideoPath.TabStop = false;
            this.ucBtnVideoPath.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(7)))), ((int)(((byte)(132)))));
            this.ucBtnVideoPath.TipsText = "";
            this.ucBtnVideoPath.BtnClick += new System.EventHandler(this.ucBtnVideoPath_BtnClick);
            // 
            // ucBtnWaitClassify
            // 
            this.ucBtnWaitClassify.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnWaitClassify.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnWaitClassify.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnWaitClassify.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.ucBtnWaitClassify.BtnText = "更改";
            this.ucBtnWaitClassify.ConerRadius = 25;
            this.ucBtnWaitClassify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnWaitClassify.EnabledMouseEffect = true;
            this.ucBtnWaitClassify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.ucBtnWaitClassify.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnWaitClassify.IsRadius = true;
            this.ucBtnWaitClassify.IsShowRect = true;
            this.ucBtnWaitClassify.IsShowTips = false;
            this.ucBtnWaitClassify.Location = new System.Drawing.Point(692, 179);
            this.ucBtnWaitClassify.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnWaitClassify.Name = "ucBtnWaitClassify";
            this.ucBtnWaitClassify.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.ucBtnWaitClassify.RectWidth = 1;
            this.ucBtnWaitClassify.Size = new System.Drawing.Size(76, 38);
            this.ucBtnWaitClassify.TabIndex = 12;
            this.ucBtnWaitClassify.TabStop = false;
            this.ucBtnWaitClassify.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(7)))), ((int)(((byte)(132)))));
            this.ucBtnWaitClassify.TipsText = "";
            this.ucBtnWaitClassify.BtnClick += new System.EventHandler(this.ucBtnWaitClassify_BtnClick);
            // 
            // ucBtnExtv
            // 
            this.ucBtnExtv.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnExtv.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnExtv.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExtv.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.ucBtnExtv.BtnText = "更改";
            this.ucBtnExtv.ConerRadius = 25;
            this.ucBtnExtv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExtv.EnabledMouseEffect = true;
            this.ucBtnExtv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.ucBtnExtv.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExtv.IsRadius = true;
            this.ucBtnExtv.IsShowRect = true;
            this.ucBtnExtv.IsShowTips = false;
            this.ucBtnExtv.Location = new System.Drawing.Point(692, 252);
            this.ucBtnExtv.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExtv.Name = "ucBtnExtv";
            this.ucBtnExtv.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(111)))), ((int)(((byte)(148)))));
            this.ucBtnExtv.RectWidth = 1;
            this.ucBtnExtv.Size = new System.Drawing.Size(76, 38);
            this.ucBtnExtv.TabIndex = 12;
            this.ucBtnExtv.TabStop = false;
            this.ucBtnExtv.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(7)))), ((int)(((byte)(132)))));
            this.ucBtnExtv.TipsText = "";
            this.ucBtnExtv.BtnClick += new System.EventHandler(this.ucBtnExtClassifyOut_BtnClick);
            // 
            // SetLocalControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.ucBtnExtv);
            this.Controls.Add(this.ucBtnWaitClassify);
            this.Controls.Add(this.ucBtnVideoPath);
            this.Controls.Add(this.ucBtnPlayer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ucSwitch1);
            this.Controls.Add(this.labelClassifyOut);
            this.Controls.Add(this.labelWaitClassify);
            this.Controls.Add(this.labelVideoPath);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetLocalControl";
            this.Size = new System.Drawing.Size(960, 586);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelVideoPath;
        private System.Windows.Forms.Label labelWaitClassify;
        private System.Windows.Forms.Label labelClassifyOut;
        private HZH_Controls.Controls.UCSwitch ucSwitch1;
        private System.Windows.Forms.Label label9;
        private HZH_Controls.Controls.UCBtnExt ucBtnPlayer;
        private HZH_Controls.Controls.UCBtnExt ucBtnVideoPath;
        private HZH_Controls.Controls.UCBtnExt ucBtnWaitClassify;
        private HZH_Controls.Controls.UCBtnExt ucBtnExtv;
    }
}
