using ShopShoes.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShopShoes
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        public void ProductCard_Load(Product product, decimal finalPrice)
        {
            pbPhoto.Image = LoadProductImage(product.Img);

            int totalStock = 0;
            string totalStockStatus = null;

            if (product.StockItems != null)
            {
                totalStock = product.StockItems.Sum(s => s.Count);
                if (totalStock > 5)
                {
                    totalStockStatus = "много";
                }
                else
                {
                    totalStockStatus = "мало";
                }
            }

            lblManufAndName.Text = $"{product.Manufacturer?.Name} | {product.Name}";
            lblCategory.Text = $"Категория: {product.Category?.Name}";
            lblCount.Text = $"Количество: {totalStockStatus}";
            lblCompound.Text = $"Состав: {product.Compound}";

            lblPrice.Text = $"{finalPrice}";

            if (totalStock <= 3)
            {
                this.BackColor = ColorTranslator.FromHtml("#FF8080");
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private Image LoadProductImage(string Img)
        {
            if (!String.IsNullOrEmpty(Img))
            {
                string resourceName = Path.GetFileNameWithoutExtension(Img).Trim();

                var rm = Properties.Resources.ResourceManager;
                var img = rm.GetObject(resourceName) as Image;

                return img;
            }

            return Resources.picture;
        }
    }
}
