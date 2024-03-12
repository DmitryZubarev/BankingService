namespace GaB_BankingService.Controllers.Payment.PaymentDto
{
    public class EndSessionDto
    {
        public Guid UserId { get; set; }
        public decimal Price { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status {  get; set; }
    }
}
