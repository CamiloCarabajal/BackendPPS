using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Product
{
    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int? Stock { get; set; }

    public string? Size { get; set; }

    public virtual ICollection<Saleorderline> Saleorderlines { get; set; } = new List<Saleorderline>();
}
