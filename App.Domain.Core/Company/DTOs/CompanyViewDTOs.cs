namespace App.Domain.Core.Company.Entities
{
    public class CompanyViewDTOs 
    {
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Travel.Entities.Travel>? Travels { get; set; }
    }
}
