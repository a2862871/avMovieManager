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
using avMovieManager.BLL;
using avMovieManager.DAL;

namespace avMovieManager.UI
{
    public partial class Form_SearchMovie : Form
    {
        private TagPanelControl TagPanel = new TagPanelControl();
        private List<PreviewPicControl> listPicBox = new List<PreviewPicControl>();
        private PreviewControl previewControl = new PreviewControl();
        public Form_SearchMovie()
        {
            InitializeComponent();            
            TagPanel.Dock = DockStyle.Top;
            TagPanel.Button_SearchTagsEvent += TagPanel_Button_SearchTagsEvent;
            panelShowTag.Controls.Add(TagPanel);
            TagPanel.LoadTagsSync();
            panelShowTag.Visible = false;
            previewControl.Dock = DockStyle.Fill;
            panelPicSubMenu.Controls.Add(previewControl);
        }

        private void TagPanel_Button_SearchTagsEvent(List<string> tags)
        {
            List<MovieInfo> movieDatas = MovieDataBLL.FindTagsToMovies(tags);
            previewControl.Show(movieDatas);
        }

        private void buttonSearchTags_Click(object sender, EventArgs e)
        {

            if (!TagPanel.IsLoadComplate()) 
            {
                MessageBox.Show("标签加载中,请稍后");
                return;
            }
            panelShowTag.Visible = true;
            //TagPanel.LoadTags();
        }

    }
}
