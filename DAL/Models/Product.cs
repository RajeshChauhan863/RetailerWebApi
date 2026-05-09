using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public partial class Product
{

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int ID { get; set; }

    public string? Name { get; set; }

    public string? SKU { get; set; }

    public string? Category { get; set; }

    public decimal? Price { get; set; }

    public decimal? Stock { get; set; } 

    public string? Status { get; set; }
}
