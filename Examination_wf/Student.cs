using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_wf
{
    internal class Student
    {
        [Key]
        public int Student_id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        [Required]
        [MaxLength(50)]
        public string userName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        public string Address { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; } = new List<StudentAnswer>();

        public virtual ICollection<ExamHistory> ExamHistories { get; set; } = new List<ExamHistory>();



    }
}
