using RestaurantAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [EnumDataType(typeof(SpiceRating))]
        public SpiceRating Spice { get; set; }

        [EnumDataType(typeof(Allergens))]
        public Allergens Allergen { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }

        public Order Order { get; set; }
    }
}
