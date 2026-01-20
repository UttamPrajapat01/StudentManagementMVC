using System.ComponentModel.DataAnnotations;

namespace StudentManagementMVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(18, 60)]
        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
