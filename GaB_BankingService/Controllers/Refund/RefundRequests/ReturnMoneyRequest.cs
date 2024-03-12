namespace GaB_BankingService.Controllers.Refund.RefundRequests
{
    public class ReturnMoneyRequest
    {
        public Guid UserId { get; set; }
        public decimal SumOfMoney { get; set; }
    }
}
