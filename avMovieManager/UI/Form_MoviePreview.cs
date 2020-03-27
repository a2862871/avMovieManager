using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using avMovieManager.BLL;
using avMovieManager.DAL;
using avMovieManager.Model;
namespace avMovieManager.UI
{
    public partial class Form_MoviePreview : Form
    {
        private FullMovieDatas allMovieDatas = FullMovieDatas.Instance;
        private List<PreviewPicControl> listPicBox = new List<PreviewPicControl>();
        private ButtonPanelControl buttonPanelControl;
        public Form_MoviePreview()
        {
            InitializeComponent();
            buttonPanelControl= new ButtonPanelControl(allMovieDatas.GetActorAllNameToInitialForm());
            InitButton();
        }
        private void InitButton()
        {
            buttonPanelControl.Dock = DockStyle.Left;
            buttonPanelControl.Button_MouseDownEvent += ButtonPanelControl_Button_MouseDownEvent;
            panelChildBtnMenu.Controls.Add(buttonPanelControl);
            return;
        }

        private void ButtonPanelControl_Button_MouseDownEvent(string name)
        {
            ShowActorCover(name);
        }
        private void ShowActorCover(string name)
        {
            panelPicSubMenu.Controls.Clear();
            listPicBox.Clear();
            GC.Collect();
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString() + "  Millisecond:" + DateTime.Now.Millisecond.ToString());
            List<actorMovieData> movieDatas = allMovieDatas.GetActorNameToMoviesAllPath(name);
            for (int i = 0; i < movieDatas.Count; i++)
            {
                ShowPreviewPic(movieDatas[i], i);
            }
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString() + "  Millisecond:" + DateTime.Now.Millisecond.ToString());
            var result = Task.Run(() => LoadPicImage());
        }
        private void LoadPicImage()
        {
            for (int i = 0; i < listPicBox.Count; i++)
            {
                listPicBox[i].ShowImage();
            }
        }

        private void ShowPreviewPic(actorMovieData md, int i)
        {
            PreviewPicControl p = new PreviewPicControl(md);
            int x = 50 + i % 2 * 40 + (((i + 2) % 2) * 600);
            int y = i / 2 * (100 + 404);
            p.Tag = i;
            p.Location = new Point(x, y);
            listPicBox.Add(p);
            panelPicSubMenu.Controls.Add(p);
        }
    }
}
