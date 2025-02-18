using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp11.Entities
{
    internal class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; } = string.Empty;
        public decimal HourRate { get; set; }

        [ForeignKey("Department")]
        public int Dept_ID { get; set; }

        public Department? Department { get; set; }
        public ICollection<Course_Instructor>? Courses { get; set; }
    }
}
