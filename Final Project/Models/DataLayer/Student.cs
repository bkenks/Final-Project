using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Final_Project.Models.DataLayer
{
    public partial class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string FirstName { get; set; }
        [StringLength(10)]
        public string LastName { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }
        [StringLength(10)]
        public string Program { get; set; }
        [StringLength(10)]
        public string Year { get; set; }
    }
}
