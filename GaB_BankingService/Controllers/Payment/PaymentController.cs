using GaB_BankingService.Controllers.Payment.PaymentRequests;
using GaB_BankingService.Controllers.Payment.PaymentResponses;
using GaB_BankingService.Controllers.Refund.RefundRequests;
using GaB_BankingService.Controllers.Refund.RefundResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GaB_BankingService.Controllers.Payment
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        /// <summary>
        /// Начать аренду
        /// </summary>
        [HttpPost]
        [Route("startSession")]
        [ProducesResponseType(typeof(StartSessionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public StartSessionResponse StartSession(StartSessionRequest request)//user_id, price, period
        {
            return null;
        }

        /// <summary>
        /// Закончить аренду
        /// </summary>
        [HttpPut]
        [Route("endSession")]
        [ProducesResponseType(typeof(EndSessionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public EndSessionResponse EndSession(EndSessionRequest request)//user_id
        {
            return null;
        }

        
    }
}
