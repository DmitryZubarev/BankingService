using System.ComponentModel.DataAnnotations;

namespace GaB_BankingService.Controllers.Refund.RefundRequests
{
    public class ReturnMoneyRequest
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public decimal SumOfMoney { get; set; }
    }
}
