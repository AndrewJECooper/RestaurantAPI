using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Enums
{
    public enum SpiceRating
    {
        [Display(Name ="Mild", Description ="Mild")]
        Mild = 0,

        [Display(Name ="Spicy", Description ="Spicy")]
        Spicy = 1,

        [Display(Name ="Extra Spicy", Description ="Extra Spicy")]
        ExtraSpicy = 2

    }
}
