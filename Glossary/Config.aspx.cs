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
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Trim()=="123@")
            {
                LinkButton1_Click(null, null);
                LinkButton1.Visible = true;
                LinkButton2.Visible = true;
                LinkButton3.Visible = true;
                LinkButton4.Visible = true;

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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            pnlUpload.Visible = true;
            pnlLogin.Visible = false;
            pnlConfig.Visible = false;
            pnlComments.Visible = false;

            string result = "";
            System.IO.StreamReader sr = new System.IO.StreamReader(HttpContext.Current.Server.MapPath("Config.json"));
            result = sr.ReadToEnd();
            sr.Close();

            BO.Config cnfg = JsonConvert.DeserializeObject<BO.Config>(result);

            txtAddress.Text = cnfg.address;
            txtEmail.Text = cnfg.email;
            txtFax.Text = cnfg.fax;
            txtTel.Text = cnfg.tell;
            txtText.Text = cnfg.text;
            txtUrl.Text = cnfg.url;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            pnlUpload.Visible = false;
            pnlLogin.Visible = false;
            pnlConfig.Visible = true;
            pnlComments.Visible = false;
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            pnlUpload.Visible = false;
            pnlLogin.Visible = false;
            pnlConfig.Visible = false;
            pnlComments.Visible = true;

            CommentsTableAdapter Ta = new CommentsTableAdapter();
            MyDB.CommentsDataTable Dt = Ta.Select_All_Comments();

            GridView1.DataSource = Dt;
            GridView1.DataBind();
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            pnlUpload.Visible = false;
            pnlLogin.Visible = true;
            pnlConfig.Visible = false;
            pnlComments.Visible = false;

            LinkButton1.Visible = false;
            LinkButton2.Visible = false;
            LinkButton3.Visible = false;
            LinkButton4.Visible = false;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "DeleteContent")
            {
                CommentsTableAdapter Ta = new CommentsTableAdapter();
                Ta.Delete_CommnadById(int.Parse(e.CommandArgument.ToString()));

                MyDB.CommentsDataTable Dt = Ta.Select_All_Comments();

                GridView1.DataSource = Dt;
                GridView1.DataBind();

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            BO.Config cnfg = new BO.Config();
            cnfg.address = txtAddress.Text;
            cnfg.email = txtEmail.Text;
            cnfg.fax = txtFax.Text;
            cnfg.tell = txtTel.Text;
            cnfg.text = txtText.Text;
            cnfg.url = txtUrl.Text;



            System.IO.StreamWriter wr = new System.IO.StreamWriter(HttpContext.Current.Server.MapPath("Config.json"));
            wr.Write(JsonConvert.SerializeObject(cnfg));
            wr.Close();

            string result = "";
            System.IO.StreamReader sr = new System.IO.StreamReader(HttpContext.Current.Server.MapPath("Config.json"));
            result = sr.ReadToEnd();
            sr.Close();

            cnfg = JsonConvert.DeserializeObject<BO.Config>(result);

            txtAddress.Text = cnfg.address;
            txtEmail.Text = cnfg.email;
            txtFax.Text = cnfg.fax;
            txtTel.Text = cnfg.tell;
            txtText.Text = cnfg.text;
            txtUrl.Text = cnfg.url;
        }
    }
}