using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp11.Entities
{
    internal class Course
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Duration { get; set; }

        [ForeignKey("Topic")]
        public int Top_ID { get; set; }

        public Topic? Topic { get; set; }
        public ICollection<Student_Course>? Students { get; set; }
        public ICollection<Course_Instructor>? Instructors { get; set; }
    }
}
