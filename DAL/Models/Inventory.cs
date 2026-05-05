using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Inventory
{
    public int InventoryId { get; set; }

    public int? ProductId { get; set; }

    public int? WarehouseId { get; set; }

    public int? QuantityInStock { get; set; }

    public int? LastUpdated { get; set; }
}
