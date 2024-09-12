using System;
using System.Collections.Generic;


namespace Domain.Entities;

public partial class Saleorderline
{
    public int Id { get; set; }

    public int Amount { get; set; }

    public decimal UnitPrice { get; set; }

    public int ProductCode { get; set; }

    public int SaleorderId { get; set; }

    public virtual Product ProductCodeNavigation { get; set; } = null!;

    public virtual Saleorder Saleorder { get; set; } = null!;
}
