using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class TimeBooking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Time { get; set; }
    }
}
