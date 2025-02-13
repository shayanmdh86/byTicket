using App.Domain.Core.Travel.Entities;

public class CompanyViewDTOs
{
    public string CompanyName { get; set; }
    public string PhoneNumber { get; set; }
    public List<Travel>? Travels { get; set; }
}
