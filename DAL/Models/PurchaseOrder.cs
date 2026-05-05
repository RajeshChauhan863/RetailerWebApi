using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PurchaseOrder
{
    public int PurchasedOrderId { get; set; }

    public int? SupplierId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? Status { get; set; }
}
