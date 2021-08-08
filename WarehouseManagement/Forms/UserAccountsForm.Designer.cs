namespace WarehouseManagement.Forms
{
    partial class UserAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAcc));
            this.aAccountsListbox = new System.Windows.Forms.GroupBox();
            this.aGridView = new System.Windows.Forms.DataGridView();
            this.aAddinBox = new System.Windows.Forms.GroupBox();
            this.aEmplCombo = new System.Windows.Forms.ComboBox();
            this.aPrevilCombo = new System.Windows.Forms.ComboBox();
            this.aPasswordBox = new System.Windows.Forms.TextBox();
            this.aSubmit = new System.Windows.Forms.Button();
            this.aUsernameBox = new System.Windows.Forms.TextBox();
            this.aIDEmployeeLabel = new System.Windows.Forms.Label();
            this.aPasswordLabel = new System.Windows.Forms.Label();
            this.aIDRoleLabel = new System.Windows.Forms.Label();
            this.aUsernameLabel = new System.Windows.Forms.Label();
            this.aDeleteBox = new System.Windows.Forms.GroupBox();
            this.aDeleteSelected = new System.Windows.Forms.Button();
            this.aChangeBox = new System.Windows.Forms.GroupBox();
            this.aChgPwdLabel = new System.Windows.Forms.Label();
            this.aChngPwdBox = new System.Windows.Forms.TextBox();
            this.aSubmitChg = new System.Windows.Forms.Button();
            this.aRefreshBox = new System.Windows.Forms.GroupBox();
            this.aRefreshButton = new System.Windows.Forms.Button();
            this.uExit = new System.Windows.Forms.Button();
            this.aAccountsListbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aGridView)).BeginInit();
            this.aAddinBox.SuspendLayout();
            this.aDeleteBox.SuspendLayout();
            this.aChangeBox.SuspendLayout();
            this.aRefreshBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // aAccountsListbox
            // 
            this.aAccountsListbox.Controls.Add(this.aGridView);
            this.aAccountsListbox.Location = new System.Drawing.Point(0, 0);
            this.aAccountsListbox.Name = "aAccountsListbox";
            this.aAccountsListbox.Size = new System.Drawing.Size(1019, 360);
            this.aAccountsListbox.TabIndex = 4;
            this.aAccountsListbox.TabStop = false;
            this.aAccountsListbox.Text = "Konta Użytkowników";
            // 
            // aGridView
            // 
            this.aGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aGridView.Location = new System.Drawing.Point(0, 30);
            this.aGridView.Name = "aGridView";
            this.aGridView.Size = new System.Drawing.Size(1019, 300);
            this.aGridView.TabIndex = 0;
            // 
            // aAddinBox
            // 
            this.aAddinBox.Controls.Add(this.aEmplCombo);
            this.aAddinBox.Controls.Add(this.aPrevilCombo);
            this.aAddinBox.Controls.Add(this.aPasswordBox);
            this.aAddinBox.Controls.Add(this.aSubmit);
            this.aAddinBox.Controls.Add(this.aUsernameBox);
            this.aAddinBox.Controls.Add(this.aIDEmployeeLabel);
            this.aAddinBox.Controls.Add(this.aPasswordLabel);
            this.aAddinBox.Controls.Add(this.aIDRoleLabel);
            this.aAddinBox.Controls.Add(this.aUsernameLabel);
            this.aAddinBox.Location = new System.Drawing.Point(12, 375);
            this.aAddinBox.Name = "aAddinBox";
            this.aAddinBox.Size = new System.Drawing.Size(389, 284);
            this.aAddinBox.TabIndex = 5;
            this.aAddinBox.TabStop = false;
            this.aAddinBox.Text = "Stwórz Konto";
            // 
            // aEmplCombo
            // 
            this.aEmplCombo.FormattingEnabled = true;
            this.aEmplCombo.Location = new System.Drawing.Point(212, 168);
            this.aEmplCombo.Name = "aEmplCombo";
            this.aEmplCombo.Size = new System.Drawing.Size(164, 31);
            this.aEmplCombo.TabIndex = 15;
            // 
            // aPrevilCombo
            // 
            this.aPrevilCombo.FormattingEnabled = true;
            this.aPrevilCombo.Location = new System.Drawing.Point(212, 124);
            this.aPrevilCombo.Name = "aPrevilCombo";
            this.aPrevilCombo.Size = new System.Drawing.Size(164, 31);
            this.aPrevilCombo.TabIndex = 14;
            // 
            // aPasswordBox
            // 
            this.aPasswordBox.Location = new System.Drawing.Point(212, 80);
            this.aPasswordBox.Name = "aPasswordBox";
            this.aPasswordBox.PasswordChar = '*';
            this.aPasswordBox.Size = new System.Drawing.Size(164, 31);
            this.aPasswordBox.TabIndex = 13;
            this.aPasswordBox.UseSystemPasswordChar = true;
            // 
            // aSubmit
            // 
            this.aSubmit.BackColor = System.Drawing.Color.SpringGreen;
            this.aSubmit.Location = new System.Drawing.Point(271, 245);
            this.aSubmit.Name = "aSubmit";
            this.aSubmit.Size = new System.Drawing.Size(105, 32);
            this.aSubmit.TabIndex = 12;
            this.aSubmit.Text = "Dodaj!";
            this.aSubmit.UseVisualStyleBackColor = false;
            // 
            // aUsernameBox
            // 
            this.aUsernameBox.Location = new System.Drawing.Point(212, 35);
            this.aUsernameBox.Name = "aUsernameBox";
            this.aUsernameBox.Size = new System.Drawing.Size(164, 31);
            this.aUsernameBox.TabIndex = 6;
            // 
            // aIDEmployeeLabel
            // 
            this.aIDEmployeeLabel.AutoSize = true;
            this.aIDEmployeeLabel.Location = new System.Drawing.Point(12, 176);
            this.aIDEmployeeLabel.Name = "aIDEmployeeLabel";
            this.aIDEmployeeLabel.Size = new System.Drawing.Size(111, 23);
            this.aIDEmployeeLabel.TabIndex = 3;
            this.aIDEmployeeLabel.Text = "Pracownik:";
            // 
            // aPasswordLabel
            // 
            this.aPasswordLabel.AutoSize = true;
            this.aPasswordLabel.Location = new System.Drawing.Point(12, 88);
            this.aPasswordLabel.Name = "aPasswordLabel";
            this.aPasswordLabel.Size = new System.Drawing.Size(67, 23);
            this.aPasswordLabel.TabIndex = 2;
            this.aPasswordLabel.Text = "Hasło:";
            // 
            // aIDRoleLabel
            // 
            this.aIDRoleLabel.AutoSize = true;
            this.aIDRoleLabel.Location = new System.Drawing.Point(12, 132);
            this.aIDRoleLabel.Name = "aIDRoleLabel";
            this.aIDRoleLabel.Size = new System.Drawing.Size(106, 23);
            this.aIDRoleLabel.TabIndex = 1;
            this.aIDRoleLabel.Text = "Przywileje:";
            // 
            // aUsernameLabel
            // 
            this.aUsernameLabel.AutoSize = true;
            this.aUsernameLabel.Location = new System.Drawing.Point(12, 43);
            this.aUsernameLabel.Name = "aUsernameLabel";
            this.aUsernameLabel.Size = new System.Drawing.Size(199, 23);
            this.aUsernameLabel.TabIndex = 0;
            this.aUsernameLabel.Text = "Nazwa użytkownika:";
            // 
            // aDeleteBox
            // 
            this.aDeleteBox.Controls.Add(this.aDeleteSelected);
            this.aDeleteBox.Location = new System.Drawing.Point(424, 375);
            this.aDeleteBox.Name = "aDeleteBox";
            this.aDeleteBox.Size = new System.Drawing.Size(324, 119);
            this.aDeleteBox.TabIndex = 6;
            this.aDeleteBox.TabStop = false;
            this.aDeleteBox.Text = "Usuń zaznaczone konto";
            // 
            // aDeleteSelected
            // 
            this.aDeleteSelected.BackColor = System.Drawing.Color.Tomato;
            this.aDeleteSelected.Location = new System.Drawing.Point(101, 43);
            this.aDeleteSelected.Name = "aDeleteSelected";
            this.aDeleteSelected.Size = new System.Drawing.Size(122, 44);
            this.aDeleteSelected.TabIndex = 0;
            this.aDeleteSelected.Text = "Usuń";
            this.aDeleteSelected.UseVisualStyleBackColor = false;
            // 
            // aChangeBox
            // 
            this.aChangeBox.Controls.Add(this.aChgPwdLabel);
            this.aChangeBox.Controls.Add(this.aChngPwdBox);
            this.aChangeBox.Controls.Add(this.aSubmitChg);
            this.aChangeBox.Location = new System.Drawing.Point(424, 518);
            this.aChangeBox.Name = "aChangeBox";
            this.aChangeBox.Size = new System.Drawing.Size(324, 165);
            this.aChangeBox.TabIndex = 7;
            this.aChangeBox.TabStop = false;
            this.aChangeBox.Text = "Zmień hasło";
            // 
            // aChgPwdLabel
            // 
            this.aChgPwdLabel.AutoSize = true;
            this.aChgPwdLabel.Location = new System.Drawing.Point(27, 58);
            this.aChgPwdLabel.Name = "aChgPwdLabel";
            this.aChgPwdLabel.Size = new System.Drawing.Size(67, 23);
            this.aChgPwdLabel.TabIndex = 8;
            this.aChgPwdLabel.Text = "Hasło:";
            // 
            // aChngPwdBox
            // 
            this.aChngPwdBox.Location = new System.Drawing.Point(101, 50);
            this.aChngPwdBox.Name = "aChngPwdBox";
            this.aChngPwdBox.Size = new System.Drawing.Size(205, 31);
            this.aChngPwdBox.TabIndex = 7;
            this.aChngPwdBox.UseSystemPasswordChar = true;
            // 
            // aSubmitChg
            // 
            this.aSubmitChg.BackColor = System.Drawing.Color.SpringGreen;
            this.aSubmitChg.Location = new System.Drawing.Point(101, 102);
            this.aSubmitChg.Name = "aSubmitChg";
            this.aSubmitChg.Size = new System.Drawing.Size(131, 39);
            this.aSubmitChg.TabIndex = 0;
            this.aSubmitChg.Text = "Zmień!";
            this.aSubmitChg.UseVisualStyleBackColor = false;
            // 
            // aRefreshBox
            // 
            this.aRefreshBox.Controls.Add(this.aRefreshButton);
            this.aRefreshBox.Location = new System.Drawing.Point(810, 463);
            this.aRefreshBox.Name = "aRefreshBox";
            this.aRefreshBox.Size = new System.Drawing.Size(146, 101);
            this.aRefreshBox.TabIndex = 8;
            this.aRefreshBox.TabStop = false;
            this.aRefreshBox.Text = "Odśwież listę";
            // 
            // aRefreshButton
            // 
            this.aRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aRefreshButton.ForeColor = System.Drawing.Color.Transparent;
            this.aRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("aRefreshButton.Image")));
            this.aRefreshButton.Location = new System.Drawing.Point(34, 30);
            this.aRefreshButton.Name = "aRefreshButton";
            this.aRefreshButton.Size = new System.Drawing.Size(79, 59);
            this.aRefreshButton.TabIndex = 0;
            this.aRefreshButton.UseVisualStyleBackColor = true;
            // 
            // uExit
            // 
            this.uExit.BackColor = System.Drawing.Color.SpringGreen;
            this.uExit.Location = new System.Drawing.Point(866, 659);
            this.uExit.Name = "uExit";
            this.uExit.Size = new System.Drawing.Size(110, 35);
            this.uExit.TabIndex = 9;
            this.uExit.Text = "Wyjście";
            this.uExit.UseVisualStyleBackColor = false;
            this.uExit.Click += new System.EventHandler(this.uExit_Click);
            // 
            // UserAcc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 720);
            this.Controls.Add(this.uExit);
            this.Controls.Add(this.aRefreshBox);
            this.Controls.Add(this.aChangeBox);
            this.Controls.Add(this.aDeleteBox);
            this.Controls.Add(this.aAddinBox);
            this.Controls.Add(this.aAccountsListbox);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UserAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konta Użytkowników";
            this.aAccountsListbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aGridView)).EndInit();
            this.aAddinBox.ResumeLayout(false);
            this.aAddinBox.PerformLayout();
            this.aDeleteBox.ResumeLayout(false);
            this.aChangeBox.ResumeLayout(false);
            this.aChangeBox.PerformLayout();
            this.aRefreshBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox aAccountsListbox;
        private System.Windows.Forms.DataGridView aGridView;
        private System.Windows.Forms.GroupBox aAddinBox;
        private System.Windows.Forms.ComboBox aEmplCombo;
        private System.Windows.Forms.ComboBox aPrevilCombo;
        private System.Windows.Forms.TextBox aPasswordBox;
        private System.Windows.Forms.Button aSubmit;
        private System.Windows.Forms.TextBox aUsernameBox;
        private System.Windows.Forms.Label aIDEmployeeLabel;
        private System.Windows.Forms.Label aPasswordLabel;
        private System.Windows.Forms.Label aIDRoleLabel;
        private System.Windows.Forms.Label aUsernameLabel;
        private System.Windows.Forms.GroupBox aDeleteBox;
        private System.Windows.Forms.Button aDeleteSelected;
        private System.Windows.Forms.GroupBox aChangeBox;
        private System.Windows.Forms.Button aSubmitChg;
        private System.Windows.Forms.Label aChgPwdLabel;
        private System.Windows.Forms.TextBox aChngPwdBox;
        private System.Windows.Forms.GroupBox aRefreshBox;
        private System.Windows.Forms.Button aRefreshButton;
        private System.Windows.Forms.Button uExit;
    }
}