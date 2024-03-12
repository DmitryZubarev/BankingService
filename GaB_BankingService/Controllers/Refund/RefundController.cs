using GaB_BankingService.Controllers.Refund.RefundRequests;
using GaB_BankingService.Controllers.Refund.RefundResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GaB_BankingService.Controllers.Refund
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefundController : ControllerBase
    {
        /// <summary>
        /// Вернуть деньги
        /// </summary>
        [HttpPost]
        [Route("returnMoney")]
        [ProducesResponseType(typeof(ReturnMoneyResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ReturnMoneyResponse ReturnMoney(ReturnMoneyRequest request)//user_id, sum
        {
            return null;
        }
    }
}
