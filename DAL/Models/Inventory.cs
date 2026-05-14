using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public partial class Inventory
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int ID { get; set; }

    public string Name { get; set; }

    public string SKU { get; set; }

    public string Category { get; set; }

    public string Location { get; set; }

    public string Stock { get; set; }

    public string RecorderLevel { get; set; }

    public string Status { get; set; }

    
}
