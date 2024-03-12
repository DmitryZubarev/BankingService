namespace GaB_BankingService.Controllers.Management.ManagementRequests
{
    public class CreateTariffRequest
    {
        public string Product {  get; set; }
        public DateTime Period { get; set; }
        public decimal Price { get; set; }
    }
}
