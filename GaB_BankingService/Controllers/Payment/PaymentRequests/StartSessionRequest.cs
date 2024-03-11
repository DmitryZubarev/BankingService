namespace GaB_BankingService.Controllers.Payment.PaymentRequests
{
    public class StartSessionRequest
    {
        public Guid UserId { get; set; }
        public decimal Price { get; set; }
        public DateTime Period { get; set; }
    }
}
