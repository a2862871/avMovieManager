using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using avMovieManager.UI_SeachModel;
namespace avMovieManager.UI
{
    public partial class Form_Setting : Form
    {
        SetUrlControl urlControl = new SetUrlControl();
        public Form_Setting()
        {
            InitializeComponent();
        }

        private void buttonSearchTags_Click(object sender, EventArgs e)
        {
            panelSubMenu.Controls.Clear();
            urlControl.Dock = DockStyle.Fill;
            panelSubMenu.Controls.Add(urlControl);
        }
    }
}
