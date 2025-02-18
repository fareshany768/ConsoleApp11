using ConsoleApp11.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ConsoleApp11.Contextes
{
    internal class ITIdBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Student_Course> Stud_Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course_Instructor> Course_Instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= . ;Database = ITIdB ;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.Dep_Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany()
                .HasForeignKey(i => i.Dept_ID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course_Instructor>()
                .HasKey(ci => new { ci.Inst_ID, ci.Course_ID });

            modelBuilder.Entity<Course_Instructor>()
                .HasOne(ci => ci.Instructor)
                .WithMany()
                .HasForeignKey(ci => ci.Inst_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Course_Instructor>()
                .HasOne(ci => ci.Course)
                .WithMany()
                .HasForeignKey(ci => ci.Course_ID)
                .OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<Student_Course>()
                .HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

            modelBuilder.Entity<Student_Course>()
                .HasOne(sc => sc.Student)
                .WithMany()
                .HasForeignKey(sc => sc.Stud_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Student_Course>()
                .HasOne(sc => sc.Course)
                .WithMany()
                .HasForeignKey(sc => sc.Course_ID)
                .OnDelete(DeleteBehavior.Cascade);
        }

        
    }
}
