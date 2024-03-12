using System.ComponentModel.DataAnnotations;

namespace GaB_BankingService.Controllers.Management.ManagementRequests
{
    public class DeleteTariffRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
