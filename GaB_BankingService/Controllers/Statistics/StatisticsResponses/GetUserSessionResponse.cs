using GaB_BankingService.Controllers.Statistics.StatisticsDto;
using System.Runtime.InteropServices;

namespace GaB_BankingService.Controllers.Statistics.StatisticsResponses
{
    public class GetUserSessionResponse
    {
        public List<UserSessionDto> Sessions { get; set; }
    }
}
