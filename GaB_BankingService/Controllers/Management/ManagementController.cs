using GaB_BankingService.Controllers.Management.ManagementRequests;
using GaB_BankingService.Controllers.Management.ManagementResponses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GaB_BankingService.Controllers.Management
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagementController : ControllerBase
    {
        /// <summary>
        /// Получение списка тарифов
        /// </summary>
        [HttpGet]
        [Route("getTariffs")]
        [ProducesResponseType(typeof(GetTariffsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public GetTariffsResponse GetTariffs(GetTariffsRequest request)
        {
            return null;
        }

        /// <summary>
        /// Создание тарифа
        /// </summary>
        [HttpPost]
        [Route("createTariff")]
        [ProducesResponseType(typeof(CreateTariffResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public CreateTariffResponse CreateTariff(CreateTariffRequest request)
        {
            return null;
        }

        /// <summary>
        /// Изменение тарифа
        /// </summary>
        [HttpPut]
        [Route("updateTariff")]
        [ProducesResponseType(typeof(UpdateTariffResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public UpdateTariffResponse UpdateTariff(UpdateTariffRequest request)
        {
            return null;
        }

        /// <summary>
        /// Удаление тарифа
        /// </summary>
        [HttpDelete]
        [Route("deleteTariff")]
        [ProducesResponseType(typeof(DeleteTariffResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public DeleteTariffResponse DeleteTariff(DeleteTariffRequest request)
        {
            return null;
        }
    }
}
