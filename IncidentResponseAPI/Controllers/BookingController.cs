using IncidentResponseAPI.Core.DTOs;
using IncidentResponseAPI.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IncidentResponseAPI.Controllers
{
    public class BookingController(IBookingPricingService bookingPricingService) : Controller
    {
        [HttpPost("calculate-price")]  

        public async Task<ActionResult> calculatePrice([FromBody] CreateBookingDto bookingRequest)
        {
            if (bookingRequest== null) { return BadRequest("Booking request cannot be null."); }
            
            var pricingResponse = await bookingPricingService.CalculatePriceAsync(bookingRequest);
            return Ok(pricingResponse);
        }
            
        }

        //private readonly IBookingPricingService _bookingPricingService;
        //        public BookingController(IBookingPricingService bookingPricingService)
        //        {
        //            _bookingPricingService = bookingPricingService;
        //        }
        //        [HttpPost("api/bookings/calculate-price")]
        //        public async Task<IActionResult> CalculatePrice([FromBody] CreateBookingDto bookingRequest)
        //        {
        //            if (bookingRequest == null)
        //            {
        //                return BadRequest("Booking request cannot be null.");
        //            }
        //            var pricingResponse = await _bookingPricingService.CalculatePriceAsync(bookingRequest);
        //            return Ok(pricingResponse);
        //        }
        //    }
    }
