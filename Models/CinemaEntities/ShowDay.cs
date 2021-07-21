using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab4_3.Models.CinemaEntities
{
    public class ShowDay
    {
        public int Id { get; set; }
        [Display(Name = "Ngày chiếu")]
        public DateTime Day { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}