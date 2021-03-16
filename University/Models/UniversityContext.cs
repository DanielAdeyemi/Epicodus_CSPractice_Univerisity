using Microsoft.EntityFrameworkCore;

namespace University.Models
{
  public class UniversityContext : DbContext 
  {
    public virtual DbSet<Lesson> Lessons { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentLesson> StudentLesson { get; set; }

    public UniversityContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}