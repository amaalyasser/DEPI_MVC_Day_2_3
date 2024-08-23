using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Task2_3.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Img { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }       
        public virtual Department Department { get; set; }


        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
