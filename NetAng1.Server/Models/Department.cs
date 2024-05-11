using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetAng1.Server.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int DepartmentId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string Location {  get; set; }

        public int? HeadProfessorId { get; set; }
        [ForeignKey("HeadProfessorId")]
        public Professor? HeadProfessor { get; set; }
        public virtual List<Student> Students { get; set; }

    }
}
