using RestaurantAPI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required, DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [DataType(DataType.Currency)]
        public decimal Discount { get; set; }

        [DataType(DataType.Currency)]
        public decimal RefundAmount { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        [EnumDataType(typeof(PaymentStatus))]
        public PaymentStatus PaymentRecived { get; set; }
    }
}
