using System.Text.Json.Serialization;

namespace IncidentResponseAPI.Core.DTOs
{
    public class CreateBookingDto
    {
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string ServiceType { get; set; } = string.Empty;
        public int NumberOfGuests { get; set; }
        public DateTime BookingDate { get; set; }
        public double OccupancyRate { get; set; }
        public string SpecialRequests { get; set; } = string.Empty;
        public decimal BasePrice { get; set; }
    }

    public class PricingResponseDto
    {
        [JsonPropertyName("customerName")]
        public string CustomerName { get; set; } = string.Empty;

        [JsonPropertyName("customerEmail")]
        public string CustomerEmail { get; set; } = string.Empty;

        [JsonPropertyName("finalPrice")]
        public decimal FinalPrice { get; set; }

        [JsonPropertyName("priceBreakdown")]
        public string PriceBreakdown { get; set; } = string.Empty;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = "USD";
    }
}