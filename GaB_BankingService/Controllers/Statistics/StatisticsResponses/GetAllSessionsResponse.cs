using GaB_BankingService.Controllers.Statistics.StatisticsDto;

namespace GaB_BankingService.Controllers.Statistics.StatisticsResponses
{
    public class GetAllSessionsResponse
    {
        public List<UserSessionDto> Sessions { get; set; }
    }
}
