using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using avMovieManager.DAL;
using avMovieManager.BLL;

namespace avMovieManager.Model
{
    public partial class ButtonPanelControl : UserControl
    {
        private Button currentbtn = null;
        public delegate void ButtonMouseDown(string name);
        public event ButtonMouseDown Button_MouseDownEvent;
        public ButtonPanelControl(Dictionary<string, List<string>> filedict)
        {
            InitializeComponent();
            InitButton(filedict);

        }
        private void InitButton(Dictionary<string, List<string>> filedict)
        {
            for(char ch = ']'; ch>= 'A'; ch--) 
            {
                Panel p = new Panel();
                if(ch == '[') 
                {
                    ch = '#';
                }
                if (!filedict.ContainsKey(ch.ToString())) 
                {
                    if (ch == '#')
                        ch = '[';
                    continue;
                }
                List<string> filelist = filedict[ch.ToString()];
                p.Size = new Size(150, filelist.Count*50);
                p.Dock = DockStyle.Top;
                Font font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                Label lb = new Label();
                lb.Location = new Point(0, 15);
                lb.Size = new Size(20, 20);
                lb.Text = ch.ToString();
                lb.Font = font;
                lb.ForeColor = Color.Gainsboro;
                p.Controls.Add(lb);
                for (int i = 0; i < filelist.Count; i++) 
                {
                    //System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString() + "  Millisecond:" + DateTime.Now.Millisecond.ToString());
                    //System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString() + "  Millisecond:" + DateTime.Now.Millisecond.ToString());
                    Button b = new Button();
                    //b.Dock = System.Windows.Forms.DockStyle.Top;
                    b.Font = font;                
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    b.ForeColor = System.Drawing.Color.Gainsboro;
                    b.Location = new System.Drawing.Point(20, i*50);
                    b.Name = "btn_" + i.ToString();
                    b.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
                    b.Size = new System.Drawing.Size(this.Size.Width-20, 50);
                    b.TabIndex = i;
                    b.Text = filelist[i];
                    b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    b.UseVisualStyleBackColor = true;
                    b.MouseClick += Button_MouseClick;
                    b.BringToFront();
                    p.Controls.Add(b);
                }
                this.Controls.Add(p);
                if (ch == '#')
                    ch = '[';
            }
        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentbtn != null)
            {
                if (currentbtn == (Button)sender)
                    return;
                currentbtn.BackColor = Color.FromArgb(34, 33, 74);
            }
            currentbtn = (Button)sender;
            currentbtn.BackColor = RGBColors.color5;
            Button_MouseDownEvent(currentbtn.Text);
        }
    }
}
