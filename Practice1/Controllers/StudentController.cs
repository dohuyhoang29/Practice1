using Practice1.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Practice1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var student1 = new Student(1, "Student1", "10", "Math", 10);
            var student2 = new Student(2, "Student2", "10", "History", 8);
            var student3 = new Student(3, "Student3", "10", "English", 7);

            List<Student> list = new List<Student>();

            list.Add(student1);
            list.Add(student2);
            list.Add(student3);

            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public void Delete()
        {

        }

    }
}