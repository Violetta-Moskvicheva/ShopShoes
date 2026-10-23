using ShopShoes.Models;
using System;
using System.Collections.Generic;

namespace ShopShoes;

public partial class Product
{
    public int Id { get; set; }

    public int IdCategory { get; set; }

    public string Img { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int IdManufacturer { get; set; }

    public string Description { get; set; } = null!;

    public string Compound { get; set; } = null!;

    public decimal Price { get; set; }

    public int IdSubcategory { get; set; }

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Manufacturer IdManufacturerNavigation { get; set; } = null!;

    public virtual Subcategory IdSubcategoryNavigation { get; set; } = null!;

    public virtual ICollection<StockItem> StockItems { get; set; } = new List<StockItem>();
}
