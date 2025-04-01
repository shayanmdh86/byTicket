using App.Domain.Core.Travel.Data;
using App.Domain.Core.Travel.DTOs;
using App.Infra.SqlServer.Ef.Dbctx;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repo.Ef.Travel;

public class TravelQueryRepo : ITravelQueryRepo
{
    private readonly AppDbContext _dbContext;
    public TravelQueryRepo(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task InsertServis(TravelInputDto inputDto)
    {
        var TId = await _dbContext.Travels.MaxAsync(x => (int?)x.TravelId) ?? 0;
        int newTravelId = TId + 1;
        var SelectBus = _dbContext.Buses.FirstOrDefault(x => x.BusId == inputDto.BusId);
        var SelectCom = _dbContext.Companies.FirstOrDefault(x=>x.CompanyId == inputDto.CompanyId);
        if (TId == null)
        {
            throw new Exception("NULL");
        }
        App.Domain.Core.Travel.Entities.Travel travel = new Domain.Core.Travel.Entities.Travel
        {
                 TravelId= newTravelId,
                 BusId=SelectBus.BusId,
                 Bus=inputDto.Bus,
                 CompanyId=19,
                 CompanyName=SelectCom,
                 DateOfDeparture=inputDto.DateOfDeparture,
                 Destination = inputDto.Destination

        };


    }
}