using System.ComponentModel.DataAnnotations;

namespace ConsoleApp11.Entities
{
    internal class Topic
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Course>? Courses { get; set; }
    }
}
