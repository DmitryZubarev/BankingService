using System.ComponentModel.DataAnnotations;

namespace GaB_BankingService.Controllers.Management.ManagementRequests
{
    public class CreateTariffRequest
    {
        [Required]
        public string Product {  get; set; }

        [Required]
        public DateTime Period { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
