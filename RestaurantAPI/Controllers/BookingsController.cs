using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Models;
using RestaurantAPI.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Controllers
{
    [Route("api/bookings")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingRepo _repo;

        public BookingsController(IBookingRepo repository)
        {
            _repo = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Booking>> GetAllBookings()
        {
            var bookingList = _repo.GetAllAsync();

            return Ok(bookingList);
        }

        [HttpGet("{id}")]
        public ActionResult<Booking> GetBookingById(int id)
        {
            var bookingItem = _repo.GetByIdAsync(id);

            return Ok(bookingItem);
        }
    }
}
