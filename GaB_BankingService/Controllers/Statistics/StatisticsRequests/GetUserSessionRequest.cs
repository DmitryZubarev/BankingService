using System.ComponentModel.DataAnnotations;

namespace GaB_BankingService.Controllers.Statistics.StatisticsRequests
{
    public class GetUserSessionRequest
    {
        [Required]
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
