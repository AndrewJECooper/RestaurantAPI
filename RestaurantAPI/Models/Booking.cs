using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public int NumberOfGuests { get; set; }

        [DataType(DataType.DateTime), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime BookingDateTime { get; set; } = DateTime.Now;

        public Customer CustomersInfo { get; set; }

        public TimeBooking TimeSlot { get; set; }
    }
}
