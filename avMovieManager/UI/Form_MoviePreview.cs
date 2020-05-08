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
        private ButtonPanelControl buttonPanelControl;
        private PreviewControl previewControl = new PreviewControl();
        public Form_MoviePreview()
        {
            InitializeComponent();
            buttonPanelControl= new ButtonPanelControl(MovieDataBLL.GetActorAllNameToInitial());
            InitButton();
            previewControl.Dock = DockStyle.Fill;
            panelPicSubMenu.Controls.Add(previewControl);
        }
        private void InitButton()
        {
            buttonPanelControl.Dock = DockStyle.Left;
            buttonPanelControl.Button_MouseDownEvent += ButtonPanelControl_Button_MouseDownEvent;
            panelChildBtnMenu.Controls.Add(buttonPanelControl);
        }

        private void ButtonPanelControl_Button_MouseDownEvent(string name)
        {
            ShowActorCover(name);
        }
        private void ShowActorCover(string name)
        {
            previewControl.Show(MovieDataBLL.FindActorNameToMovies(name));
        }
    }
}
