﻿
using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
        {

        }

        public StudentSystemContext(DbContextOptions options)
            :base()
        {

        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual  DbSet<Resource> Resources { get; set; }

        public virtual DbSet<Homework> HomeworkSubmissions { get; set; }

        public virtual DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.CONECTION_STRING);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(x => x.Name)
                .IsUnicode(true);

            modelBuilder.Entity<Student>()
                .Property(x => x.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(x => x.Name)
                .IsUnicode(true);

            modelBuilder.Entity<Course>()
               .Property(x => x.Description)
               .IsUnicode(true);

            modelBuilder.Entity<Resource>()
                .Property(x => x.Name)
                .IsUnicode(true);

            modelBuilder.Entity<Resource>()
                .Property(x => x.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Homework>()
                .Property(x => x.Content)
                .IsUnicode(false);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(x => new { x.CourseId, x.StudentId });

        }
    }
}
