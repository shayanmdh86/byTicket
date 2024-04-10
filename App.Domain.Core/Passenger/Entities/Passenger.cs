using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Core.Passenger.Entities;
public class Passenger
{
    public int PassengerId { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public int NationalCode { get; set; }
    public int TicketId { get; set; }
    public ICollection<Ticket.Entities.Ticket> Ticket { get; set; }
}
