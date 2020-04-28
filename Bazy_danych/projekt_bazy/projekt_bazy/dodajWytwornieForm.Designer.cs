namespace projekt_bazy
{
    partial class dodajWytwornieForm
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
            this.close = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDodajWytwórnie = new System.Windows.Forms.Button();
            this.textBoxWytwornia = new System.Windows.Forms.TextBox();
            this.textBoxKraj = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonDodajWytwórnie);
            this.panel1.Controls.Add(this.textBoxWytwornia);
            this.panel1.Controls.Add(this.textBoxKraj);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 696);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(792, 0);
            this.close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 29);
            this.close.TabIndex = 29;
            this.close.Text = "X";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(410, 573);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 62);
            this.button1.TabIndex = 28;
            this.button1.Text = "POWRÓT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.close_Click);
            // 
            // buttonDodajWytwórnie
            // 
            this.buttonDodajWytwórnie.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDodajWytwórnie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajWytwórnie.FlatAppearance.BorderSize = 0;
            this.buttonDodajWytwórnie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajWytwórnie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajWytwórnie.Location = new System.Drawing.Point(409, 449);
            this.buttonDodajWytwórnie.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodajWytwórnie.Name = "buttonDodajWytwórnie";
            this.buttonDodajWytwórnie.Size = new System.Drawing.Size(333, 62);
            this.buttonDodajWytwórnie.TabIndex = 27;
            this.buttonDodajWytwórnie.Text = "DODAJ";
            this.buttonDodajWytwórnie.UseVisualStyleBackColor = false;
            this.buttonDodajWytwórnie.Click += new System.EventHandler(this.buttonDodajWytwórnie_Click);
            // 
            // textBoxWytwornia
            // 
            this.textBoxWytwornia.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWytwornia.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxWytwornia.Location = new System.Drawing.Point(410, 189);
            this.textBoxWytwornia.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWytwornia.Multiline = true;
            this.textBoxWytwornia.Name = "textBoxWytwornia";
            this.textBoxWytwornia.Size = new System.Drawing.Size(332, 61);
            this.textBoxWytwornia.TabIndex = 26;
            this.textBoxWytwornia.Text = "Wytwórnia";
            // 
            // textBoxKraj
            // 
            this.textBoxKraj.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKraj.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxKraj.Location = new System.Drawing.Point(410, 314);
            this.textBoxKraj.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKraj.Multiline = true;
            this.textBoxKraj.Name = "textBoxKraj";
            this.textBoxKraj.Size = new System.Drawing.Size(332, 61);
            this.textBoxKraj.TabIndex = 25;
            this.textBoxKraj.Text = "Kraj";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(329, 504);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(825, 129);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodawanie Wytwórni";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dodajWytwornieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(821, 692);
            this.Controls.Add(this.panel1);
            this.Name = "dodajWytwornieForm";
            this.Text = "dodajWytwórnie";
            this.Load += new System.EventHandler(this.dodajWytwornie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBoxWytwornia;
        private System.Windows.Forms.TextBox textBoxKraj;
        private System.Windows.Forms.Button buttonDodajWytwórnie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label close;
    }
}