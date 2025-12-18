using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CourseManager.Core.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; } = string.Empty;
        
        [Required]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;

        public List<Student> Students { get; set; } = new();
    }
}
