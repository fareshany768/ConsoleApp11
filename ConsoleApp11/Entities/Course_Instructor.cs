using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Entities
{
    internal class Course_Instructor
    {
        [Key]
        public int inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string Evaluate { get; set; }
    }
}
