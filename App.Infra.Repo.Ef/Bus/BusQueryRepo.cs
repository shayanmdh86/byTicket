using App.Domain.Core.Bus.Data;
using App.Domain.Core.Bus.DTOs;
using App.Domain.Core.Bus.Entites;
using App.Infra.SqlServer.Ef.Dbctx;

namespace App.Infra.Repo.Ef.BusQueryRepo;

public class BusQueryRepo : IBusQueryRepo
{
    private readonly AppDbContext _DbCtx;
    public BusQueryRepo(AppDbContext dbContext)
    {

        _DbCtx = dbContext;


    }

    public async Task<bool> InsertBuses(BusInputDto inputDto)
    {
        
        Bus bus = new Bus
        {
            BusId = 0
            ,
            Name = inputDto.Name
            ,
            Description = inputDto.Description
            ,
            NumberOfChair = inputDto.NumberOfChair
        };
        _DbCtx.Add(bus);
        _DbCtx.SaveChanges();
        return true;

    }
}
