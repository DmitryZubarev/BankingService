using GaB_BankingService.Controllers.Management.ManagementDto;

namespace GaB_BankingService.Controllers.Management.ManagementResponses
{
    public class GetTariffsResponse
    {
        public List<TariffDto> Tariffs { get; set; }
    }
}
