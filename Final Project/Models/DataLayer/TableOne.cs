using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Final_Project.Models.DataLayer
{
    public partial class TableOne
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string Hobby { get; set; }
        [StringLength(10)]
        public string FavoriteBreakfast { get; set; }
        [StringLength(10)]
        public string FavoriteDay { get; set; }
        [StringLength(10)]
        public string MiddleName { get; set; }
    }
}
