namespace ShopShoes
{
    partial class FormProducts
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnTop = new Panel();
            btnLogout = new Button();
            lbUserName = new Label();
            dgvProducts = new DataGridView();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.Controls.Add(lbUserName);
            pnTop.Controls.Add(btnLogout);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(10, 10);
            pnTop.Margin = new Padding(3, 4, 3, 4);
            pnTop.Name = "pnTop";
            pnTop.Padding = new Padding(0, 0, 0, 10);
            pnTop.Size = new Size(894, 40);
            pnTop.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(112, 178, 175);
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(808, 0);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 30);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Dock = DockStyle.Right;
            lbUserName.Location = new Point(759, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(49, 19);
            lbUserName.TabIndex = 2;
            lbUserName.Text = "label1";
            lbUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle4;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(10, 50);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(894, 510);
            dgvProducts.TabIndex = 1;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 570);
            Controls.Add(dgvProducts);
            Controls.Add(pnTop);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProducts";
            Padding = new Padding(10);
            Text = "Список товаров";
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTop;
        private Label lbUserName;
        private Button btnLogout;
        private DataGridView dgvProducts;
    }
}