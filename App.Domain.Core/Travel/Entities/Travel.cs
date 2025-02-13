namespace App.Domain.Core.Travel.Entities;

public class Travel
{
    public int TravelId { get; set; }
    public int CompanyId { get; set; }
    public Company.Entities.Company CompanyName { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime DateOfDeparture { get; set; }
    public int BusId { get; set; }
    public Bus.Entites.Bus Bus { get; set; }

    //This is CitiesOnTheway (Developed)
    // public ICollection<string>? CitiesOnTheway { get; set; }

}

