using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseCRUDSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Initial Catalog=sample;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select * from cSharp", con);
            con.Open();
            //cmd.Parameters.AddWithValue("@name",textBox4.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //comboBox1.Items.Add(dr["id"].ToString());
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();

            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Initial Catalog=sample;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Select * from cSharp where id =" + Convert.ToInt32(textBox4.Text) + "", con);
            con.Open();
            //cmd.Parameters.AddWithValue("@name", textBox4.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //comboBox1.Items.Add(dr["id"].ToString());
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Initial Catalog=sample;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("insert into csharp(id,name,address) values(@id,@name,@address)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox3.Text);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Record is inserted");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Initial Catalog=sample;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Update csharp set id=@id, name=@name, address=@address where id =" + Convert.ToInt32(textBox4.Text) + "", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox3.Text);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Record is Updated");
            }
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Initial Catalog=sample;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("Delete from csharp where id =" + Convert.ToInt32(textBox4.Text) + "", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox3.Text);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Record is Deleted");
            }
            con.Close();

        }
       // private void button1_Click(object sender, EventArgs e)
        //{
            //insert -update -delete (ExecuteNonQuery) it returns number of rows efected.
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QFE7L0M;Initial Catalog=Training;Integrated Security=True");
            //string str = "insert into chsrap values ('" + textBox1.Text + "', " + Convert.ToInt32(textBox2.Text) + ", '" + textBox3.Text + "')";
            //SqlCommand cmdd = new SqlCommand(str, con);
            //SqlCommand cmd = new SqlCommand("insert into chsrap values ('" + textBox1.Text + "', " + Convert.ToInt32(textBox2.Text) + ", '" + textBox3.Text + "')", con);
            // SqlCommand cmd = new SqlCommand("insert into chsrap(name,id,address) values (@name,@id,@address)", con);
            //con.Open();
            //cmd.Parameters.AddWithValue("@name", textBox1.Text);
            //cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox2.Text));
            //cmd.Parameters.AddWithValue("@address", textBox3.Text);

            //int i = cmd.ExecuteNonQuery();
            //if(i>0)
            //{
            //    MessageBox.Show("Record is inderted");
            //}
            // con.Close();
            //data adapter , datareader //open and close ->output dataset temory
        //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QFE7L0M;Initial Catalog=Training;Integrated Security=True");
        //    SqlDataAdapter da = new SqlDataAdapter("select * from chsrap", con);
        //    SqlCommandBuilder blr = new SqlCommandBuilder(da);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds, "chsrap");
        //    DataRow dr = ds.Tables["chsrap"].NewRow();
        //    dr["name"] = textBox1.Text;
        //    dr["id"] = Convert.ToInt32(textBox2.Text);
        //    dr["address"] = textBox3.Text;
        //    ds.Tables["chsrap"].Rows.Add(dr);
        //    int i = da.Update(ds, "chsrap");
        //    if (i > 0)
        //    {
        //        MessageBox.Show("Record is inserted");
        //    }


        //}

    }
}
