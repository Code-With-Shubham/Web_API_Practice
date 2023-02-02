using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_Web_API_CORE.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = "";
        public string ContactNumber { get; set; }
            
        public int Age { get; set;}
    }
    
}
