namespace ShopShoes
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pnMain = new Panel();
            txtLogin = new TextBox();
            lbLogin = new Label();
            btnGuest = new Button();
            btnLogin = new Button();
            pbLogo = new PictureBox();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(txtLogin);
            pnMain.Controls.Add(lbLogin);
            pnMain.Controls.Add(btnGuest);
            pnMain.Controls.Add(btnLogin);
            pnMain.Location = new Point(12, 139);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(360, 210);
            pnMain.TabIndex = 0;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Calibri", 12F);
            txtLogin.Location = new Point(48, 41);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(264, 27);
            txtLogin.TabIndex = 3;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Calibri", 12F);
            lbLogin.Location = new Point(152, 19);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(55, 19);
            lbLogin.TabIndex = 2;
            lbLogin.Text = "Логин ";
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(112, 178, 175);
            btnGuest.FlatAppearance.BorderSize = 0;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Font = new Font("Calibri", 12F);
            btnGuest.Location = new Point(99, 141);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(162, 23);
            btnGuest.TabIndex = 1;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += btnGuest_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(210, 246, 231);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Calibri", 12F);
            btnLogin.Location = new Point(99, 99);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(146, 29);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(pbLogo);
            Controls.Add(pnMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private TextBox txtLogin;
        private Label lbLogin;
        private Button btnGuest;
        private Button btnLogin;
        private PictureBox pbLogo;
    }
}