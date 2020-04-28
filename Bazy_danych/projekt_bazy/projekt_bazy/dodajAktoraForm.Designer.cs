namespace projekt_bazy
{
    partial class dodajAktoraForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDodajAktora = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxMiejsceUr = new System.Windows.Forms.TextBox();
            this.textBoxDataUro = new System.Windows.Forms.TextBox();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonDodajAktora);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.textBoxMiejsceUr);
            this.panel1.Controls.Add(this.textBoxDataUro);
            this.panel1.Controls.Add(this.textBoxWiek);
            this.panel1.Controls.Add(this.imieTextBox);
            this.panel1.Controls.Add(this.textBoxNazwisko);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 802);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(404, 711);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 62);
            this.button1.TabIndex = 28;
            this.button1.Text = "POWRÓT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDodajAktora
            // 
            this.buttonDodajAktora.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDodajAktora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajAktora.FlatAppearance.BorderSize = 0;
            this.buttonDodajAktora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajAktora.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajAktora.Location = new System.Drawing.Point(404, 619);
            this.buttonDodajAktora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDodajAktora.Name = "buttonDodajAktora";
            this.buttonDodajAktora.Size = new System.Drawing.Size(333, 62);
            this.buttonDodajAktora.TabIndex = 26;
            this.buttonDodajAktora.Text = "DODAJ";
            this.buttonDodajAktora.UseVisualStyleBackColor = false;
            this.buttonDodajAktora.Click += new System.EventHandler(this.buttonDodajAktora_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Imie,
            this.Nazwisko});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(41, 151);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(320, 621);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Imie
            // 
            this.Imie.Text = "Imie";
            this.Imie.Width = 109;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.Width = 130;
            // 
            // textBoxMiejsceUr
            // 
            this.textBoxMiejsceUr.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMiejsceUr.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxMiejsceUr.Location = new System.Drawing.Point(404, 528);
            this.textBoxMiejsceUr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMiejsceUr.Multiline = true;
            this.textBoxMiejsceUr.Name = "textBoxMiejsceUr";
            this.textBoxMiejsceUr.Size = new System.Drawing.Size(332, 61);
            this.textBoxMiejsceUr.TabIndex = 24;
            this.textBoxMiejsceUr.Text = "Miejsce uro";
            this.textBoxMiejsceUr.Enter += new System.EventHandler(this.textBoxMiejsceUr_Enter);
            this.textBoxMiejsceUr.Leave += new System.EventHandler(this.textBoxMiejsceUr_Leave);
            // 
            // textBoxDataUro
            // 
            this.textBoxDataUro.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDataUro.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxDataUro.Location = new System.Drawing.Point(404, 430);
            this.textBoxDataUro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDataUro.Multiline = true;
            this.textBoxDataUro.Name = "textBoxDataUro";
            this.textBoxDataUro.Size = new System.Drawing.Size(332, 61);
            this.textBoxDataUro.TabIndex = 23;
            this.textBoxDataUro.Text = "Data uro";
            this.textBoxDataUro.Enter += new System.EventHandler(this.textBoxDataUro_Enter);
            this.textBoxDataUro.Leave += new System.EventHandler(this.textBoxDataUro_Leave);
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWiek.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxWiek.Location = new System.Drawing.Point(404, 335);
            this.textBoxWiek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWiek.Multiline = true;
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(332, 61);
            this.textBoxWiek.TabIndex = 22;
            this.textBoxWiek.Text = "Wiek";
            this.textBoxWiek.Enter += new System.EventHandler(this.textBoxWiek_Enter);
            this.textBoxWiek.Leave += new System.EventHandler(this.textBoxWiek_Leave);
            // 
            // imieTextBox
            // 
            this.imieTextBox.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imieTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.imieTextBox.Location = new System.Drawing.Point(404, 151);
            this.imieTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imieTextBox.Multiline = true;
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(332, 61);
            this.imieTextBox.TabIndex = 21;
            this.imieTextBox.Text = "Imie";
            this.imieTextBox.Enter += new System.EventHandler(this.imieTextBox_Enter);
            this.imieTextBox.Leave += new System.EventHandler(this.imieTextBox_Leave);
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNazwisko.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxNazwisko.Location = new System.Drawing.Point(404, 244);
            this.textBoxNazwisko.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNazwisko.Multiline = true;
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(332, 61);
            this.textBoxNazwisko.TabIndex = 21;
            this.textBoxNazwisko.Text = "Nazwisko";
            this.textBoxNazwisko.Enter += new System.EventHandler(this.textBoxNazwisko_Enter);
            this.textBoxNazwisko.Leave += new System.EventHandler(this.textBoxNazwisko_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 123);
            this.panel2.TabIndex = 0;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(804, 0);
            this.close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 29);
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
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(840, 123);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodawanie aktora";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dodajAktoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 802);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "dodajAktoraForm";
            this.Text = "Dodaj aktora";
            this.Load += new System.EventHandler(this.dodajAktoraForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Imie;
        private System.Windows.Forms.ColumnHeader Nazwisko;
        private System.Windows.Forms.TextBox textBoxMiejsceUr;
        private System.Windows.Forms.TextBox textBoxDataUro;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Button buttonDodajAktora;
        private System.Windows.Forms.Button button1;
    }
}