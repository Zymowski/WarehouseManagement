namespace WarehouseManagement.Forms
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.eEmployeeListbox = new System.Windows.Forms.GroupBox();
            this.eGridView = new System.Windows.Forms.DataGridView();
            this.eAddinBox = new System.Windows.Forms.GroupBox();
            this.eDepartmentCombo = new System.Windows.Forms.ComboBox();
            this.ePositionCombo = new System.Windows.Forms.ComboBox();
            this.eSurnameBox = new System.Windows.Forms.TextBox();
            this.eSubmit = new System.Windows.Forms.Button();
            this.eNameBox = new System.Windows.Forms.TextBox();
            this.eDepartmentLabel = new System.Windows.Forms.Label();
            this.eSurnameLabel = new System.Windows.Forms.Label();
            this.ePositionLabel = new System.Windows.Forms.Label();
            this.eNameLabel = new System.Windows.Forms.Label();
            this.DeleteEmployeeBox = new System.Windows.Forms.GroupBox();
            this.eDeleteSelected = new System.Windows.Forms.Button();
            this.eRefreshBox = new System.Windows.Forms.GroupBox();
            this.eRefreshButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.eExit = new System.Windows.Forms.Button();
            this.eEmployeeListbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eGridView)).BeginInit();
            this.eAddinBox.SuspendLayout();
            this.DeleteEmployeeBox.SuspendLayout();
            this.eRefreshBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // eEmployeeListbox
            // 
            this.eEmployeeListbox.Controls.Add(this.eGridView);
            this.eEmployeeListbox.Location = new System.Drawing.Point(0, 1);
            this.eEmployeeListbox.Name = "eEmployeeListbox";
            this.eEmployeeListbox.Size = new System.Drawing.Size(1019, 360);
            this.eEmployeeListbox.TabIndex = 3;
            this.eEmployeeListbox.TabStop = false;
            this.eEmployeeListbox.Text = "Lista Pracowników";
            // 
            // eGridView
            // 
            this.eGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eGridView.Location = new System.Drawing.Point(0, 30);
            this.eGridView.Name = "eGridView";
            this.eGridView.Size = new System.Drawing.Size(1019, 300);
            this.eGridView.TabIndex = 0;
            // 
            // eAddinBox
            // 
            this.eAddinBox.Controls.Add(this.eDepartmentCombo);
            this.eAddinBox.Controls.Add(this.ePositionCombo);
            this.eAddinBox.Controls.Add(this.eSurnameBox);
            this.eAddinBox.Controls.Add(this.eSubmit);
            this.eAddinBox.Controls.Add(this.eNameBox);
            this.eAddinBox.Controls.Add(this.eDepartmentLabel);
            this.eAddinBox.Controls.Add(this.eSurnameLabel);
            this.eAddinBox.Controls.Add(this.ePositionLabel);
            this.eAddinBox.Controls.Add(this.eNameLabel);
            this.eAddinBox.Location = new System.Drawing.Point(12, 381);
            this.eAddinBox.Name = "eAddinBox";
            this.eAddinBox.Size = new System.Drawing.Size(389, 284);
            this.eAddinBox.TabIndex = 4;
            this.eAddinBox.TabStop = false;
            this.eAddinBox.Text = "Dodaj Pracownika";
            // 
            // eDepartmentCombo
            // 
            this.eDepartmentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eDepartmentCombo.FormattingEnabled = true;
            this.eDepartmentCombo.Location = new System.Drawing.Point(212, 168);
            this.eDepartmentCombo.Name = "eDepartmentCombo";
            this.eDepartmentCombo.Size = new System.Drawing.Size(164, 31);
            this.eDepartmentCombo.TabIndex = 15;
            // 
            // ePositionCombo
            // 
            this.ePositionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ePositionCombo.FormattingEnabled = true;
            this.ePositionCombo.Location = new System.Drawing.Point(212, 124);
            this.ePositionCombo.Name = "ePositionCombo";
            this.ePositionCombo.Size = new System.Drawing.Size(164, 31);
            this.ePositionCombo.TabIndex = 14;
            // 
            // eSurnameBox
            // 
            this.eSurnameBox.Location = new System.Drawing.Point(212, 80);
            this.eSurnameBox.Name = "eSurnameBox";
            this.eSurnameBox.Size = new System.Drawing.Size(164, 31);
            this.eSurnameBox.TabIndex = 13;
            // 
            // eSubmit
            // 
            this.eSubmit.BackColor = System.Drawing.Color.SpringGreen;
            this.eSubmit.Location = new System.Drawing.Point(271, 245);
            this.eSubmit.Name = "eSubmit";
            this.eSubmit.Size = new System.Drawing.Size(105, 32);
            this.eSubmit.TabIndex = 12;
            this.eSubmit.Text = "Dodaj!";
            this.eSubmit.UseVisualStyleBackColor = false;
            this.eSubmit.Click += new System.EventHandler(this.eSubmit_Click);
            // 
            // eNameBox
            // 
            this.eNameBox.Location = new System.Drawing.Point(212, 35);
            this.eNameBox.Name = "eNameBox";
            this.eNameBox.Size = new System.Drawing.Size(164, 31);
            this.eNameBox.TabIndex = 6;
            // 
            // eDepartmentLabel
            // 
            this.eDepartmentLabel.AutoSize = true;
            this.eDepartmentLabel.Location = new System.Drawing.Point(12, 176);
            this.eDepartmentLabel.Name = "eDepartmentLabel";
            this.eDepartmentLabel.Size = new System.Drawing.Size(61, 23);
            this.eDepartmentLabel.TabIndex = 3;
            this.eDepartmentLabel.Text = "Dział:";
            // 
            // eSurnameLabel
            // 
            this.eSurnameLabel.AutoSize = true;
            this.eSurnameLabel.Location = new System.Drawing.Point(12, 88);
            this.eSurnameLabel.Name = "eSurnameLabel";
            this.eSurnameLabel.Size = new System.Drawing.Size(102, 23);
            this.eSurnameLabel.TabIndex = 2;
            this.eSurnameLabel.Text = "Nazwisko:";
            // 
            // ePositionLabel
            // 
            this.ePositionLabel.AutoSize = true;
            this.ePositionLabel.Location = new System.Drawing.Point(12, 132);
            this.ePositionLabel.Name = "ePositionLabel";
            this.ePositionLabel.Size = new System.Drawing.Size(85, 23);
            this.ePositionLabel.TabIndex = 1;
            this.ePositionLabel.Text = "Posada:";
            // 
            // eNameLabel
            // 
            this.eNameLabel.AutoSize = true;
            this.eNameLabel.Location = new System.Drawing.Point(12, 43);
            this.eNameLabel.Name = "eNameLabel";
            this.eNameLabel.Size = new System.Drawing.Size(55, 23);
            this.eNameLabel.TabIndex = 0;
            this.eNameLabel.Text = "Imie:";
            // 
            // DeleteEmployeeBox
            // 
            this.DeleteEmployeeBox.Controls.Add(this.eDeleteSelected);
            this.DeleteEmployeeBox.Location = new System.Drawing.Point(424, 381);
            this.DeleteEmployeeBox.Name = "DeleteEmployeeBox";
            this.DeleteEmployeeBox.Size = new System.Drawing.Size(324, 119);
            this.DeleteEmployeeBox.TabIndex = 5;
            this.DeleteEmployeeBox.TabStop = false;
            this.DeleteEmployeeBox.Text = "Usuń zaznaczonego pracownika";
            // 
            // eDeleteSelected
            // 
            this.eDeleteSelected.BackColor = System.Drawing.Color.Tomato;
            this.eDeleteSelected.Location = new System.Drawing.Point(101, 43);
            this.eDeleteSelected.Name = "eDeleteSelected";
            this.eDeleteSelected.Size = new System.Drawing.Size(122, 44);
            this.eDeleteSelected.TabIndex = 0;
            this.eDeleteSelected.Text = "Usuń";
            this.eDeleteSelected.UseVisualStyleBackColor = false;
            this.eDeleteSelected.Click += new System.EventHandler(this.eDeleteSelected_Click);
            // 
            // eRefreshBox
            // 
            this.eRefreshBox.Controls.Add(this.eRefreshButton);
            this.eRefreshBox.Location = new System.Drawing.Point(514, 549);
            this.eRefreshBox.Name = "eRefreshBox";
            this.eRefreshBox.Size = new System.Drawing.Size(146, 101);
            this.eRefreshBox.TabIndex = 6;
            this.eRefreshBox.TabStop = false;
            this.eRefreshBox.Text = "Odśwież listę";
            // 
            // eRefreshButton
            // 
            this.eRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eRefreshButton.ForeColor = System.Drawing.Color.Transparent;
            this.eRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("eRefreshButton.Image")));
            this.eRefreshButton.Location = new System.Drawing.Point(34, 30);
            this.eRefreshButton.Name = "eRefreshButton";
            this.eRefreshButton.Size = new System.Drawing.Size(79, 59);
            this.eRefreshButton.TabIndex = 0;
            this.eRefreshButton.UseVisualStyleBackColor = true;
            this.eRefreshButton.Click += new System.EventHandler(this.eRefreshButton_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.ErrorImage = null;
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(769, 331);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(250, 389);
            this.Logo.TabIndex = 13;
            this.Logo.TabStop = false;
            // 
            // eExit
            // 
            this.eExit.BackColor = System.Drawing.Color.SpringGreen;
            this.eExit.Location = new System.Drawing.Point(636, 675);
            this.eExit.Name = "eExit";
            this.eExit.Size = new System.Drawing.Size(127, 33);
            this.eExit.TabIndex = 15;
            this.eExit.Text = "Wyjście";
            this.eExit.UseVisualStyleBackColor = false;
            this.eExit.Click += new System.EventHandler(this.eExit_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 720);
            this.Controls.Add(this.eExit);
            this.Controls.Add(this.eRefreshBox);
            this.Controls.Add(this.DeleteEmployeeBox);
            this.Controls.Add(this.eAddinBox);
            this.Controls.Add(this.eEmployeeListbox);
            this.Controls.Add(this.Logo);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.eEmployeeListbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eGridView)).EndInit();
            this.eAddinBox.ResumeLayout(false);
            this.eAddinBox.PerformLayout();
            this.DeleteEmployeeBox.ResumeLayout(false);
            this.eRefreshBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox eEmployeeListbox;
        private System.Windows.Forms.DataGridView eGridView;
        private System.Windows.Forms.GroupBox eAddinBox;
        private System.Windows.Forms.ComboBox eDepartmentCombo;
        private System.Windows.Forms.ComboBox ePositionCombo;
        private System.Windows.Forms.TextBox eSurnameBox;
        private System.Windows.Forms.Button eSubmit;
        private System.Windows.Forms.TextBox eNameBox;
        private System.Windows.Forms.Label eDepartmentLabel;
        private System.Windows.Forms.Label eSurnameLabel;
        private System.Windows.Forms.Label ePositionLabel;
        private System.Windows.Forms.Label eNameLabel;
        private System.Windows.Forms.GroupBox DeleteEmployeeBox;
        private System.Windows.Forms.Button eDeleteSelected;
        private System.Windows.Forms.GroupBox eRefreshBox;
        private System.Windows.Forms.Button eRefreshButton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button eExit;
    }
}