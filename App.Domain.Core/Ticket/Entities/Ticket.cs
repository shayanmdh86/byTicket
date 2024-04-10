using App.Domain.Core.Passenger.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Ticket.Entities;

public class Ticket
{
    public int TicketId { get; set; }
    public int TicketNumber { get; set; }
    public DateTime ByTicketTime { get; set; }
    public float Price { get; set; }
    public int PassengerId { get; set; }
    public Passenger.Entities.Passenger Passenger { get; set; }
    public DateTime DateOfDeparture { get; set; }
    public int NumberOfPersons { get; set; }
    public int TravelId { get; set; }
    public Travel.Entities.Travel Travel { get; set; }



}
