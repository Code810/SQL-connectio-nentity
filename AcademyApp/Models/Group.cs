namespace AcademyApp.Models
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public List<Student> Students { get; set; }
        public int CourseId { get; set; }
    }
}
