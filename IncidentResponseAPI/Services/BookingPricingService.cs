using IncidentResponseAPI.Core.DTOs;
using IncidentResponseAPI.Domain.Interfaces;
using System.Text;
using System.Text.Json;

namespace IncidentResponseAPI.Services
{
    public class BookingPricingService(HttpClient httpClient, IConfiguration configuration) : IBookingPricingService
    {
        

        public async Task<PricingResponseDto> CalculatePriceAsync(CreateBookingDto bookingDto)
        {


            if(bookingDto == null)
            {
                throw new ArgumentNullException(nameof(bookingDto));
            }


            var webhookUrl = configuration["N8nBookingWebhookUrl"];
            if (string.IsNullOrEmpty(webhookUrl))
            {
                throw new InvalidOperationException("N8n Booking Webhook URL is not configured.");
            }

            var jsonContent = new StringContent(
                JsonSerializer.Serialize(bookingDto),
                Encoding.UTF8,
                "application/json"
            );

            var response = await httpClient.PostAsync(webhookUrl, jsonContent);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var responseJson = await response.Content.ReadAsStringAsync();
            var pricingResult = JsonSerializer.Deserialize<PricingResponseDto>(responseJson, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return pricingResult!;
        }
    }
}