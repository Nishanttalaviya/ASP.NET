using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASSIGNMENT
{
    public partial class Assignment_03 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNextToView2_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                MultiView1.ActiveViewIndex = 1;
            }
        }

        protected void btnPreviousToView1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnNextToView3_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                MultiView1.ActiveViewIndex = 2;

                // Populate summary
                summaryDiv.InnerHtml = $@"
                    <p><strong>Name:</strong> {txtName.Text}</p>
                    <p><strong>Gender:</strong> {rblGender.SelectedValue}</p>
                    <p><strong>Address:</strong> {txtAddress.Text}</p>
                    <p><strong>Degree:</strong> {ddlDegree.SelectedValue}</p>
                    <p><strong>Email:</strong> {txtEmail.Text}</p>
                    <p><strong>Contact No:</strong> {txtContact.Text}</p>";
            }
        }

        protected void btnPreviousToView2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Handle submission logic (e.g., saving to a database)
            Response.Write("Registration submitted successfully!");
        }


    }
}