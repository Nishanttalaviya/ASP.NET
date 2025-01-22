using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP.NET
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtSem_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ASP.NET\\ASP.NET\\App_Data\\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand ("insert into register values",'" + txtName.Text"','" +txtSem.Text"','" + txtBranch.Text"','"+txtEmail.Text"', '"+txtPassword.Text"','" +txtConfirmPassword.Text"',");
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}