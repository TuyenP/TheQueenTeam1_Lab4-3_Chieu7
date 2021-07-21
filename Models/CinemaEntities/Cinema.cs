using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab4_3.Models.CinemaEntities
{
    public class Cinema
    {
        public int Id { get; set; }
        [Display(Name ="Tên Rạp")]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}