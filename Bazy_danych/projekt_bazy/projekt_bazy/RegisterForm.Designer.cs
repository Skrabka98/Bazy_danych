namespace projekt_bazy
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.goToLoginLabel = new System.Windows.Forms.Label();
            this.textBoxPowHaslo = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.buttonZarejestruj = new System.Windows.Forms.Button();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.labelRejestracja = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.goToLoginLabel);
            this.panel1.Controls.Add(this.textBoxPowHaslo);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.textBoxMail);
            this.panel1.Controls.Add(this.textBoxNazwisko);
            this.panel1.Controls.Add(this.buttonZarejestruj);
            this.panel1.Controls.Add(this.textBoxHaslo);
            this.panel1.Controls.Add(this.textBoxImie);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 804);
            this.panel1.TabIndex = 1;
            // 
            // goToLoginLabel
            // 
            this.goToLoginLabel.AutoSize = true;
            this.goToLoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToLoginLabel.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.goToLoginLabel.Location = new System.Drawing.Point(715, 773);
            this.goToLoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goToLoginLabel.Name = "goToLoginLabel";
            this.goToLoginLabel.Size = new System.Drawing.Size(143, 16);
            this.goToLoginLabel.TabIndex = 21;
            this.goToLoginLabel.Text = "Posiadam już konto";
            this.goToLoginLabel.Click += new System.EventHandler(this.goToLoginLabel_Click);
            this.goToLoginLabel.MouseEnter += new System.EventHandler(this.goToLoginLabel_MouseEnter);
            this.goToLoginLabel.MouseLeave += new System.EventHandler(this.goToLoginLabel_MouseLeave);
            // 
            // textBoxPowHaslo
            // 
            this.textBoxPowHaslo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPowHaslo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPowHaslo.Location = new System.Drawing.Point(131, 569);
            this.textBoxPowHaslo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPowHaslo.Name = "textBoxPowHaslo";
            this.textBoxPowHaslo.Size = new System.Drawing.Size(695, 58);
            this.textBoxPowHaslo.TabIndex = 9;
            this.textBoxPowHaslo.Text = "Powtórz hasło";
            this.textBoxPowHaslo.Enter += new System.EventHandler(this.textBoxPowHaslo_Enter);
            this.textBoxPowHaslo.Leave += new System.EventHandler(this.textBoxPowHaslo_Leave);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxLogin.Location = new System.Drawing.Point(131, 367);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(695, 61);
            this.textBoxLogin.TabIndex = 8;
            this.textBoxLogin.Text = "Login";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxMail.Location = new System.Drawing.Point(131, 265);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMail.Multiline = true;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(695, 61);
            this.textBoxMail.TabIndex = 7;
            this.textBoxMail.Text = "Email";
            this.textBoxMail.Enter += new System.EventHandler(this.textBoxMail_Enter);
            this.textBoxMail.Leave += new System.EventHandler(this.textBoxMail_Leave);
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNazwisko.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxNazwisko.Location = new System.Drawing.Point(493, 167);
            this.textBoxNazwisko.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNazwisko.Multiline = true;
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(332, 61);
            this.textBoxNazwisko.TabIndex = 6;
            this.textBoxNazwisko.Text = "Nazwisko";
            this.textBoxNazwisko.Enter += new System.EventHandler(this.textBoxNazwisko_Enter);
            this.textBoxNazwisko.Leave += new System.EventHandler(this.textBoxNazwisko_Leave);
            // 
            // buttonZarejestruj
            // 
            this.buttonZarejestruj.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonZarejestruj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZarejestruj.FlatAppearance.BorderSize = 0;
            this.buttonZarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZarejestruj.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZarejestruj.Location = new System.Drawing.Point(176, 658);
            this.buttonZarejestruj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZarejestruj.Name = "buttonZarejestruj";
            this.buttonZarejestruj.Size = new System.Drawing.Size(587, 82);
            this.buttonZarejestruj.TabIndex = 5;
            this.buttonZarejestruj.Text = "ZAREJESTRUJ";
            this.buttonZarejestruj.UseVisualStyleBackColor = false;
            this.buttonZarejestruj.Click += new System.EventHandler(this.buttonZarejestruj_Click);
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxHaslo.Location = new System.Drawing.Point(131, 464);
            this.textBoxHaslo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(695, 58);
            this.textBoxHaslo.TabIndex = 4;
            this.textBoxHaslo.Text = "Hasło";
            this.textBoxHaslo.Enter += new System.EventHandler(this.textBoxHaslo_Enter);
            this.textBoxHaslo.Leave += new System.EventHandler(this.textBoxHaslo_Leave);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxImie.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxImie.Location = new System.Drawing.Point(131, 167);
            this.textBoxImie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxImie.Multiline = true;
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(332, 61);
            this.textBoxImie.TabIndex = 20;
            this.textBoxImie.Text = "Imie";
            this.textBoxImie.Enter += new System.EventHandler(this.textBoxImie_Enter);
            this.textBoxImie.Leave += new System.EventHandler(this.textBoxImie_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.labelRejestracja);
            this.panel2.Location = new System.Drawing.Point(-17, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 123);
            this.panel2.TabIndex = 0;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(988, 0);
            this.close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 29);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // labelRejestracja
            // 
            this.labelRejestracja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRejestracja.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRejestracja.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelRejestracja.Location = new System.Drawing.Point(0, 0);
            this.labelRejestracja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRejestracja.Name = "labelRejestracja";
            this.labelRejestracja.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelRejestracja.Size = new System.Drawing.Size(1035, 123);
            this.labelRejestracja.TabIndex = 0;
            this.labelRejestracja.Text = "Rejestracja";
            this.labelRejestracja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRejestracja.Click += new System.EventHandler(this.labelRejestracja_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 804);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonZarejestruj;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label labelRejestracja;
        private System.Windows.Forms.TextBox textBoxPowHaslo;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label goToLoginLabel;
    }
}