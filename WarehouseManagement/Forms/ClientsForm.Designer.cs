namespace WarehouseManagement.Forms
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.ClientBox = new System.Windows.Forms.GroupBox();
            this.cGridView = new System.Windows.Forms.DataGridView();
            this.cAddinBox = new System.Windows.Forms.GroupBox();
            this.cCountryBox = new System.Windows.Forms.TextBox();
            this.cCityBox = new System.Windows.Forms.TextBox();
            this.cAddressBox = new System.Windows.Forms.TextBox();
            this.cSubmit = new System.Windows.Forms.Button();
            this.cNameBox = new System.Windows.Forms.TextBox();
            this.cCountryLabel = new System.Windows.Forms.Label();
            this.cAddresLabel = new System.Windows.Forms.Label();
            this.cCityLabel = new System.Windows.Forms.Label();
            this.cNameLabel = new System.Windows.Forms.Label();
            this.cDeleteBox = new System.Windows.Forms.GroupBox();
            this.cDeleteSelected = new System.Windows.Forms.Button();
            this.cRefreshBox = new System.Windows.Forms.GroupBox();
            this.cRefreshButton = new System.Windows.Forms.Button();
            this.cExit = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ClientBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGridView)).BeginInit();
            this.cAddinBox.SuspendLayout();
            this.cDeleteBox.SuspendLayout();
            this.cRefreshBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientBox
            // 
            this.ClientBox.Controls.Add(this.cGridView);
            this.ClientBox.Location = new System.Drawing.Point(0, 0);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(1020, 360);
            this.ClientBox.TabIndex = 2;
            this.ClientBox.TabStop = false;
            this.ClientBox.Text = "Lista Klientów";
            // 
            // cGridView
            // 
            this.cGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cGridView.Location = new System.Drawing.Point(0, 30);
            this.cGridView.Name = "cGridView";
            this.cGridView.Size = new System.Drawing.Size(1020, 307);
            this.cGridView.TabIndex = 0;
            // 
            // cAddinBox
            // 
            this.cAddinBox.Controls.Add(this.cCountryBox);
            this.cAddinBox.Controls.Add(this.cCityBox);
            this.cAddinBox.Controls.Add(this.cAddressBox);
            this.cAddinBox.Controls.Add(this.cSubmit);
            this.cAddinBox.Controls.Add(this.cNameBox);
            this.cAddinBox.Controls.Add(this.cCountryLabel);
            this.cAddinBox.Controls.Add(this.cAddresLabel);
            this.cAddinBox.Controls.Add(this.cCityLabel);
            this.cAddinBox.Controls.Add(this.cNameLabel);
            this.cAddinBox.Location = new System.Drawing.Point(12, 376);
            this.cAddinBox.Name = "cAddinBox";
            this.cAddinBox.Size = new System.Drawing.Size(382, 283);
            this.cAddinBox.TabIndex = 3;
            this.cAddinBox.TabStop = false;
            this.cAddinBox.Text = "Dodaj Klienta";
            // 
            // cCountryBox
            // 
            this.cCountryBox.Location = new System.Drawing.Point(212, 168);
            this.cCountryBox.Name = "cCountryBox";
            this.cCountryBox.Size = new System.Drawing.Size(164, 31);
            this.cCountryBox.TabIndex = 15;
            // 
            // cCityBox
            // 
            this.cCityBox.Location = new System.Drawing.Point(212, 124);
            this.cCityBox.Name = "cCityBox";
            this.cCityBox.Size = new System.Drawing.Size(164, 31);
            this.cCityBox.TabIndex = 14;
            // 
            // cAddressBox
            // 
            this.cAddressBox.Location = new System.Drawing.Point(212, 80);
            this.cAddressBox.Name = "cAddressBox";
            this.cAddressBox.Size = new System.Drawing.Size(164, 31);
            this.cAddressBox.TabIndex = 13;
            // 
            // cSubmit
            // 
            this.cSubmit.BackColor = System.Drawing.Color.SpringGreen;
            this.cSubmit.Location = new System.Drawing.Point(271, 245);
            this.cSubmit.Name = "cSubmit";
            this.cSubmit.Size = new System.Drawing.Size(105, 32);
            this.cSubmit.TabIndex = 12;
            this.cSubmit.Text = "Dodaj!";
            this.cSubmit.UseVisualStyleBackColor = false;
            this.cSubmit.Click += new System.EventHandler(this.cSubmit_Click);
            // 
            // cNameBox
            // 
            this.cNameBox.Location = new System.Drawing.Point(212, 35);
            this.cNameBox.Name = "cNameBox";
            this.cNameBox.Size = new System.Drawing.Size(164, 31);
            this.cNameBox.TabIndex = 6;
            this.cNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cCountryLabel
            // 
            this.cCountryLabel.AutoSize = true;
            this.cCountryLabel.Location = new System.Drawing.Point(12, 176);
            this.cCountryLabel.Name = "cCountryLabel";
            this.cCountryLabel.Size = new System.Drawing.Size(51, 23);
            this.cCountryLabel.TabIndex = 3;
            this.cCountryLabel.Text = "Kraj:";
            // 
            // cAddresLabel
            // 
            this.cAddresLabel.AutoSize = true;
            this.cAddresLabel.Location = new System.Drawing.Point(12, 88);
            this.cAddresLabel.Name = "cAddresLabel";
            this.cAddresLabel.Size = new System.Drawing.Size(68, 23);
            this.cAddresLabel.TabIndex = 2;
            this.cAddresLabel.Text = "Adres:";
            // 
            // cCityLabel
            // 
            this.cCityLabel.AutoSize = true;
            this.cCityLabel.Location = new System.Drawing.Point(12, 132);
            this.cCityLabel.Name = "cCityLabel";
            this.cCityLabel.Size = new System.Drawing.Size(76, 23);
            this.cCityLabel.TabIndex = 1;
            this.cCityLabel.Text = "Miasto:";
            // 
            // cNameLabel
            // 
            this.cNameLabel.AutoSize = true;
            this.cNameLabel.Location = new System.Drawing.Point(12, 43);
            this.cNameLabel.Name = "cNameLabel";
            this.cNameLabel.Size = new System.Drawing.Size(148, 23);
            this.cNameLabel.TabIndex = 0;
            this.cNameLabel.Text = "Nazwa Klienta:";
            // 
            // cDeleteBox
            // 
            this.cDeleteBox.Controls.Add(this.cDeleteSelected);
            this.cDeleteBox.Location = new System.Drawing.Point(437, 376);
            this.cDeleteBox.Name = "cDeleteBox";
            this.cDeleteBox.Size = new System.Drawing.Size(276, 115);
            this.cDeleteBox.TabIndex = 4;
            this.cDeleteBox.TabStop = false;
            this.cDeleteBox.Text = "Usuń zaznaczonego klienta";
            // 
            // cDeleteSelected
            // 
            this.cDeleteSelected.BackColor = System.Drawing.Color.Tomato;
            this.cDeleteSelected.Location = new System.Drawing.Point(84, 42);
            this.cDeleteSelected.Name = "cDeleteSelected";
            this.cDeleteSelected.Size = new System.Drawing.Size(108, 36);
            this.cDeleteSelected.TabIndex = 0;
            this.cDeleteSelected.Text = "Usuń";
            this.cDeleteSelected.UseVisualStyleBackColor = false;
            this.cDeleteSelected.Click += new System.EventHandler(this.cDeleteSelected_Click);
            // 
            // cRefreshBox
            // 
            this.cRefreshBox.Controls.Add(this.cRefreshButton);
            this.cRefreshBox.Location = new System.Drawing.Point(493, 521);
            this.cRefreshBox.Name = "cRefreshBox";
            this.cRefreshBox.Size = new System.Drawing.Size(146, 105);
            this.cRefreshBox.TabIndex = 5;
            this.cRefreshBox.TabStop = false;
            this.cRefreshBox.Text = "Odśwież listę";
            // 
            // cRefreshButton
            // 
            this.cRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cRefreshButton.ForeColor = System.Drawing.Color.Transparent;
            this.cRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("cRefreshButton.Image")));
            this.cRefreshButton.Location = new System.Drawing.Point(32, 30);
            this.cRefreshButton.Name = "cRefreshButton";
            this.cRefreshButton.Size = new System.Drawing.Size(79, 59);
            this.cRefreshButton.TabIndex = 0;
            this.cRefreshButton.UseVisualStyleBackColor = true;
            this.cRefreshButton.Click += new System.EventHandler(this.cRefreshButton_Click);
            // 
            // cExit
            // 
            this.cExit.BackColor = System.Drawing.Color.SpringGreen;
            this.cExit.Location = new System.Drawing.Point(637, 675);
            this.cExit.Name = "cExit";
            this.cExit.Size = new System.Drawing.Size(127, 33);
            this.cExit.TabIndex = 9;
            this.cExit.Text = "Wyjście";
            this.cExit.UseVisualStyleBackColor = false;
            this.cExit.Click += new System.EventHandler(this.cExit_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.ErrorImage = null;
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(770, 332);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(250, 389);
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            // 
            // ClientsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 720);
            this.Controls.Add(this.cExit);
            this.Controls.Add(this.cRefreshBox);
            this.Controls.Add(this.cDeleteBox);
            this.Controls.Add(this.cAddinBox);
            this.Controls.Add(this.ClientBox);
            this.Controls.Add(this.Logo);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klienci";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            this.ClientBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cGridView)).EndInit();
            this.cAddinBox.ResumeLayout(false);
            this.cAddinBox.PerformLayout();
            this.cDeleteBox.ResumeLayout(false);
            this.cRefreshBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ClientBox;
        private System.Windows.Forms.DataGridView cGridView;
        private System.Windows.Forms.GroupBox cAddinBox;
        private System.Windows.Forms.Button cSubmit;
        private System.Windows.Forms.TextBox cNameBox;
        private System.Windows.Forms.Label cCountryLabel;
        private System.Windows.Forms.Label cAddresLabel;
        private System.Windows.Forms.Label cCityLabel;
        private System.Windows.Forms.Label cNameLabel;
        private System.Windows.Forms.TextBox cCountryBox;
        private System.Windows.Forms.TextBox cCityBox;
        private System.Windows.Forms.TextBox cAddressBox;
        private System.Windows.Forms.GroupBox cDeleteBox;
        private System.Windows.Forms.Button cDeleteSelected;
        private System.Windows.Forms.GroupBox cRefreshBox;
        private System.Windows.Forms.Button cRefreshButton;
        private System.Windows.Forms.Button cExit;
        private System.Windows.Forms.PictureBox Logo;
    }
}