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
        private ButtonPanelControl buttonPanelControl;
        private string currentText = "";
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

        private void iconButtonSearchActor_Click(object sender, EventArgs e)
        {
            if (IsTextBoxModificationOrIsNull())
            {
                SeachActorNames();
            }
        }
        private void iconButtonSearchVideoNo_Click(object sender, EventArgs e)
        {
            if (IsTextBoxModificationOrIsNull())
            {
                SeachMovieSn();
            }
        }
        private void textBoxSearchData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (IsTextBoxModificationOrIsNull())
                {
                    SeachActorNames();
                    SeachMovieSn();
                }
            }
        }
        private void SeachActorNames() 
        {
            List<string> actorNames = MovieDataBLL.FindFuzzyActorNames(currentText);
            if (actorNames.Count != 0)
            {
                buttonPanelControl = new ButtonPanelControl(actorNames);
                buttonPanelControl.Dock = DockStyle.Top;
                buttonPanelControl.Button_MouseDownEvent += ButtonPanelControl_Button_MouseDownEvent;
                panelButton.Controls.Add(buttonPanelControl);
            }
           
        }

        private void ButtonPanelControl_Button_MouseDownEvent(string name)
        {
            previewControl.Show(MovieDataBLL.FindActorNameToMovies(name));
            currentText = "";
        }

        private void SeachMovieSn() 
        {
            List<MovieInfo> movieDatas = MovieDataBLL.FindFuzzyMovies(currentText);
            if (movieDatas.Count != 0)
            {
                previewControl.Show(movieDatas);
            } 
        }
        private bool IsTextBoxModificationOrIsNull()
        {
            if (textBoxSearchData.Text.Length == 0)
            {
                return false;
            }
            if (textBoxSearchData.Text.Equals(currentText))
            {
                return false;
            }
            currentText = textBoxSearchData.Text;
            return true;
        }
    }
}
