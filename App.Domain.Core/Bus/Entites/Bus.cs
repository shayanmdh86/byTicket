﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Bus.Entites;

public class Bus
{
    public int BusId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int NumberOfChair { get; set; }
}
