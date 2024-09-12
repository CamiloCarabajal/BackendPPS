using System;
using System.Collections.Generic;


namespace Domain.Entities;

public partial class Saleorder
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<Saleorderline> Saleorderlines { get; set; } = new List<Saleorderline>();

    public virtual User User { get; set; } = null!;
}
