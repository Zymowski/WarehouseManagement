namespace WarehouseManagement.Forms
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.AddinBox = new System.Windows.Forms.GroupBox();
            this.pUnitCombo = new System.Windows.Forms.ComboBox();
            this.pPriceText = new System.Windows.Forms.TextBox();
            this.pSubmit = new System.Windows.Forms.Button();
            this.pPrice = new System.Windows.Forms.Label();
            this.pCatCombo = new System.Windows.Forms.ComboBox();
            this.pAmmoTextBox = new System.Windows.Forms.TextBox();
            this.pDepCombo = new System.Windows.Forms.ComboBox();
            this.pSuppCombo = new System.Windows.Forms.ComboBox();
            this.pNameTextBox = new System.Windows.Forms.TextBox();
            this.Unit = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Supplier = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.DeleteProductBox = new System.Windows.Forms.GroupBox();
            this.pDeleteSelected = new System.Windows.Forms.Button();
            this.RefreshBox = new System.Windows.Forms.GroupBox();
            this.pRefreshButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pExit = new System.Windows.Forms.Button();
            this.productBox = new System.Windows.Forms.GroupBox();
            this.pGridView = new System.Windows.Forms.DataGridView();
            this.AddinBox.SuspendLayout();
            this.DeleteProductBox.SuspendLayout();
            this.RefreshBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.productBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddinBox
            // 
            this.AddinBox.Controls.Add(this.pUnitCombo);
            this.AddinBox.Controls.Add(this.pPriceText);
            this.AddinBox.Controls.Add(this.pSubmit);
            this.AddinBox.Controls.Add(this.pPrice);
            this.AddinBox.Controls.Add(this.pCatCombo);
            this.AddinBox.Controls.Add(this.pAmmoTextBox);
            this.AddinBox.Controls.Add(this.pDepCombo);
            this.AddinBox.Controls.Add(this.pSuppCombo);
            this.AddinBox.Controls.Add(this.pNameTextBox);
            this.AddinBox.Controls.Add(this.Unit);
            this.AddinBox.Controls.Add(this.Stock);
            this.AddinBox.Controls.Add(this.Department);
            this.AddinBox.Controls.Add(this.Category);
            this.AddinBox.Controls.Add(this.Supplier);
            this.AddinBox.Controls.Add(this.ProductName);
            this.AddinBox.Location = new System.Drawing.Point(1, 348);
            this.AddinBox.Name = "AddinBox";
            this.AddinBox.Size = new System.Drawing.Size(406, 372);
            this.AddinBox.TabIndex = 2;
            this.AddinBox.TabStop = false;
            this.AddinBox.Text = "Dodaj produkt";
            this.AddinBox.Enter += new System.EventHandler(this.AddinBox_Enter);
            // 
            // pUnitCombo
            // 
            this.pUnitCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pUnitCombo.FormattingEnabled = true;
            this.pUnitCombo.Location = new System.Drawing.Point(314, 255);
            this.pUnitCombo.Name = "pUnitCombo";
            this.pUnitCombo.Size = new System.Drawing.Size(66, 31);
            this.pUnitCombo.TabIndex = 15;
            // 
            // pPriceText
            // 
            this.pPriceText.Location = new System.Drawing.Point(213, 292);
            this.pPriceText.Name = "pPriceText";
            this.pPriceText.Size = new System.Drawing.Size(167, 31);
            this.pPriceText.TabIndex = 14;
            // 
            // pSubmit
            // 
            this.pSubmit.BackColor = System.Drawing.Color.SpringGreen;
            this.pSubmit.Location = new System.Drawing.Point(295, 334);
            this.pSubmit.Name = "pSubmit";
            this.pSubmit.Size = new System.Drawing.Size(105, 32);
            this.pSubmit.TabIndex = 12;
            this.pSubmit.Text = "Dodaj!";
            this.pSubmit.UseVisualStyleBackColor = false;
            this.pSubmit.Click += new System.EventHandler(this.pSubmit_Click);
            // 
            // pPrice
            // 
            this.pPrice.AutoSize = true;
            this.pPrice.Location = new System.Drawing.Point(11, 300);
            this.pPrice.Name = "pPrice";
            this.pPrice.Size = new System.Drawing.Size(66, 23);
            this.pPrice.TabIndex = 12;
            this.pPrice.Text = "Cena:";
            // 
            // pCatCombo
            // 
            this.pCatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pCatCombo.FormattingEnabled = true;
            this.pCatCombo.Location = new System.Drawing.Point(213, 85);
            this.pCatCombo.Name = "pCatCombo";
            this.pCatCombo.Size = new System.Drawing.Size(167, 31);
            this.pCatCombo.TabIndex = 7;
            // 
            // pAmmoTextBox
            // 
            this.pAmmoTextBox.Location = new System.Drawing.Point(213, 220);
            this.pAmmoTextBox.Name = "pAmmoTextBox";
            this.pAmmoTextBox.Size = new System.Drawing.Size(167, 31);
            this.pAmmoTextBox.TabIndex = 10;
            // 
            // pDepCombo
            // 
            this.pDepCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pDepCombo.FormattingEnabled = true;
            this.pDepCombo.Location = new System.Drawing.Point(213, 176);
            this.pDepCombo.Name = "pDepCombo";
            this.pDepCombo.Size = new System.Drawing.Size(167, 31);
            this.pDepCombo.TabIndex = 9;
            this.pDepCombo.SelectedIndexChanged += new System.EventHandler(this.pDepCombo_SelectedIndexChanged);
            // 
            // pSuppCombo
            // 
            this.pSuppCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pSuppCombo.FormattingEnabled = true;
            this.pSuppCombo.Location = new System.Drawing.Point(213, 132);
            this.pSuppCombo.Name = "pSuppCombo";
            this.pSuppCombo.Size = new System.Drawing.Size(167, 31);
            this.pSuppCombo.TabIndex = 8;
            // 
            // pNameTextBox
            // 
            this.pNameTextBox.Location = new System.Drawing.Point(213, 40);
            this.pNameTextBox.Name = "pNameTextBox";
            this.pNameTextBox.Size = new System.Drawing.Size(167, 31);
            this.pNameTextBox.TabIndex = 6;
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Location = new System.Drawing.Point(9, 259);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(110, 23);
            this.Unit.TabIndex = 5;
            this.Unit.Text = "Jednostka:";
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(12, 220);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(57, 23);
            this.Stock.TabIndex = 4;
            this.Stock.Text = "Ilość:";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(12, 176);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(61, 23);
            this.Department.TabIndex = 3;
            this.Department.Text = "Dział:";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(12, 88);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(107, 23);
            this.Category.TabIndex = 2;
            this.Category.Text = "Kategoria:";
            // 
            // Supplier
            // 
            this.Supplier.AutoSize = true;
            this.Supplier.Location = new System.Drawing.Point(12, 132);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(107, 23);
            this.Supplier.TabIndex = 1;
            this.Supplier.Text = "Dostawca:";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(12, 43);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(167, 23);
            this.ProductName.TabIndex = 0;
            this.ProductName.Text = "Nazwa produktu:";
            this.ProductName.Click += new System.EventHandler(this.ProductName_Click);
            // 
            // DeleteProductBox
            // 
            this.DeleteProductBox.Controls.Add(this.pDeleteSelected);
            this.DeleteProductBox.Location = new System.Drawing.Point(436, 366);
            this.DeleteProductBox.Name = "DeleteProductBox";
            this.DeleteProductBox.Size = new System.Drawing.Size(276, 115);
            this.DeleteProductBox.TabIndex = 3;
            this.DeleteProductBox.TabStop = false;
            this.DeleteProductBox.Text = "Usuń zaznaczony produkt";
            // 
            // pDeleteSelected
            // 
            this.pDeleteSelected.BackColor = System.Drawing.Color.Tomato;
            this.pDeleteSelected.Location = new System.Drawing.Point(84, 42);
            this.pDeleteSelected.Name = "pDeleteSelected";
            this.pDeleteSelected.Size = new System.Drawing.Size(108, 36);
            this.pDeleteSelected.TabIndex = 0;
            this.pDeleteSelected.Text = "Usuń";
            this.pDeleteSelected.UseVisualStyleBackColor = false;
            this.pDeleteSelected.Click += new System.EventHandler(this.pDeleteSelected_Click);
            // 
            // RefreshBox
            // 
            this.RefreshBox.Controls.Add(this.pRefreshButton);
            this.RefreshBox.Location = new System.Drawing.Point(498, 494);
            this.RefreshBox.Name = "RefreshBox";
            this.RefreshBox.Size = new System.Drawing.Size(146, 105);
            this.RefreshBox.TabIndex = 4;
            this.RefreshBox.TabStop = false;
            this.RefreshBox.Text = "Odśwież listę";
            this.RefreshBox.Enter += new System.EventHandler(this.RefreshBox_Enter);
            // 
            // pRefreshButton
            // 
            this.pRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pRefreshButton.ForeColor = System.Drawing.Color.Transparent;
            this.pRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("pRefreshButton.Image")));
            this.pRefreshButton.Location = new System.Drawing.Point(32, 30);
            this.pRefreshButton.Name = "pRefreshButton";
            this.pRefreshButton.Size = new System.Drawing.Size(79, 59);
            this.pRefreshButton.TabIndex = 0;
            this.pRefreshButton.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.ErrorImage = null;
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(770, 331);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(250, 389);
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // pExit
            // 
            this.pExit.BackColor = System.Drawing.Color.SpringGreen;
            this.pExit.Location = new System.Drawing.Point(637, 675);
            this.pExit.Name = "pExit";
            this.pExit.Size = new System.Drawing.Size(127, 33);
            this.pExit.TabIndex = 8;
            this.pExit.Text = "Wyjście";
            this.pExit.UseVisualStyleBackColor = false;
            this.pExit.Click += new System.EventHandler(this.pExit_Click);
            // 
            // productBox
            // 
            this.productBox.Controls.Add(this.pGridView);
            this.productBox.Location = new System.Drawing.Point(1, 0);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(1019, 342);
            this.productBox.TabIndex = 9;
            this.productBox.TabStop = false;
            this.productBox.Text = "Lista Produktów";
            // 
            // pGridView
            // 
            this.pGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pGridView.Location = new System.Drawing.Point(0, 30);
            this.pGridView.Name = "pGridView";
            this.pGridView.Size = new System.Drawing.Size(1019, 295);
            this.pGridView.TabIndex = 0;
            // 
            // ProductForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 720);
            this.Controls.Add(this.productBox);
            this.Controls.Add(this.pExit);
            this.Controls.Add(this.RefreshBox);
            this.Controls.Add(this.DeleteProductBox);
            this.Controls.Add(this.AddinBox);
            this.Controls.Add(this.Logo);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.AddinBox.ResumeLayout(false);
            this.AddinBox.PerformLayout();
            this.DeleteProductBox.ResumeLayout(false);
            this.RefreshBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.productBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox AddinBox;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Supplier;
        private System.Windows.Forms.Button pSubmit;
        private System.Windows.Forms.TextBox pAmmoTextBox;
        private System.Windows.Forms.ComboBox pDepCombo;
        private System.Windows.Forms.ComboBox pSuppCombo;
        private System.Windows.Forms.ComboBox pCatCombo;
        private System.Windows.Forms.TextBox pNameTextBox;
        private System.Windows.Forms.GroupBox DeleteProductBox;
        private System.Windows.Forms.Button pDeleteSelected;
        private System.Windows.Forms.GroupBox RefreshBox;
        private System.Windows.Forms.Button pRefreshButton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button pExit;
        private System.Windows.Forms.GroupBox productBox;
        private System.Windows.Forms.DataGridView pGridView;
        private System.Windows.Forms.TextBox pPriceText;
        private System.Windows.Forms.Label pPrice;
        private System.Windows.Forms.ComboBox pUnitCombo;
    }
}