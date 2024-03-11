using GaB_BankingService.Controllers.Payment.PaymentRequests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GaB_BankingService.Controllers.Payment
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpPost]
        public IActionResult StartSession(StartSessionRequest request)//user_id, price, period
        {
            return null;
        }

        [HttpPut]
        public IActionResult EndSession(EndSessionRequest request)//user_id
        {
            return null;
        }

        [HttpPost]
        public IActionResult ReturnMoney(ReturnMoneyRequest request)//user_id, sum
        {
            return null;
        }
    }
}
