using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? CategoryId { get; set; }

    public int? UnitPrice { get; set; }

    public string ReOrderLevel { get; set; } = null!;

    public int? SupplierId { get; set; }
}
