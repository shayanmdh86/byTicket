using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Bus.DTOs;

public class BusInputDto
{
    //public int BusId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int NumberOfChair { get; set; }
}
