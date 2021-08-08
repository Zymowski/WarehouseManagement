namespace WarehouseManagement.Forms
{
    partial class OrdersHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersHistoryForm));
            this.HistoryOrdersBox = new System.Windows.Forms.GroupBox();
            this.ohGridView = new System.Windows.Forms.DataGridView();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ohRefreshBox = new System.Windows.Forms.GroupBox();
            this.ohRefreshButton = new System.Windows.Forms.Button();
            this.ohExit = new System.Windows.Forms.Button();
            this.HistoryOrdersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ohGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.ohRefreshBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryOrdersBox
            // 
            this.HistoryOrdersBox.Controls.Add(this.ohGridView);
            this.HistoryOrdersBox.Location = new System.Drawing.Point(0, 3);
            this.HistoryOrdersBox.Name = "HistoryOrdersBox";
            this.HistoryOrdersBox.Size = new System.Drawing.Size(838, 328);
            this.HistoryOrdersBox.TabIndex = 4;
            this.HistoryOrdersBox.TabStop = false;
            this.HistoryOrdersBox.Text = "Historia Zamówień";
            // 
            // ohGridView
            // 
            this.ohGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ohGridView.Location = new System.Drawing.Point(0, 30);
            this.ohGridView.Name = "ohGridView";
            this.ohGridView.Size = new System.Drawing.Size(838, 268);
            this.ohGridView.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.ErrorImage = null;
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(590, 276);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(250, 389);
            this.Logo.TabIndex = 12;
            this.Logo.TabStop = false;
            // 
            // ohRefreshBox
            // 
            this.ohRefreshBox.Controls.Add(this.ohRefreshButton);
            this.ohRefreshBox.Location = new System.Drawing.Point(178, 419);
            this.ohRefreshBox.Name = "ohRefreshBox";
            this.ohRefreshBox.Size = new System.Drawing.Size(146, 105);
            this.ohRefreshBox.TabIndex = 13;
            this.ohRefreshBox.TabStop = false;
            this.ohRefreshBox.Text = "Odśwież listę";
            // 
            // ohRefreshButton
            // 
            this.ohRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ohRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ohRefreshButton.ForeColor = System.Drawing.Color.Transparent;
            this.ohRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("ohRefreshButton.Image")));
            this.ohRefreshButton.Location = new System.Drawing.Point(32, 30);
            this.ohRefreshButton.Name = "ohRefreshButton";
            this.ohRefreshButton.Size = new System.Drawing.Size(79, 59);
            this.ohRefreshButton.TabIndex = 0;
            this.ohRefreshButton.UseVisualStyleBackColor = true;
            this.ohRefreshButton.Click += new System.EventHandler(this.ohRefreshButton_Click);
            // 
            // ohExit
            // 
            this.ohExit.BackColor = System.Drawing.Color.SpringGreen;
            this.ohExit.Location = new System.Drawing.Point(429, 609);
            this.ohExit.Name = "ohExit";
            this.ohExit.Size = new System.Drawing.Size(127, 33);
            this.ohExit.TabIndex = 14;
            this.ohExit.Text = "Wyjście";
            this.ohExit.UseVisualStyleBackColor = false;
            this.ohExit.Click += new System.EventHandler(this.ohExit_Click);
            // 
            // OrdersHistoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 665);
            this.Controls.Add(this.ohExit);
            this.Controls.Add(this.ohRefreshBox);
            this.Controls.Add(this.HistoryOrdersBox);
            this.Controls.Add(this.Logo);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrdersHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersHistoryForm";
            this.Load += new System.EventHandler(this.OrdersHistoryForm_Load);
            this.HistoryOrdersBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ohGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ohRefreshBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HistoryOrdersBox;
        private System.Windows.Forms.DataGridView ohGridView;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.GroupBox ohRefreshBox;
        private System.Windows.Forms.Button ohRefreshButton;
        private System.Windows.Forms.Button ohExit;
    }
}