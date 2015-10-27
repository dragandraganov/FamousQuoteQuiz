using FamousQuoteQuiz.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FamousQuoteQuiz.Web.WebForms
{
    public partial class Settings : BasePage
    {
        protected override void Page_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.BinaryMode)
            {
                binary_mode.Checked = true;
            }
            else
            {
                multichoice_mode.Checked = true;
            }
            
        }

        [WebMethod]
        public static void ChangeMode(bool isBinaryMode)
        {
            GlobalVariables.BinaryMode = isBinaryMode;
        }
    }
}