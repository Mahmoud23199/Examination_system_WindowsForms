using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_wf
{
    internal class StudentCourse
    {
        [Key]
        public int StudentCourseId { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

    }
}
