using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Task2_3.Models
{
    public class CourseResult
    {
        public int Id { get; set; }
        public int degree { get; set; }
        [ForeignKey("Course")]
        public int courseId { get; set; }   
        public virtual Course Course { get; set; }

        [ForeignKey("Traniee")]
        public int TraineeId { get; set; }
        public virtual Traniee Traniee { get; set; }
    }
}
