using Microsoft.EntityFrameworkCore;
using StudentInformationProject.Database.Configuration;
using StudentInformationProject.Models.DomainModels;

namespace StudentInformationProject.Database
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
        }
    }
}
