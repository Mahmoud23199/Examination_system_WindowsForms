﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_wf
{
    internal class Question
    {
        [Key]
        public int Question_id { get; set; }

        public string Question_type { get; set;}
        public string Descrption { get; set;}
        public int Mark { get; set;}
        public string Model_answer { get; set; }

        public virtual StudentAnswer StudentAnswer { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }


        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }


    }
}
