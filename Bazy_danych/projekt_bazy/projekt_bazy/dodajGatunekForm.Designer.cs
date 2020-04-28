namespace projekt_bazy
{
    partial class dodajGatunekForm
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
            this.buttonDodajGatunek = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gatunek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxGatunek = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.buttonDodajGatunek);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.textBoxGatunek);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 731);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(404, 588);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 62);
            this.button1.TabIndex = 27;
            this.button1.Text = "POWRÓT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDodajGatunek
            // 
            this.buttonDodajGatunek.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDodajGatunek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajGatunek.FlatAppearance.BorderSize = 0;
            this.buttonDodajGatunek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajGatunek.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajGatunek.Location = new System.Drawing.Point(404, 475);
            this.buttonDodajGatunek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDodajGatunek.Name = "buttonDodajGatunek";
            this.buttonDodajGatunek.Size = new System.Drawing.Size(333, 62);
            this.buttonDodajGatunek.TabIndex = 26;
            this.buttonDodajGatunek.Text = "DODAJ";
            this.buttonDodajGatunek.UseVisualStyleBackColor = false;
            this.buttonDodajGatunek.Click += new System.EventHandler(this.buttonDodajAktora_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Gatunek});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(41, 151);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(320, 533);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 53;
            // 
            // Gatunek
            // 
            this.Gatunek.Text = "Gatunek";
            this.Gatunek.Width = 183;
            // 
            // textBoxGatunek
            // 
            this.textBoxGatunek.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGatunek.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxGatunek.Location = new System.Drawing.Point(404, 278);
            this.textBoxGatunek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxGatunek.Multiline = true;
            this.textBoxGatunek.Name = "textBoxGatunek";
            this.textBoxGatunek.Size = new System.Drawing.Size(332, 61);
            this.textBoxGatunek.TabIndex = 24;
            this.textBoxGatunek.Text = "Gatunek";
            this.textBoxGatunek.Enter += new System.EventHandler(this.textBoxGatunek_Enter);
            this.textBoxGatunek.Leave += new System.EventHandler(this.textBoxGatunek_Leave);
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
            this.label1.Text = "Dodawanie gatunku ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dodajGatunekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 731);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "dodajGatunekForm";
            this.Text = "dodajGatunekForm";
            this.Load += new System.EventHandler(this.dodajGatunekForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDodajGatunek;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Gatunek;
        private System.Windows.Forms.TextBox textBoxGatunek;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}