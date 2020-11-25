using RestaurantAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        [EnumDataType(typeof(Allergens))]
        public Allergens AllergyInfo { get; set; }

        public OrderItem Item { get; set; }
   
    }
}
