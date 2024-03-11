using GaB_BankingService.Controllers.Statistics.StatisticsRequests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GaB_BankingService.Controllers.Statistics
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllSessions(GetAllSessionsRequest request) //старт, конец
        {
            return null;
        }

        [HttpGet]
        public IActionResult GetUserSession(GetUserSessionRequest request) //user_id, start, end
        {
            return null;
        }
    }
}
