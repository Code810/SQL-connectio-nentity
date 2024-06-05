using AcademyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademyApp.DAL
{
    public class AcademyDbContext : DbContext
    {
        public AcademyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
