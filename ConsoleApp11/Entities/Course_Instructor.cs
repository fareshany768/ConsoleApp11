using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp11.Entities
{
    internal class Course_Instructor
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Instructor")]
        public int Inst_ID { get; set; }

        [ForeignKey("Course")]
        public int Course_ID { get; set; }

        public string Evaluate { get; set; } = string.Empty;

        public Instructor? Instructor { get; set; }
        public Course? Course { get; set; }
    }
}
