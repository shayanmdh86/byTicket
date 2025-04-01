using App.Domain.Core.Bus.DTOs;
using App.Domain.Core.Bus.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Bus.Data;

public interface IBusQueryRepo
{
    //CRUD
    Task<bool> InsertBuses(BusInputDto inputDto);
}
