namespace GaB_BankingService.Controllers.Statistics.StatisticsRequests
{
    public class GetUserSessionRequest
    {
        public Guid UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
