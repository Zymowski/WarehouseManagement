namespace WarehouseManagement.Forms
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.OrdersBox = new System.Windows.Forms.GroupBox();
            this.oGridView = new System.Windows.Forms.DataGridView();
            this.oAddinBox = new System.Windows.Forms.GroupBox();
            this.oAmmoTextBox = new System.Windows.Forms.TextBox();
            this.oAmmoLabel = new System.Windows.Forms.Label();
            this.oClientNameCombo = new System.Windows.Forms.ComboBox();
            this.oProdNameCombo = new System.Windows.Forms.ComboBox();
            this.oSubmit = new System.Windows.Forms.Button();
            this.oClientNameLabel = new System.Windows.Forms.Label();
            this.oProdNamelabel = new System.Windows.Forms.Label();
            this.oRefreshBox = new System.Windows.Forms.GroupBox();
            this.oRefreshButton = new System.Windows.Forms.Button();
            this.oDeleteOrderBox = new System.Windows.Forms.GroupBox();
            this.oDeleteSelected = new System.Windows.Forms.Button();
            this.oExit = new System.Windows.Forms.Button();
            this.oExecuteGroupBox = new System.Windows.Forms.GroupBox();
            this.oExecute = new System.Windows.Forms.Button();
            this.OrdersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oGridView)).BeginInit();
            this.oAddinBox.SuspendLayout();
            this.oRefreshBox.SuspendLayout();
            this.oDeleteOrderBox.SuspendLayout();
            this.oExecuteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersBox
            // 
            this.OrdersBox.Controls.Add(this.oGridView);
            this.OrdersBox.Location = new System.Drawing.Point(0, 0);
            this.OrdersBox.Name = "OrdersBox";
            this.OrdersBox.Size = new System.Drawing.Size(1019, 360);
            this.OrdersBox.TabIndex = 3;
            this.OrdersBox.TabStop = false;
            this.OrdersBox.Text = "Zamówienia";
            // 
            // oGridView
            // 
            this.oGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oGridView.Location = new System.Drawing.Point(0, 30);
            this.oGridView.Name = "oGridView";
            this.oGridView.Size = new System.Drawing.Size(1022, 308);
            this.oGridView.TabIndex = 0;
            // 
            // oAddinBox
            // 
            this.oAddinBox.Controls.Add(this.oAmmoTextBox);
            this.oAddinBox.Controls.Add(this.oAmmoLabel);
            this.oAddinBox.Controls.Add(this.oClientNameCombo);
            this.oAddinBox.Controls.Add(this.oProdNameCombo);
            this.oAddinBox.Controls.Add(this.oSubmit);
            this.oAddinBox.Controls.Add(this.oClientNameLabel);
            this.oAddinBox.Controls.Add(this.oProdNamelabel);
            this.oAddinBox.Location = new System.Drawing.Point(22, 376);
            this.oAddinBox.Name = "oAddinBox";
            this.oAddinBox.Size = new System.Drawing.Size(378, 303);
            this.oAddinBox.TabIndex = 4;
            this.oAddinBox.TabStop = false;
            this.oAddinBox.Text = "Dodaj Zamówienie";
            // 
            // oAmmoTextBox
            // 
            this.oAmmoTextBox.Location = new System.Drawing.Point(187, 121);
            this.oAmmoTextBox.Name = "oAmmoTextBox";
            this.oAmmoTextBox.Size = new System.Drawing.Size(168, 31);
            this.oAmmoTextBox.TabIndex = 20;
            // 
            // oAmmoLabel
            // 
            this.oAmmoLabel.AutoSize = true;
            this.oAmmoLabel.Location = new System.Drawing.Point(48, 124);
            this.oAmmoLabel.Name = "oAmmoLabel";
            this.oAmmoLabel.Size = new System.Drawing.Size(57, 23);
            this.oAmmoLabel.TabIndex = 19;
            this.oAmmoLabel.Text = "Ilość:\r\n";
            // 
            // oClientNameCombo
            // 
            this.oClientNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oClientNameCombo.FormattingEnabled = true;
            this.oClientNameCombo.Location = new System.Drawing.Point(187, 196);
            this.oClientNameCombo.Name = "oClientNameCombo";
            this.oClientNameCombo.Size = new System.Drawing.Size(168, 31);
            this.oClientNameCombo.TabIndex = 18;
            // 
            // oProdNameCombo
            // 
            this.oProdNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oProdNameCombo.FormattingEnabled = true;
            this.oProdNameCombo.Location = new System.Drawing.Point(187, 53);
            this.oProdNameCombo.Name = "oProdNameCombo";
            this.oProdNameCombo.Size = new System.Drawing.Size(168, 31);
            this.oProdNameCombo.TabIndex = 17;
            // 
            // oSubmit
            // 
            this.oSubmit.BackColor = System.Drawing.Color.SpringGreen;
            this.oSubmit.Location = new System.Drawing.Point(250, 261);
            this.oSubmit.Name = "oSubmit";
            this.oSubmit.Size = new System.Drawing.Size(105, 32);
            this.oSubmit.TabIndex = 12;
            this.oSubmit.Text = "Dodaj!";
            this.oSubmit.UseVisualStyleBackColor = false;
            this.oSubmit.Click += new System.EventHandler(this.oSubmit_Click);
            // 
            // oClientNameLabel
            // 
            this.oClientNameLabel.AutoSize = true;
            this.oClientNameLabel.Location = new System.Drawing.Point(6, 199);
            this.oClientNameLabel.Name = "oClientNameLabel";
            this.oClientNameLabel.Size = new System.Drawing.Size(148, 23);
            this.oClientNameLabel.TabIndex = 3;
            this.oClientNameLabel.Text = "Nazwa Klienta:";
            // 
            // oProdNamelabel
            // 
            this.oProdNamelabel.AutoSize = true;
            this.oProdNamelabel.Location = new System.Drawing.Point(6, 52);
            this.oProdNamelabel.Name = "oProdNamelabel";
            this.oProdNamelabel.Size = new System.Drawing.Size(165, 23);
            this.oProdNamelabel.TabIndex = 1;
            this.oProdNamelabel.Text = "Nazwa Produktu:";
            // 
            // oRefreshBox
            // 
            this.oRefreshBox.Controls.Add(this.oRefreshButton);
            this.oRefreshBox.Location = new System.Drawing.Point(834, 459);
            this.oRefreshBox.Name = "oRefreshBox";
            this.oRefreshBox.Size = new System.Drawing.Size(148, 116);
            this.oRefreshBox.TabIndex = 6;
            this.oRefreshBox.TabStop = false;
            this.oRefreshBox.Text = "Odśwież listę";
            // 
            // oRefreshButton
            // 
            this.oRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.oRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oRefreshButton.ForeColor = System.Drawing.Color.Transparent;
            this.oRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("oRefreshButton.Image")));
            this.oRefreshButton.Location = new System.Drawing.Point(41, 32);
            this.oRefreshButton.Name = "oRefreshButton";
            this.oRefreshButton.Size = new System.Drawing.Size(65, 59);
            this.oRefreshButton.TabIndex = 0;
            this.oRefreshButton.UseVisualStyleBackColor = true;
            this.oRefreshButton.Click += new System.EventHandler(this.oRefreshButton_Click);
            // 
            // oDeleteOrderBox
            // 
            this.oDeleteOrderBox.Controls.Add(this.oDeleteSelected);
            this.oDeleteOrderBox.Location = new System.Drawing.Point(468, 376);
            this.oDeleteOrderBox.Name = "oDeleteOrderBox";
            this.oDeleteOrderBox.Size = new System.Drawing.Size(302, 121);
            this.oDeleteOrderBox.TabIndex = 5;
            this.oDeleteOrderBox.TabStop = false;
            this.oDeleteOrderBox.Text = "Usuń zaznaczone zamówienie";
            this.oDeleteOrderBox.Enter += new System.EventHandler(this.oDeleteOrderBox_Enter);
            // 
            // oDeleteSelected
            // 
            this.oDeleteSelected.BackColor = System.Drawing.Color.Tomato;
            this.oDeleteSelected.Location = new System.Drawing.Point(82, 43);
            this.oDeleteSelected.Name = "oDeleteSelected";
            this.oDeleteSelected.Size = new System.Drawing.Size(137, 41);
            this.oDeleteSelected.TabIndex = 0;
            this.oDeleteSelected.Text = "Usuń";
            this.oDeleteSelected.UseVisualStyleBackColor = false;
            this.oDeleteSelected.Click += new System.EventHandler(this.oDeleteSelected_Click);
            // 
            // oExit
            // 
            this.oExit.BackColor = System.Drawing.Color.SpringGreen;
            this.oExit.Location = new System.Drawing.Point(866, 675);
            this.oExit.Name = "oExit";
            this.oExit.Size = new System.Drawing.Size(127, 33);
            this.oExit.TabIndex = 10;
            this.oExit.Text = "Wyjście";
            this.oExit.UseVisualStyleBackColor = false;
            this.oExit.Click += new System.EventHandler(this.oExit_Click);
            // 
            // oExecuteGroupBox
            // 
            this.oExecuteGroupBox.Controls.Add(this.oExecute);
            this.oExecuteGroupBox.Location = new System.Drawing.Point(429, 532);
            this.oExecuteGroupBox.Name = "oExecuteGroupBox";
            this.oExecuteGroupBox.Size = new System.Drawing.Size(383, 147);
            this.oExecuteGroupBox.TabIndex = 12;
            this.oExecuteGroupBox.TabStop = false;
            this.oExecuteGroupBox.Text = "Realizacja zaznaczonego zamówienia";
            // 
            // oExecute
            // 
            this.oExecute.BackColor = System.Drawing.Color.SpringGreen;
            this.oExecute.Location = new System.Drawing.Point(131, 68);
            this.oExecute.Name = "oExecute";
            this.oExecute.Size = new System.Drawing.Size(137, 41);
            this.oExecute.TabIndex = 0;
            this.oExecute.Text = "Wykonaj!";
            this.oExecute.UseVisualStyleBackColor = false;
            this.oExecute.Click += new System.EventHandler(this.oExecute_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 720);
            this.Controls.Add(this.oRefreshBox);
            this.Controls.Add(this.oExecuteGroupBox);
            this.Controls.Add(this.oExit);
            this.Controls.Add(this.oDeleteOrderBox);
            this.Controls.Add(this.oAddinBox);
            this.Controls.Add(this.OrdersBox);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.OrdersBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oGridView)).EndInit();
            this.oAddinBox.ResumeLayout(false);
            this.oAddinBox.PerformLayout();
            this.oRefreshBox.ResumeLayout(false);
            this.oDeleteOrderBox.ResumeLayout(false);
            this.oExecuteGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OrdersBox;
        private System.Windows.Forms.DataGridView oGridView;
        private System.Windows.Forms.GroupBox oAddinBox;
        private System.Windows.Forms.ComboBox oClientNameCombo;
        private System.Windows.Forms.ComboBox oProdNameCombo;
        private System.Windows.Forms.Button oSubmit;
        private System.Windows.Forms.Label oClientNameLabel;
        private System.Windows.Forms.Label oProdNamelabel;
        private System.Windows.Forms.GroupBox oDeleteOrderBox;
        private System.Windows.Forms.Button oDeleteSelected;
        private System.Windows.Forms.GroupBox oRefreshBox;
        private System.Windows.Forms.Button oRefreshButton;
        private System.Windows.Forms.Button oExit;
        private System.Windows.Forms.GroupBox oExecuteGroupBox;
        private System.Windows.Forms.Button oExecute;
        private System.Windows.Forms.TextBox oAmmoTextBox;
        private System.Windows.Forms.Label oAmmoLabel;
    }
}