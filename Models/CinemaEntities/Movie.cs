using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab4_3.Models.CinemaEntities
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Tên Phim")]
        public string Name { get; set; }

        public double Price { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}