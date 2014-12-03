using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Glossary
{
    public partial class Db : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string q = "";
            System.IO.StreamReader sr = new System.IO.StreamReader(HttpContext.Current.Server.MapPath("1.sql"));

            q = sr.ReadToEnd();


            var sqlCommand = new SqlCommand();
            sqlCommand.CommandText = q;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = new SqlConnection("Data Source=.;Initial Catalog=glossary;Persist Security Info=True;User ID=dbuser;Password=Glossary123@");


            sqlCommand.Connection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            sqlCommand.Dispose();
        }
    }
}