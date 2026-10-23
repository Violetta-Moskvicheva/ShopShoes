using ShopShoes.Models;
using System;
using System.Collections.Generic;

namespace ShopShoes;

public partial class OrderItem
{
    public int Id { get; set; }

    public int IdOrder { get; set; }

    public int IdStockItem { get; set; }

    public int Count { get; set; }

    public virtual Order IdOrderNavigation { get; set; } = null!;

    public virtual StockItem IdStockItemNavigation { get; set; } = null!;
}
