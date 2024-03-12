namespace GaB_BankingService.Controllers.Management.ManagementRequests
{
    public class GetTariffsRequest
    {
        public Guid Id { get; set; }
        public string Product {  get; set; }
        public DateTime Period { get; set; }
        public decimal Price { get; set; }
    }
}
