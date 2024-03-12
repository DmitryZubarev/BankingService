using GaB_BankingService.Controllers.Statistics.StatisticsRequests;
using GaB_BankingService.Controllers.Statistics.StatisticsResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GaB_BankingService.Controllers.Statistics
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : Controller
    {
        /// <summary>
        /// Получение всех сессий аренды
        /// </summary>
        [HttpGet]
        [Route("getAllSessions")]
        [ProducesResponseType(typeof(GetAllSessionsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public GetAllSessionsResponse GetAllSessions(GetAllSessionsRequest request) //старт, конец
        {
            return null;
        }

        /// <summary>
        /// Получение всех сессий аренды пользователя
        /// </summary>
        [HttpGet]
        [Route("getUserSission")]
        [ProducesResponseType(typeof(GetUserSessionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public GetUserSessionResponse GetUserSession(GetUserSessionRequest request) //user_id, start, end
        {
            return null;
        }
    }
}
