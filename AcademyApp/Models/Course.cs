namespace AcademyApp.Models
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Group> Groups { get; set; }
    }
}
