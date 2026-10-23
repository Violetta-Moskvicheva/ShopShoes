using ShopShoes.Models;
using System.Data;

namespace ShopShoes
{
    public partial class FormLogin : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Введите логин", " Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new ShopShoesDbContext())
            {
                var user = db.Users
                    .Where(w => w.Login ==  txtLogin.Text)
                    .FirstOrDefault();
                if(user != null)
                {
                    CurrentUser = user;
                    IsGuest = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            IsGuest = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
