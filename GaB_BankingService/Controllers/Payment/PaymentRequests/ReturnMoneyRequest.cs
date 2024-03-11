namespace GaB_BankingService.Controllers.Payment.PaymentRequests
{
    public class ReturnMoneyRequest
    {
        public Guid UserId { get; set; }
        public decimal SumOfMoney { get; set; }
    }
}
