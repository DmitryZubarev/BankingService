using System.ComponentModel.DataAnnotations;

namespace GaB_BankingService.Controllers.Payment.PaymentRequests
{
    public class EndSessionRequest
    {
        [Required]
        public Guid UserId { get; set; }
    }
}
