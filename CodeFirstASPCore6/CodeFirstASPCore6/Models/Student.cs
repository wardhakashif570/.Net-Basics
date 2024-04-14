using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstASPCore6.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string StudentName { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string StudentGender { get; set; }

        [Required]
        public int? Age { get; set; }
        [Required]
        public int? Standard { get; set; }
    }
}
