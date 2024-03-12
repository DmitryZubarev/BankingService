using System.ComponentModel.DataAnnotations;

namespace GaB_BankingService.Controllers.Payment.PaymentRequests
{
    public class StartSessionRequest
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime Period { get; set; }
    }
}
