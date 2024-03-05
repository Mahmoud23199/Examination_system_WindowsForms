using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_wf
{
    internal class ExamDbContext:DbContext
    {
        public virtual DbSet<Student> Students{ get; set; }
        public virtual DbSet<Course>Courses{ get; set; }
        public virtual DbSet<Exam>Exams{ get; set; }
        public virtual DbSet<Instructor>Instructors{ get; set; }
        public virtual DbSet<Question>Questions{ get; set; }
        public virtual DbSet<StudentAnswer>StudentAnswers{ get; set; }
        public virtual DbSet<StudentCourse> StudentCourses{ get; set; }
        public virtual DbSet<ExamHistory> ExamHistorys { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FH5NNMR;Database=ExaminationSystem;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasIndex(s => s.userName)
                .IsUnique();
        }

    }
}
