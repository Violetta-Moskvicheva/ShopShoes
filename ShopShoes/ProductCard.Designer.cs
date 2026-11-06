namespace ShopShoes
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbPhoto = new PictureBox();
            lblPrice = new Label();
            lblManufAndName = new Label();
            lblCategory = new Label();
            lblCount = new Label();
            lblCompound = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            SuspendLayout();
            // 
            // pbPhoto
            // 
            pbPhoto.Dock = DockStyle.Left;
            pbPhoto.Location = new Point(0, 0);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(140, 138);
            pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhoto.TabIndex = 0;
            pbPhoto.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPrice.Location = new Point(812, 57);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(58, 26);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Цена";
            lblPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblManufAndName
            // 
            lblManufAndName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblManufAndName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblManufAndName.Location = new Point(146, 10);
            lblManufAndName.Name = "lblManufAndName";
            lblManufAndName.Size = new Size(751, 19);
            lblManufAndName.TabIndex = 2;
            lblManufAndName.Text = "Производство | Наименовние";
            lblManufAndName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(161, 33);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(63, 14);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Категория";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(161, 62);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(69, 14);
            lblCount.TabIndex = 4;
            lblCount.Text = "Количество";
            // 
            // lblCompound
            // 
            lblCompound.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCompound.Location = new Point(161, 88);
            lblCompound.Name = "lblCompound";
            lblCompound.Size = new Size(618, 32);
            lblCompound.TabIndex = 5;
            lblCompound.Text = "Состав";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblCompound);
            Controls.Add(lblCount);
            Controls.Add(lblCategory);
            Controls.Add(lblManufAndName);
            Controls.Add(lblPrice);
            Controls.Add(pbPhoto);
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "ProductCard";
            Size = new Size(900, 138);
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPhoto;
        private Label lblPrice;
        private Label lblManufAndName;
        private Label lblCategory;
        private Label lblCount;
        private Label lblCompound;
    }
}
