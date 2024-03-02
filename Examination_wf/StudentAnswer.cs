using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_wf
{
    internal class StudentAnswer
    {
        public int Answer_id{ get; set; }
        public string Answer { get; set;}

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }


        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }


    }
}
