using App.Domain.Core.Passenger.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Passenger.Service
{
    public interface IPassengerService
    {
        Task<List<PassengerDto>> GetPassengers();
    }
}
