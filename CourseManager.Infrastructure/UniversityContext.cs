using Microsoft.EntityFrameworkCore;
using CourseManager.Models;

namespace CourseManager.Infrastructure;

public class UniversityContext : DbContext
{
    public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
    {
        
    }
}
