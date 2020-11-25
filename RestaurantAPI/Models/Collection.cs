using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class Collection
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime OrderDateTime { get; set; } = DateTime.Now;

        public Customer CustomerInfo { get; set; }

        public TimeBooking CollectionTime { get; set; }

        public Order ColOrder { get; set; }
    }
}
