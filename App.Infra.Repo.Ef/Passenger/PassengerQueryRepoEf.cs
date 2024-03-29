using App.Domain.Core.Passenger.Data;
using App.Domain.Core.Passenger.DTOs;
using App.Infra.SqlServer.Ef.Dbctx;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repo.Ef.Passenger
{
    public class PassengerQueryRepoEf : IPassengerQueryRepoEf
    {
        private readonly AppDbContext _appDbContext;

        public PassengerQueryRepoEf(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<PassengerDto>?> SelectPassengers()
        {
            return await _appDbContext.passengers.AsNoTracking().Select(
                x => new PassengerDto
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    PhoneNumber = x.PhoneNumber,
                    NationalCode = x.NationalCode,
                }).ToListAsync();

        }
    }
}
