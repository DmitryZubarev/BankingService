using System.ComponentModel.DataAnnotations;

namespace GaB_BankingService.Controllers.Management.ManagementRequests
{
    public class UpdateTariffRequest
    {
        [Required]
        public Guid Id { get; set; }
        public string Product { get; set; }
        public DateTime Period { get; set; }
        public decimal Price { get; set; }
    }
}
