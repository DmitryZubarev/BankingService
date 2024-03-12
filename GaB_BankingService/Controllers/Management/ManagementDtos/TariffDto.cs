namespace GaB_BankingService.Controllers.Management.ManagementDto
{
    public class TariffDto
    {
        public Guid Id { get; set; }
        public string Product { get; set; }
        public DateTime Period { get; set; }
        public decimal Price { get; set; }
    }
}
