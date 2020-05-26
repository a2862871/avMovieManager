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
        public Form_Setting()
        {
            InitializeComponent();
        }

        private void buttonSearchTags_Click(object sender, EventArgs e)
        {
            panelSubMenu.Controls.Clear();
            panelSubMenu.Controls.Add(new SetUrlControl());
        }

        private void buttonSetLoacl_Click(object sender, EventArgs e)
        {
            panelSubMenu.Controls.Clear();
            panelSubMenu.Controls.Add(new SetLocalControl());
        }
    }
}
