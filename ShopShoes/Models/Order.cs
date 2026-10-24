using ShopShoes.Models;
using System;
using System.Collections.Generic;

namespace ShopShoes;

public partial class Order
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int IdUser { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
