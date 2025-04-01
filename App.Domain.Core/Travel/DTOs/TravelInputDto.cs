using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Travel.DTOs;

public class TravelInputDto
{
   // public int TravelId { get; set; }
    public int CompanyId { get; set; }
    public Company.Entities.Company CompanyName { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime DateOfDeparture { get; set; }
    public int BusId { get; set; }
    public Bus.Entites.Bus Bus { get; set; }
}
