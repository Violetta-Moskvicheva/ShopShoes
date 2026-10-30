using Microsoft.EntityFrameworkCore;
using ShopShoes.Models;
using ShopShoes.Properties;

namespace ShopShoes
{
    public partial class FormProducts : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormProducts(User user, bool guest)
        {
            InitializeComponent();

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 30;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colPrice = new DataGridViewTextBoxColumn();
            colPrice.Name = "colPrice";
            colPrice.FillWeight = 15;
            colPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvProducts.Columns.AddRange([colPhoto, colInfo, colPrice]);

            CurrentUser = user;
            IsGuest = guest;

            if (IsGuest)
            {
                lbUserName.Text = "Гость";
                btnLogout.Text = " Назад";
            } else
            {
                lbUserName.Text = CurrentUser.FullName;
            }
            

            LoadProducts();
         }


        private void LoadProducts()
        {
            try
            {
                using (var db = new ShopShoesDbContext())
                {
                    var products = db.Products
                        .Include(i => i.Category)
                        .Include(i => i.Subcategory)
                        .Include(i => i.Manufacturer)
                        .Include(i => i.StockItems)
                            .ThenInclude(oi => oi.OrderItems)
                                .ThenInclude(o => o.Order)
                        .ToList();

                    dgvProducts.SuspendLayout();
                    dgvProducts.Rows.Clear();

                    foreach(var product in products)
                    {
                        DateTime now = DateTime.Now;
                        DateTime startOfCurrentMonth = new DateTime(now.Year, now.Month, 1);
                        DateTime startOfPreMonth = startOfCurrentMonth.AddMonths(-1);

                        var stockItems = product.StockItems ?? Enumerable.Empty<StockItem>();


                        bool hasOrdersInPrevMonth = stockItems
                            .SelectMany(si => si.OrderItems ?? Enumerable.Empty<OrderItem>())
                            .Where(oi => oi.Order != null)
                            .Select(oi => oi.Order.Date)
                            .Any(d => d >= startOfPreMonth && d < startOfCurrentMonth);

                        decimal finalPrice = hasOrdersInPrevMonth
                            ? product.Price
                            : product.Price - (product.Price * 0.25m); 

                        int rowIndex = dgvProducts.Rows.Add();
                        var row = dgvProducts.Rows[rowIndex];

                        row.Cells["colPhoto"].Value = LoadProductImage(product.Img);
                        row.Cells["colInfo"].Value = FormatProductInfo(product);
                        row.Cells["colPrice"].Value = $"{finalPrice:C}";

                        ApplyRowStyles(row, product);
                    }

                    

                    dgvProducts.ResumeLayout();
                    dgvProducts.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private string FormatProductInfo(Product product)
        {
            int totalStock = 0;
            string totalStockStatus = null;

            if (product.StockItems != null)
            {
                totalStock = product.StockItems.Sum(s => s.Count);
                if (totalStock > 5)
                {
                    totalStockStatus = "много";
                } else
                {
                    totalStockStatus = "мало";
                }
            }

            return $"{product.Manufacturer?.Name} | {product.Name}" + Environment.NewLine +
               $"Категория: {product.Category?.Name}" + Environment.NewLine +
               $"Количество: {totalStockStatus}" + Environment.NewLine +
               $"Состав: {product.Compound}";

        }

        private void ApplyRowStyles(DataGridViewRow row, Product product)
        {
            int totalStock = 0;

            if (product.StockItems != null)
            {
                totalStock = product.StockItems.Sum(s => s.Count);
            }


            if (totalStock <= 3)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF8080");
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //обработка закрытия формы
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}
