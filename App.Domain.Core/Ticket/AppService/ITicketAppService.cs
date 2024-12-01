using App.Domain.Core.Ticket.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Ticket.AppService
{
    public interface ITicketAppService
    {
        Task<Ticket.Entities.Ticket> ByTicket();
    }
}
