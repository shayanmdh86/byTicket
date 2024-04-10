using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Company.Entities;

public class Company
{
    public int CompanyId { get; set; } 
    public string CompanyName { get; set; } 
    public string PhoneNumber{ get; set;}
    public int TravelId { get; set; }
    public List<Travel.Entities.Travel>? Travels { get; set; }
}
