using System;
using System.Collections.Generic;

namespace ShopShoes.Models;

public partial class Size
{
    public int Id { get; set; }

    public decimal Size1 { get; set; }

    public virtual ICollection<StockItem> StockItems { get; set; } = new List<StockItem>();
}
