namespace MVC_Task2_3.Models
{
    public class Traniee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public string Address { get; set; }
        public string Grade { get; set; }
        public virtual ICollection<CourseResult> CourseResults { get; set; }  
    }
}
