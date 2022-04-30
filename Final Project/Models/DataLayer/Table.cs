using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Final_Project.Models.DataLayer
{
    public partial class Table
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string BadgeNumber { get; set; }
        [StringLength(10)]
        public string CardNumber { get; set; }
        [StringLength(10)]
        public string TimeOfDay { get; set; }
        [StringLength(10)]
        public string CurrentPhone { get; set; }
    }
}
