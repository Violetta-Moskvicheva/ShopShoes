using System;
using System.Collections.Generic;

namespace ShopShoes.Models;

public partial class StockItem
{
    public int Id { get; set; }

    public int IdProduct { get; set; }

    public int IdSize { get; set; }

    public int Count { get; set; }

    public virtual Product IdProductNavigation { get; set; } = null!;

    public virtual Size IdSizeNavigation { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
