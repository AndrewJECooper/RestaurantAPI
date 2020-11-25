using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Enums
{
    public enum RestaurantAvailability
    {
        [Display(Name ="Bookings Available", Description ="We are available for bookings at that time.")]
        Available,

        [Display(Name ="Fully Booked", Description ="We are fully booked at that time unfortunately.")]
        FullyBooked
    }
}
