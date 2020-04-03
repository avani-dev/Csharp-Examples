using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class StudentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GetDataFromDB()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            string strSelectQuery = "Select * from tblStudent";
            SqlDataAdapter da = new SqlDataAdapter(strSelectQuery, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Students");

            ds.Tables["Students"].PrimaryKey = new DataColumn[] { ds.Tables["Students"].Columns["ID"] };
            Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);

            StudentGridView.DataSource = ds;
            StudentGridView.DataBind();

            lblMessage.Text = "Data loaded from Database";
        }

        private void GetDataFromCache()
        {
            if(Cache["DATASET"] != null)
                {
                DataSet ds = (DataSet)Cache["DATASET"];
                StudentGridView.DataSource = ds;
                StudentGridView.DataBind();
            }
        }
        protected void BtnGetDataFromDB_Click(object sender, EventArgs e)
        {
            GetDataFromDB();
        }

        protected void StudentGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
           StudentGridView.EditIndex = e.NewEditIndex;
            GetDataFromCache();
        }

        protected void StudentGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if(Cache["DATASET"] != null)
            {
                DataSet ds = (DataSet)Cache["DATASET"];
                DataRow dr = ds.Tables["Students"].Rows.Find(e.Keys["Id"]);
                dr["FirstName"] = e.NewValues["FirstName"];
                dr["LastName"] = e.NewValues["LastName"];
                dr["Gender"] = e.NewValues["Gender"];
                dr["TotalMarks"] = e.NewValues["TotalMarks"];
               
             Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);
                StudentGridView.EditIndex = -1;
                GetDataFromCache();

            }
        }

        protected void StudentGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            StudentGridView.EditIndex = -1;
            GetDataFromCache();
        }

        protected void StudentGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Cache["DATASET"] != null)
            {
                DataSet ds = (DataSet)Cache["DATASET"];
                DataRow dr = ds.Tables["Students"].Rows.Find(e.Keys["Id"]);
                dr.Delete();

                Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);
                GetDataFromCache();

            }

        }

        protected void BtnUpdateDB_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            string strSelectQuery = "Select * from tblStudent";
            SqlDataAdapter da = new SqlDataAdapter(strSelectQuery, con);

            DataSet ds = (DataSet)Cache["DATASET"];

           // ds.Update(ds, "Students");
        }
    }
}