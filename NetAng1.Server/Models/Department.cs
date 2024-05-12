using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
        [JsonIgnore]
        public virtual Professor? HeadProfessor { get; set; }

    }
}
