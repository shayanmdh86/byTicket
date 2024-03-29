using App.Domain.Core.Passenger.Data;
using App.Domain.Core.Passenger.DTOs;
using App.Domain.Core.Passenger.Entities;
using App.Domain.Core.Passenger.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Passenger
{
    public class PassengerService : IPassengerService
    {
       
        private readonly IPassengerQueryRepoEf _passengeerDb;

        public PassengerService(IPassengerQueryRepoEf PassengeerDb)
        {
            _passengeerDb = PassengeerDb;
        }
        public async Task<List<PassengerDto>> GetPassengers()
        {
            var Passenger = await _passengeerDb.SelectPassengers();

            //use null in if() down
            if(Passenger.Count == 0)
            {
                throw new Exception("passenger is not fund");
            }
            return Passenger;
            
        }
    }
}
