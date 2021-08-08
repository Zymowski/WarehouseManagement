namespace WarehouseManagement
{
    partial class Login
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.lusernamebox = new System.Windows.Forms.TextBox();
            this.lpasswordBox = new System.Windows.Forms.TextBox();
            this.loginsubmit = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoginSection = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.LoginSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.SpringGreen;
            this.Username.Location = new System.Drawing.Point(10, 44);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(216, 25);
            this.Username.TabIndex = 1;
            this.Username.Text = "Nazwa użytkownika";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.SpringGreen;
            this.Password.Location = new System.Drawing.Point(10, 139);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 25);
            this.Password.TabIndex = 2;
            this.Password.Text = "Hasło";
            // 
            // lusernamebox
            // 
            this.lusernamebox.BackColor = System.Drawing.Color.White;
            this.lusernamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lusernamebox.Location = new System.Drawing.Point(8, 84);
            this.lusernamebox.Name = "lusernamebox";
            this.lusernamebox.Size = new System.Drawing.Size(242, 33);
            this.lusernamebox.TabIndex = 3;
            // 
            // lpasswordBox
            // 
            this.lpasswordBox.Location = new System.Drawing.Point(6, 179);
            this.lpasswordBox.Name = "lpasswordBox";
            this.lpasswordBox.PasswordChar = '*';
            this.lpasswordBox.Size = new System.Drawing.Size(244, 33);
            this.lpasswordBox.TabIndex = 4;
            this.lpasswordBox.UseSystemPasswordChar = true;
            // 
            // loginsubmit
            // 
            this.loginsubmit.BackColor = System.Drawing.Color.SpringGreen;
            this.loginsubmit.Location = new System.Drawing.Point(8, 261);
            this.loginsubmit.Name = "loginsubmit";
            this.loginsubmit.Size = new System.Drawing.Size(275, 48);
            this.loginsubmit.TabIndex = 5;
            this.loginsubmit.Text = "Zaloguj";
            this.loginsubmit.UseVisualStyleBackColor = false;
            this.loginsubmit.Click += new System.EventHandler(this.loginsubmit_Click);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.ErrorImage = null;
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(-2, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(349, 561);
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginSection
            // 
            this.LoginSection.Controls.Add(this.Username);
            this.LoginSection.Controls.Add(this.lusernamebox);
            this.LoginSection.Controls.Add(this.Password);
            this.LoginSection.Controls.Add(this.loginsubmit);
            this.LoginSection.Controls.Add(this.lpasswordBox);
            this.LoginSection.Location = new System.Drawing.Point(421, 106);
            this.LoginSection.Name = "LoginSection";
            this.LoginSection.Size = new System.Drawing.Size(305, 350);
            this.LoginSection.TabIndex = 8;
            this.LoginSection.TabStop = false;
            this.LoginSection.Text = "Logowanie";
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(756, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(16, 18);
            this.Exit.TabIndex = 9;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LoginSection);
            this.Controls.Add(this.Logo);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.LoginSection.ResumeLayout(false);
            this.LoginSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox lusernamebox;
        private System.Windows.Forms.TextBox lpasswordBox;
        private System.Windows.Forms.Button loginsubmit;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox LoginSection;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Exit;
    }
}

