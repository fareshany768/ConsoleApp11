using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp11.Entities
{
    internal class Student
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string FName { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string LName { get; set; } = string.Empty;

        [Required, MaxLength(200)]
        public string Address { get; set; } = string.Empty;

        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dep_Id { get; set; }

        public Department? Department { get; set; }

        public ICollection<Student_Course>? Courses { get; set; }
    }
}
