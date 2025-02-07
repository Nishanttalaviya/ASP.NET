using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

namespace WebApplication1.Controllers
{
    public class studentController1 : Controller
    {
        public IActionResult Index()
        {
            objStudent = new Student();
            List<Student> lst= objStudent.getdata("");
            return View(lst);
        }
    }
}
