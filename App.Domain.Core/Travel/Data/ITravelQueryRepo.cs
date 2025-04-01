using App.Domain.Core.Travel.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Travel.Data;

public interface ITravelQueryRepo
{
    Task InsertServis(TravelInputDto inputDto);
}
