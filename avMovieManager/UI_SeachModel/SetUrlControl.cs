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

namespace avMovieManager.UI_SeachModel
{
    public partial class SetUrlControl : UserControl
    {
        public SetUrlControl()
        {
            InitializeComponent();
            //ucBtnExtCheck.BackColor = HZH_Controls.GradientColors.BlueGreen[0];
            this.Dock = DockStyle.Fill;
            ucBtnExtCheck.BtnText = "确定";

            ucTextBoxExJavDb.InputText = AvUrlLink.JavDbUrl;
            ucTextBoxExJavBus.InputText = AvUrlLink.JavBusUrl;
            ucTextBoxExJavLib.InputText = AvUrlLink.JavLibraryUrl;
            ucTextBoxExAvMoo.InputText = AvUrlLink.AvMooUrl;
            ucTextBoxExAvSox.InputText = AvUrlLink.AvSoxUrl;
        }

        private void ucBtnExtCheck_BtnClick(object sender, EventArgs e)
        {
            //AvUrlLink.JavDbUrl = IniHelper.Read("URL", "javdb", "https://javdb4.com/");
            //AvUrlLink.JavLibraryUrl = IniHelper.Read("URL", "javlibrary", "http://www.n43a.com/cn/");
            //AvUrlLink.AvMooUrl = IniHelper.Read("URL", "avmoo", "https://avmask.com/cn/");
            //AvUrlLink.AvSoxUrl = IniHelper.Read("URL", "avsox", "https://avsox.host/cn/");
            //AvUrlLink.JavBusUrl = IniHelper.Read("URL", "javbus", "https://www.seedmm.zone/");

            if (!AvUrlLink.JavDbUrl.Equals(ucTextBoxExJavDb.InputText)) 
            {
                AvUrlLink.JavDbUrl = ucTextBoxExJavDb.InputText;
                IniHelper.Write("URL", "javdb", ucTextBoxExJavDb.InputText);
            }
            if (!AvUrlLink.JavBusUrl.Equals(ucTextBoxExJavBus.InputText)) 
            {
                AvUrlLink.JavBusUrl = ucTextBoxExJavBus.InputText;
                IniHelper.Write("URL", "javbus", ucTextBoxExJavBus.InputText);
            }
            if(!AvUrlLink.JavLibraryUrl.Equals(ucTextBoxExJavLib.InputText))
            {
                AvUrlLink.JavLibraryUrl = ucTextBoxExJavLib.InputText;
                IniHelper.Write("URL", "javlibrary", ucTextBoxExJavLib.InputText);
            }
            if(!AvUrlLink.AvMooUrl.Equals(ucTextBoxExAvMoo.InputText))
            {
                AvUrlLink.AvMooUrl = ucTextBoxExAvMoo.InputText;
                IniHelper.Write("URL", "avmoo", ucTextBoxExAvMoo.InputText);
            }
            if(!AvUrlLink.AvSoxUrl.Equals(ucTextBoxExAvSox.InputText))
            {
                AvUrlLink.AvSoxUrl = ucTextBoxExAvSox.InputText;
                IniHelper.Write("URL", "avsox", ucTextBoxExAvSox.InputText);
            }
        }

    }
}
