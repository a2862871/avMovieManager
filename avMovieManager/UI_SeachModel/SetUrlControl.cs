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

namespace avMovieManager.UI_SeachModel
{
    public partial class SetUrlControl : UserControl
    {
        public SetUrlControl()
        {
            InitializeComponent();
            //ucBtnExtCheck.BackColor = HZH_Controls.GradientColors.BlueGreen[0];
            ucBtnExtCheck.BtnText = "确定";

            ucTextBoxExJavDb.InputText = AvUrlLink.JavDbUrl;
            ucTextBoxExJavBus.InputText = AvUrlLink.JavBusUrl;
            ucTextBoxExJavLib.InputText = AvUrlLink.JavLibraryUrl;
            ucTextBoxExAvMoo.InputText = AvUrlLink.AvMooUrl;
            ucTextBoxExAvSox.InputText = AvUrlLink.AvSoxUrl;
        }

        private void ucBtnExtCheck_BtnClick(object sender, EventArgs e)
        {
            AvUrlLink.JavDbUrl= ucTextBoxExJavDb.InputText ;
            AvUrlLink.JavBusUrl = ucTextBoxExJavBus.InputText;
            AvUrlLink.JavLibraryUrl = ucTextBoxExJavLib.InputText;
            AvUrlLink.AvMooUrl = ucTextBoxExAvMoo.InputText;
            AvUrlLink.AvSoxUrl= ucTextBoxExAvSox.InputText;
        }

    }
}
