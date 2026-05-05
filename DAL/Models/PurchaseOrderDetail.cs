using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PurchaseOrderDetail
{
    public int PurchaseOrderDetailId { get; set; }

    public int? PurchaseOrderId { get; set; }

    public int? ProductId { get; set; }

    public decimal? QuantityOrdered { get; set; }

    public decimal? UnitPrice { get; set; }
}
