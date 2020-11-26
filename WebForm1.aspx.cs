using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PhoneBookApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=DESKTOP-TNA6SLN\\SQLEXPRESS;Initial Catalog=PhoneBookDB;Integrated Security=True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtPhoneNum.Text == "" || txtAddress.Text == "")
            {
                Label1.Text = "Please Enter valid data";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {

            dt = new DataTable();
            cmd.CommandText = "INSERT INTO tbIphoneBook (Name,PhoneNum,Address) " +
                "values('" + txtName.Text.ToString() + "','" + txtPhoneNum.Text.ToString() + "',' "+txtAddress.Text.ToString()+" ')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
            Label1.Text = "Data successfully added!";
            Label1.ForeColor = System.Drawing.Color.Green;

            }
        }
        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT * FROM tbIphoneBook";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update tbIphoneBook set PhoneNum " +
                "= ' " + txtPhoneNum.Text.ToString() + " ',Address = '" +txtAddress.Text.ToString()+ "' " +
                "WHERE Name = '" +txtName.Text.ToString()+ "' ";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            
            DataShow();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "DELETE from tbIphoneBook WHERE NAME = '"+txtName.Text.ToString()+"' ";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            DataShow();

        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        public void ClearData()
        {
            txtName.Text = "";
            txtPhoneNum.Text = "";
            txtAddress.Text = "";
        }
    }
}