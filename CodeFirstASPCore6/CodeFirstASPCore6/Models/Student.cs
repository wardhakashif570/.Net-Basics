using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstASPCore6.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string StudentName { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string StudentGender { get; set; }

        public int Age { get; set; }
        public int Standard { get; set; }
    }
}
