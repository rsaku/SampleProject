using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    // 映画
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60,MinimumLength=1),Required]
        [Display(Name="タイトル")]
        public string Title { get; set; }

        [Display(Name = "監督")]
        public string Director { get; set; }

        [Display(Name = "リリース日")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "ジャンル")]
        public string Genre { get; set; }

        [Display(Name = "価格")]
        [DataType(DataType.Currency)]
        [Range(1,999999,ErrorMessage="{0}は{1}～{2}の間で入力してください。")]
        public decimal Price { get; set; }
    }

    public class MovieDBContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}