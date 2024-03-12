namespace GaB_BankingService.Controllers.Payment.PaymentDto
{
    public class StartSessionDto
    {
        public Guid UserId { get; set; }
        public decimal Price { get; set; }
        public DateTime Period { get; set; }
        public string Status { get; set; }
    }
}
