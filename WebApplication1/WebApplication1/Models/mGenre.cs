using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class mGenre
    {
        public int ID { get; set; }

        [StringLength(30, MinimumLength = 1), Required]
        [Display(Name = "ジャンル")]
        public string Genre { get; set; }
    }

}