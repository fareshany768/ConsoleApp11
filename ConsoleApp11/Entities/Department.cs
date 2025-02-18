using System.ComponentModel.DataAnnotations;

namespace ConsoleApp11.Entities
{
    internal class Department
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public DateTime HiringDate { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Instructor>? Instructors { get; set; }
    }
}
