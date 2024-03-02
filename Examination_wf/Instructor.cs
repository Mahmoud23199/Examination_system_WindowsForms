using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_wf
{
    internal class Instructor
    {
        public int Instructor_id { get; set; }

        [Required]
        public string userName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
