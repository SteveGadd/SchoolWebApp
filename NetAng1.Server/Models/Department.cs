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
        public string Name { get; set; }

        public int? HeadOfDepartmentID { get; set; }
        [ForeignKey("HeadOfDepartmentId")]
        public Professor Professor { get; set; }
    }
}
