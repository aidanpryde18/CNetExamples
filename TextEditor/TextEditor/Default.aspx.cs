using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextEditor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btn_SingleLine_Click(object sender, EventArgs e)
        {
            txt_Editor.TextMode = TextBoxMode.SingleLine;
            txt_Editor.MaxLength = 5;

            String myText = txt_Editor.Text;

            if(myText.Length > 5)
            {
                ViewState["originalText"] = myText;

                txt_Editor.Text = myText.Substring(0, 5);
            }
        }

        protected void btn_MultiLine_Click(object sender, EventArgs e)
        {
            txt_Editor.TextMode = TextBoxMode.MultiLine;

            txt_Editor.Columns = 50;
            txt_Editor.Rows = 10;

            txt_Editor.Wrap = true;

            if (ViewState["originalText"] != null)
            {
                string originalText = ViewState["originalText"].ToString();
                txt_Editor.Text = originalText;
            }
        }

        protected void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Editor.Text = "";
        }

        protected void chk_Enable_CheckedChanged(object sender, EventArgs e)
        {
            txt_Editor.Enabled = chk_Enable.Checked;
        }

        protected void btn_Replace_Click(object sender, EventArgs e)
        {
            string content = txt_Editor.Text;
            string find = txt_Find.Text;
            string replace = txt_Replace.Text;

            txt_Editor.Text = content.Replace(find, replace);
        }

        protected void txt_Color_TextChanged(object sender, EventArgs e)
        {
            string textcolor = txt_Color.Text;

            txt_Editor.ForeColor = System.Drawing.Color.FromName(textcolor);
        }

        protected void txt_BackColor_TextChanged(object sender, EventArgs e)
        {
            string backcolor = txt_BackColor.Text;

            txt_Editor.BackColor = System.Drawing.Color.FromName(backcolor);
        }
    }
}