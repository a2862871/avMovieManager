using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using avMovieManager.Model;
namespace avMovieManager.UI
{
    public partial class Form_SearchMovie : Form
    {
        private TagPanelControl TagPanel;
        public Form_SearchMovie()
        {
            InitializeComponent();
        }

        private void buttonSearchTags_Click(object sender, EventArgs e)
        {
            TagPanel = new TagPanelControl();
            TagPanel.Width = panelShowTag.Width;
            TagPanel.Height = panelShowTag.Height;
            TagPanel.Dock = DockStyle.Top;
            panelShowTag.Controls.Add(TagPanel);
            TagPanel.LoadTags();
        }
    }
}
