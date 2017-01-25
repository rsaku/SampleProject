using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    // 映画
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name="リリース日")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }

    public class MovieDBContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}