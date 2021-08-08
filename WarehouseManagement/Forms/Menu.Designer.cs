namespace WarehouseManagement
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Products = new System.Windows.Forms.Button();
            this.MenuBar = new System.Windows.Forms.GroupBox();
            this.Employee = new System.Windows.Forms.Button();
            this.OrdersHistory = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Button();
            this.ExitMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.ErrorImage = null;
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(0, -1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(349, 563);
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.SpringGreen;
            this.Products.Location = new System.Drawing.Point(89, 52);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(160, 34);
            this.Products.TabIndex = 8;
            this.Products.Text = "Produkty";
            this.Products.UseVisualStyleBackColor = false;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // MenuBar
            // 
            this.MenuBar.Controls.Add(this.Employee);
            this.MenuBar.Controls.Add(this.OrdersHistory);
            this.MenuBar.Controls.Add(this.Orders);
            this.MenuBar.Controls.Add(this.Clients);
            this.MenuBar.Controls.Add(this.Products);
            this.MenuBar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MenuBar.Location = new System.Drawing.Point(396, 79);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(345, 400);
            this.MenuBar.TabIndex = 9;
            this.MenuBar.TabStop = false;
            this.MenuBar.Text = "Menu";
            // 
            // Employee
            // 
            this.Employee.BackColor = System.Drawing.Color.SpringGreen;
            this.Employee.Location = new System.Drawing.Point(89, 286);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(160, 35);
            this.Employee.TabIndex = 12;
            this.Employee.Text = "Pracownicy";
            this.Employee.UseVisualStyleBackColor = false;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // OrdersHistory
            // 
            this.OrdersHistory.BackColor = System.Drawing.Color.SpringGreen;
            this.OrdersHistory.Location = new System.Drawing.Point(89, 224);
            this.OrdersHistory.Name = "OrdersHistory";
            this.OrdersHistory.Size = new System.Drawing.Size(160, 35);
            this.OrdersHistory.TabIndex = 11;
            this.OrdersHistory.Text = "Historia Zamówień";
            this.OrdersHistory.UseVisualStyleBackColor = false;
            this.OrdersHistory.Click += new System.EventHandler(this.OrdersHistory_Click);
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.Color.SpringGreen;
            this.Orders.Location = new System.Drawing.Point(89, 170);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(160, 33);
            this.Orders.TabIndex = 10;
            this.Orders.Text = "Zamówienia";
            this.Orders.UseVisualStyleBackColor = false;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // Clients
            // 
            this.Clients.BackColor = System.Drawing.Color.SpringGreen;
            this.Clients.Location = new System.Drawing.Point(89, 110);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(160, 34);
            this.Clients.TabIndex = 9;
            this.Clients.Text = "Klienci";
            this.Clients.UseVisualStyleBackColor = false;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitMenu.BackgroundImage")));
            this.ExitMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitMenu.FlatAppearance.BorderSize = 0;
            this.ExitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitMenu.Location = new System.Drawing.Point(764, -1);
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(21, 21);
            this.ExitMenu.TabIndex = 10;
            this.ExitMenu.UseVisualStyleBackColor = true;
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ExitMenu);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.GroupBox MenuBar;
        private System.Windows.Forms.Button OrdersHistory;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Button ExitMenu;
    }
}