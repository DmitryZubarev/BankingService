namespace GaB_BankingService.Controllers.Statistics.StatisticsDto
{
    public class UserSessionDto
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
