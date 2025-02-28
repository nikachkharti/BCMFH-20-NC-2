using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using University.Models.Entities;

namespace University.Repository.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ChangeDefaultTableNames();

            modelBuilder.ConfigureStudents();
            modelBuilder.ConfiugreAddresses();
            modelBuilder.ConfiugreTeachers();
            modelBuilder.ConfiugreGroups();
            modelBuilder.ConfiugreCourses();

            modelBuilder.SeedStudents();
            modelBuilder.SeedAddresses();
            modelBuilder.SeedTeachers();
            modelBuilder.SeedCourses();
            modelBuilder.SeedGroups();
            modelBuilder.SeedRoles();
            modelBuilder.SeedUsers();
            modelBuilder.SeedUserRoles();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
