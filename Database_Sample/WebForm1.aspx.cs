using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText = "Delete from tblProduct where ProductId=4";
                int TotalRowsAffected = (int)cmd.ExecuteNonQuery();
                Response.Write("TotalRows Deleted =" + TotalRowsAffected.ToString() + "<br/>");

                cmd.CommandText = "Insert into tblProduct values(4, 'Calcualtor', 200, 400)";
                TotalRowsAffected = (int)cmd.ExecuteNonQuery();
                Response.Write("TotalRows Inserted =" + TotalRowsAffected.ToString() + "<br/>");

                cmd.CommandText = "Update tblProduct set Name='IPhones' where ProductId = 1";
                TotalRowsAffected = (int)cmd.ExecuteNonQuery();
                Response.Write("TotalRows Updated =" +TotalRowsAffected.ToString() + "<br/>");

            }


        }
    }
}