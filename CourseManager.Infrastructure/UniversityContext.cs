using Microsoft.EntityFrameworkCore;
using CourseManager.Core.Models;

namespace CourseManager.Infrastructure
{

    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {}
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}
