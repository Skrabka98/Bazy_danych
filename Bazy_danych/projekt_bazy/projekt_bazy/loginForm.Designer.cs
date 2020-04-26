namespace projekt_bazy
{
    partial class loginForm
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
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createAccount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.createAccount);
            this.panel1.Controls.Add(this.buttonZaloguj);
            this.panel1.Controls.Add(this.textBoxHaslo);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 442);
            this.panel1.TabIndex = 0;
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonZaloguj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZaloguj.FlatAppearance.BorderSize = 0;
            this.buttonZaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZaloguj.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZaloguj.Location = new System.Drawing.Point(34, 340);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(440, 67);
            this.buttonZaloguj.TabIndex = 5;
            this.buttonZaloguj.Text = "ZALOGUJ";
            this.buttonZaloguj.UseVisualStyleBackColor = false;
            this.buttonZaloguj.Click += new System.EventHandler(this.buttonZaloguj_Click);
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.Location = new System.Drawing.Point(104, 247);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(370, 50);
            this.textBoxHaslo.TabIndex = 4;
            this.textBoxHaslo.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projekt_bazy.Properties.Resources.pngwave;
            this.pictureBox2.Location = new System.Drawing.Point(34, 247);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(104, 161);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(370, 64);
            this.textBoxLogin.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projekt_bazy.Properties.Resources.iconfinder_user_alt_285645;
            this.pictureBox1.Location = new System.Drawing.Point(34, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 100);
            this.panel2.TabIndex = 0;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(485, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 22);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logowanie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createAccount
            // 
            this.createAccount.AutoSize = true;
            this.createAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccount.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createAccount.Location = new System.Drawing.Point(403, 419);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(71, 14);
            this.createAccount.TabIndex = 6;
            this.createAccount.Text = "Załóż konto";
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            this.createAccount.MouseEnter += new System.EventHandler(this.createAccount_MouseEnter);
            this.createAccount.MouseLeave += new System.EventHandler(this.createAccount_MouseLeave);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 442);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.Label createAccount;
    }
}