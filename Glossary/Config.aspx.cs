using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Glossary.MyDBTableAdapters;

namespace Glossary
{
    public partial class Config : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CommentsTableAdapter Ta = new CommentsTableAdapter();
            MyDB.CommentsDataTable Dt = Ta.Select_All_Comments();

            GridView1.DataSource = Dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Trim()=="123@")
            {
                Button2.Visible = true;
                FileUpload1.Visible = true;
                pnlConfig.Visible = true;
                


                string result = "";
                System.IO.StreamReader sr = new System.IO.StreamReader(HttpContext.Current.Server.MapPath("Config.json"));
                result = sr.ReadToEnd();
                sr.Close();

                BO.Config cnfg = JsonConvert.DeserializeObject<BO.Config>(result);

                TextBox2.Text = cnfg.address;
                TextBox3.Text = cnfg.email;


               
                


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