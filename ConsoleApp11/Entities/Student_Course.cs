using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp11.Entities
{
    internal class Student_Course
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Student")]
        public int Stud_ID { get; set; }

        [ForeignKey("Course")]
        public int Course_ID { get; set; }

        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100.")]
        public double Grade { get; set; }

        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
