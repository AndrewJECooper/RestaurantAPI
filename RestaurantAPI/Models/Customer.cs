using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string FirstName { get; set; }

        [Required, MaxLength(255)]
        public string Surname { get; set; }

        [DataType(DataType.PhoneNumber), Phone, StringLength(11)]
        public string ContactNumber { get; set; }

        public string AddressLn1 { get; set; }

        public string AddressLn2 { get; set; }

        public string PCode { get; set; }
    }
}
