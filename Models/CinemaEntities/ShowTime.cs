using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab4_3.Models.CinemaEntities
{
    public class ShowTime
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Thời gian bắt buộc nhập!")]
        [Display(Name = "Giờ chiếu")]
        public string Time { get; set; }
        public ICollection<Show> Shows { get; set; }

    }
}