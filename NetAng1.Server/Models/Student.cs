﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NetAng1.Server.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required] 
        public int StudentId { get; set; }
        public double GPA { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        [JsonIgnore]
        public virtual Department Department { get; set; }
    }
}
