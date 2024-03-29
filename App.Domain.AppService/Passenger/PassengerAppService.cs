using App.Domain.Core.Passenger.AppService;
using App.Domain.Core.Passenger.DTOs;
using App.Domain.Core.Passenger.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Passenger
{
    public class PassengerAppService : IPassengerAppService
    {
        private readonly IPassengerService _passengerService;

        public PassengerAppService( IPassengerService passengerService)
        {
            _passengerService = passengerService;
        }
        public async Task<List<PassengerDto>> GetPassengers()
        {
            var Result= await _passengerService.GetPassengers();
            return Result;
        }
    }
}
