using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        StudentMock studentMock = new StudentMock();
        public IActionResult Index()
        {
            var students=studentMock.GetStudents();
            return View(students);
        }
        public IActionResult GetProductbyId(int id)
        {
            StudentMock studentMock = new StudentMock();
            var student = studentMock.GetStudentbyId(id);
            return View("StudentDetails",student);
        }

        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Submit(string name, string address)
        {
            var students = studentMock.GetStudents();
            students.Add(new Student() { Id = 4, Name = name, Address = address, Img = "" });
       
            return View ("Index", students);
        }
    }

}

