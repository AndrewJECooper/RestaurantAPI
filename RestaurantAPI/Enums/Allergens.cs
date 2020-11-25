using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Enums
{
    public enum Allergens
    {
        [Display(Name ="Celery", Description ="Not suitable for people with Celery allergies")]
        Celery = 0,

        [Display(Name ="Gluten", Description ="Not suitable for people with Gluten allergies")]
        Gluten = 1,

        [Display(Name ="Crustaceans", Description ="Not suitable for people with allergic to Shell Fish")]
        Crustaceans = 2,

        [Display(Name ="Eggs", Description ="Not suitable for people with Egg allergies")]
        Egg = 3,

        [Display(Name ="Fish", Description ="Not suitable for people with Fish allergies")]
        Fish = 4,

        [Display(Name ="Lupin", Description ="Not suitable for people allergic to Lupin")]
        Lupin = 5,

        [Display(Name ="Milk", Description ="Not suitable for people with Milk alergies")]
        Milk = 6,

        [Display(Name ="Molluscs", Description ="Not suitable for people allergic to Molluscs")]
        Molluscs = 7,

        [Display(Name = "Mustard", Description = "Not suitable for people with Mustard allergies")]
        Mustard = 8,

        [Display(Name = "Nuts", Description = "Not suitable for people with Nut allergies")]
        Nuts = 9,

        [Display(Name = "Peanuts", Description = "Not suitable for people with Peanut allergies")]
        Peanuts = 10,

        [Display(Name = "Sesame Seeds", Description = "Not suitable for people allergic to Sesame Seeds")]
        SesameSeed = 11,

        [Display(Name = "Soya", Description = "Not suitable for people allergic to Soya")]
        Soya = 12,

        [Display(Name = "Sulpher Dioxide", Description = "Not suitable for people allergic to Sulphites")]
        SulpherDioxide = 13

    }
}
