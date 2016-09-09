using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntroToWebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_Display.Text = "Page is loaded";
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = "Someone clicked the button";
        }
    }
}