using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(15)]
        public int MobileNo { get; set; }

        [StringLength(50)]
        public string Branch { get; set; }

        public int? Sem { get; set; }

        [StringLength(50)]
        public string Result { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        public bool insert(Student student)
        {
            if (student.Name != string.Empty && student.Address != string.Empty && student.MobileNo != string.Empty && student.Branch != string.Empty && student.Sem != string.Empty && student.Result != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO student(Name, Address, MobileNo, Branch, Sem, Result) VALUES(@Name, @Address, @MobileNo, @Branch, @Sem, @Result)");
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                cmd.Parameters.AddWithValue("@MobileNo", student.MobileNo);
                cmd.Parameters.AddWithValue("@Branch", student.Branch);
                cmd.Parameters.AddWithValue("@Sem", student.Sem);
                cmd.Parameters.AddWithValue("@Result", student.Result);
                con.Open();
                int i = cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }
            }
            return false;

        }
        public bool update(Student emp)
        {
            if (student.Name != string.Empty && student.Address != string.Empty && student.MobileNo != string.Empty && student.Branch != string.Empty && student.Sem != string.Empty && student.Result != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("UPDATE student SET Name = @Name, Address = @Address, MobileNo = @MobileNo, Branch = @Branch, Sem = @Sem, Result = @Result WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                cmd.Parameters.AddWithValue("@MobileNo", student.MobileNo);
                cmd.Parameters.AddWithValue("@Branch", student.Branch);
                cmd.Parameters.AddWithValue("@Sem", student.Sem);
                cmd.Parameters.AddWithValue("@Result", student.Result);
                cmd.Parameters.AddWithValue("@Id", student.Id);
                con.Open();
                int i = cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }
            }
            return false;

        }
        public bool delete(Student emp)
    }
}
