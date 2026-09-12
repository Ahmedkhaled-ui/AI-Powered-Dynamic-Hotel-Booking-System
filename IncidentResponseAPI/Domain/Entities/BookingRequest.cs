namespace IncidentResponseAPI.Domain.Entities
{
    public class BookingRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string ServiceType { get; set; } = string.Empty;
        public int NumberOfGuests { get; set; }
        public DateTime BookingDate { get; set; }
        public double OccupancyRate { get; set; }
        public string SpecialRequests { get; set; } = string.Empty;
        public decimal BasePrice { get; set; }
    }
}
