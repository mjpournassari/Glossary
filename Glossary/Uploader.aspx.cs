using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Glossary
{
    public partial class Uploader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Trim()=="123@")
            {
                Button2.Visible = true;
                FileUpload1.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
            if(FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("1.xlsx"));
                Utility.excelToDb();
                Response.Redirect("/");
            }
        }
    }
}