using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_wf
{
    internal class Course
    {
        [Key]
        public int Crs_id { get; set; }
        public string Name{ get; set; }
        public string Duration { get; set; }

        public virtual ICollection<StudentCourse> Course_Students { get; set; } = new List<StudentCourse>();
        public virtual Exam Exam { get; set; }


        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

        public virtual ICollection<ExamHistory> ExamHistories { get; set; } = new List<ExamHistory>();



    }
}
