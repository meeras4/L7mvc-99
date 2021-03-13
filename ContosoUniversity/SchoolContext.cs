
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{

    //tinfo200:[2021-03-04-<meeras4>-dykstra2] - This is the class that allows the functionality of the data model to come together.
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        //tinfo200:[2021-03-11-<meeras4>-dykstra2] - Courses, Enrollments, and Students are included in the data model 

        //tinfo200:[2021-03-11-<meeras4>-dykstra2] - Dbset properties are created for all three entities in the context
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //tinfo200:[2021-03-11-<meeras4>-dykstra2] - Code to create the model of tables with labels named exactly after the DbSet property names
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}