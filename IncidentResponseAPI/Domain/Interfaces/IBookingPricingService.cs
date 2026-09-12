using IncidentResponseAPI.Core.DTOs;

namespace IncidentResponseAPI.Domain.Interfaces
{
    public interface IBookingPricingService
    {
        Task<PricingResponseDto> CalculatePriceAsync(CreateBookingDto bookingRequest);
    }
}
