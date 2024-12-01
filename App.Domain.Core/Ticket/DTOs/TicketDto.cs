using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Ticket.DTOs
{
    public class TicketDto
    {
        public int TicketNumber { get; set; }
        public DateTime ByTicketTime { get; set; }
        public float Price { get; set; }
        public DateTime DateOfDeparture { get; set; }
        public int NumberOfPersons { get; set; }
        public string Destination { get; set; }
    }
}
