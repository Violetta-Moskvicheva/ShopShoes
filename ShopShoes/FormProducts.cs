using Microsoft.EntityFrameworkCore;
using ShopShoes.Models;

namespace ShopShoes
{
    public partial class FormProducts : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormProducts(User user, bool guest)
        {
            InitializeComponent();

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

                    DateTime today = DateTime.Today;
                    //первое число тек месяца
                    DateTime startOfCurrentMonth = new DateTime(today.Year, today.Month, 1);
                    //первое число прошлого песяца
                    DateTime startOfPreMonth = startOfCurrentMonth.AddMonths(-1);

                    flpProducts.SuspendLayout();
                    flpProducts.Controls.Clear();

                    foreach(var product in products)
                    {
                        //ищем, были ли заказы по этому товару в прошлом месяце
                        bool hasOrdersInPrevMonth = product.StockItems?
                            //перебираем все склады, на которых лежит тек товар
                            .Any(si => si.OrderItems?
                                //ищем хотя бы одну покупку за прошлый месяц
                                .Any(oi => oi.Order != null &&
                                   oi.Order.Date >= startOfPreMonth &&
                                   oi.Order.Date < startOfCurrentMonth) ?? false) ?? false;

                        decimal finalPrice = hasOrdersInPrevMonth
                            ? product.Price
                            : product.Price - (product.Price * 0.25m);

                        ProductCard card = new ProductCard();

                        card.ProductCard_Load(product, finalPrice);

                        flpProducts.Controls.Add(card);
                    }
                    flpProducts.ResumeLayout();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}
