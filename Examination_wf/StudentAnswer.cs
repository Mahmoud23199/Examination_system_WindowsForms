using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_wf
{
    internal class StudentAnswer
    {
        [Key]
        public int Answer_id{ get; set; }
        public string Answer { get; set;}

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }


    }
}
