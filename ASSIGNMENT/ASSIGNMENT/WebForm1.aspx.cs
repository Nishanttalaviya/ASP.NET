using System;
using System.IO;
using System.Web.UI;

namespace ASSIGNMENT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = "Today is: " + DateTime.Now.ToString("D");
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = "Selected Date: " + Calendar1.SelectedDate.ToShortDateString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Label3.Text = "You entered: " + TextBox1.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            if (!string.IsNullOrEmpty(name))
            {
                Label3.Text = "Hello, " + name + "! Today's date is: " + DateTime.Now.ToString("D");
            }
            else
            {
                Label3.Text = "Please enter a name.";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    string folderPath = Server.MapPath("~/UploadedFiles/");
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    string filePath = folderPath + FileUpload1.FileName;
                    FileUpload1.SaveAs(filePath);

                    FileUploadStatus.Text = "File uploaded successfully: " + FileUpload1.FileName;
                }
                catch (Exception ex)
                {
                    FileUploadStatus.Text = "File upload failed. Error: " + ex.Message;
                }
            }
            else
            {
                FileUploadStatus.Text = "Please select a file to upload.";
            }
        }
    }
}
