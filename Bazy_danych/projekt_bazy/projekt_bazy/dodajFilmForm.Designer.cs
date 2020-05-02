namespace projekt_bazy
{
    partial class dodajFilmForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDodajAktora = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tytuł = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.premiera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zdjęcie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.premieraTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.tytulTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonDodajAktora);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.premieraTextBox);
            this.panel1.Controls.Add(this.opisTextBox);
            this.panel1.Controls.Add(this.tytulTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 753);
            this.panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.Location = new System.Drawing.Point(793, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(51, 43);
            this.closeButton.TabIndex = 30;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(467, 667);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 62);
            this.button1.TabIndex = 29;
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
            this.buttonDodajAktora.Location = new System.Drawing.Point(466, 580);
            this.buttonDodajAktora.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodajAktora.Name = "buttonDodajAktora";
            this.buttonDodajAktora.Size = new System.Drawing.Size(333, 62);
            this.buttonDodajAktora.TabIndex = 28;
            this.buttonDodajAktora.Text = "DODAJ";
            this.buttonDodajAktora.UseVisualStyleBackColor = false;
            this.buttonDodajAktora.Click += new System.EventHandler(this.buttonDodajAktora_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.tytuł,
            this.premiera,
            this.zdjęcie,
            this.opis});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 137);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(449, 592);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // tytuł
            // 
            this.tytuł.Text = "tytul";
            // 
            // premiera
            // 
            this.premiera.Text = "premiera";
            // 
            // zdjęcie
            // 
            this.zdjęcie.Text = "zdjecie_filmu";
            // 
            // opis
            // 
            this.opis.Text = "opis_filmu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(467, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 146);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // premieraTextBox
            // 
            this.premieraTextBox.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.premieraTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.premieraTextBox.Location = new System.Drawing.Point(468, 218);
            this.premieraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.premieraTextBox.Multiline = true;
            this.premieraTextBox.Name = "premieraTextBox";
            this.premieraTextBox.Size = new System.Drawing.Size(332, 61);
            this.premieraTextBox.TabIndex = 25;
            this.premieraTextBox.Text = "Data premiery";
            this.premieraTextBox.Enter += new System.EventHandler(this.premieraTextBox_Enter);
            this.premieraTextBox.Leave += new System.EventHandler(this.premieraTextBox_Leave);
            // 
            // opisTextBox
            // 
            this.opisTextBox.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.opisTextBox.Location = new System.Drawing.Point(467, 454);
            this.opisTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(332, 118);
            this.opisTextBox.TabIndex = 23;
            this.opisTextBox.Text = "Opis";
            this.opisTextBox.Enter += new System.EventHandler(this.opisTextBox_Enter);
            this.opisTextBox.Leave += new System.EventHandler(this.opisTextBox_Leave);
            // 
            // tytulTextBox
            // 
            this.tytulTextBox.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytulTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tytulTextBox.Location = new System.Drawing.Point(468, 137);
            this.tytulTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tytulTextBox.Multiline = true;
            this.tytulTextBox.Name = "tytulTextBox";
            this.tytulTextBox.Size = new System.Drawing.Size(332, 61);
            this.tytulTextBox.TabIndex = 22;
            this.tytulTextBox.Text = "Tytuł";
            this.tytulTextBox.Enter += new System.EventHandler(this.tytulTextBox_Enter);
            this.tytulTextBox.Leave += new System.EventHandler(this.tytulTextBox_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(844, 118);
            this.label1.TabIndex = 31;
            this.label1.Text = "Dodaj Film";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dodajFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 753);
            this.Controls.Add(this.panel1);
            this.Name = "dodajFilmForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.dodajFilmForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox premieraTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.TextBox tytulTextBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDodajAktora;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader tytuł;
        private System.Windows.Forms.ColumnHeader premiera;
        private System.Windows.Forms.ColumnHeader zdjęcie;
        private System.Windows.Forms.ColumnHeader opis;
        private System.Windows.Forms.Label label1;
    }
}