using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Task2_3.Models;
using WebApplication1.Models;

namespace MVC_Task2_3.Controllers
{
    public class InstructorController : Controller
    {
        MyContext _context=new MyContext();
        public IActionResult Index()
        {
            var Instructors = _context.Instructors.Include(x=>x.Course).Include(x=>x.Department)
                .Include(x=>x.Course.CourseResults)
                .ThenInclude(cr => cr.Traniee).ToList();
            return View(Instructors);
        }
        public IActionResult GetInstructorbyId(int id)
        {          
            var InstructorDetails = _context.Instructors.Where(x=>x.Id==id)
                .Include(x => x.Course).Include(x => x.Department)
                .Include(x => x.Course.CourseResults)
                .ThenInclude(cr => cr.Traniee).FirstOrDefault();
            return View("InstructorDetails", InstructorDetails);
        }
    }
}
