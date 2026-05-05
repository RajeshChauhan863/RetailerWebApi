using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SalesOrder
{
    public int SalesOrderId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? Status { get; set; }
}
