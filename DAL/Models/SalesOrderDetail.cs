using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SalesOrderDetail
{
    public int SalesOrderDetailsId { get; set; }

    public int? SalesOrderId { get; set; }

    public int? ProductId { get; set; }

    public decimal? QuantitySold { get; set; }

    public decimal? UnitPrice { get; set; }
}
