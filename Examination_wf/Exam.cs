﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_wf
{
    internal class Exam
    {
        public int Exam_Id { get; set; }
        public string Duration { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
