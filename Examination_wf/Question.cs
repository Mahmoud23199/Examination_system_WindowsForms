using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_wf
{
    internal class Question
    {
        public int Question_id { get; set; }

        public string Question_type { get; set;}
        public string Descrption { get; set;}
        public int Mark { get; set;}
        public string Model_answer { get; set; }
    }
}
