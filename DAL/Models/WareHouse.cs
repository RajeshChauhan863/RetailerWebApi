using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class WareHouse
{
    public int WarehouseId { get; set; }

    public string? WarehouseName { get; set; }

    public string? Location { get; set; }
}
