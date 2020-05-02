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
            this.krajTextBox = new System.Windows.Forms.TextBox();
            this.wytworniaTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.closeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDodajWytwornie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kraj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.krajTextBox);
            this.panel1.Controls.Add(this.wytworniaTextBox);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonDodajWytwornie);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 695);
            this.panel1.TabIndex = 0;
            // 
            // krajTextBox
            // 
            this.krajTextBox.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.krajTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.krajTextBox.Location = new System.Drawing.Point(523, 299);
            this.krajTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.krajTextBox.Multiline = true;
            this.krajTextBox.Name = "krajTextBox";
            this.krajTextBox.Size = new System.Drawing.Size(333, 61);
            this.krajTextBox.TabIndex = 33;
            this.krajTextBox.Text = "Kraj";
            this.krajTextBox.Enter += new System.EventHandler(this.krajTextBox_Enter);
            this.krajTextBox.Leave += new System.EventHandler(this.krajTextBox_Leave);
            // 
            // wytworniaTextBox
            // 
            this.wytworniaTextBox.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wytworniaTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.wytworniaTextBox.Location = new System.Drawing.Point(523, 186);
            this.wytworniaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.wytworniaTextBox.Multiline = true;
            this.wytworniaTextBox.Name = "wytworniaTextBox";
            this.wytworniaTextBox.Size = new System.Drawing.Size(333, 61);
            this.wytworniaTextBox.TabIndex = 32;
            this.wytworniaTextBox.Text = "Wytwórnia";
            this.wytworniaTextBox.Enter += new System.EventHandler(this.wytworniaTextBox_Enter);
            this.wytworniaTextBox.Leave += new System.EventHandler(this.wytworniaTextBox_Leave);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.nazwa,
            this.kraj});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(51, 137);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(390, 512);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.Location = new System.Drawing.Point(848, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 42);
            this.closeButton.TabIndex = 29;
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
            this.button1.Location = new System.Drawing.Point(523, 559);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 62);
            this.button1.TabIndex = 28;
            this.button1.Text = "POWRÓT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDodajWytwornie
            // 
            this.buttonDodajWytwornie.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDodajWytwornie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajWytwornie.FlatAppearance.BorderSize = 0;
            this.buttonDodajWytwornie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajWytwornie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajWytwornie.Location = new System.Drawing.Point(523, 437);
            this.buttonDodajWytwornie.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodajWytwornie.Name = "buttonDodajWytwornie";
            this.buttonDodajWytwornie.Size = new System.Drawing.Size(333, 62);
            this.buttonDodajWytwornie.TabIndex = 27;
            this.buttonDodajWytwornie.Text = "DODAJ";
            this.buttonDodajWytwornie.UseVisualStyleBackColor = false;
            this.buttonDodajWytwornie.Click += new System.EventHandler(this.buttonDodajWytwornie_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(887, 119);
            this.label1.TabIndex = 31;
            this.label1.Text = "Dodawanie Wytwórni";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // nazwa
            // 
            this.nazwa.Text = "nazwa";
            this.nazwa.Width = 159;
            // 
            // kraj
            // 
            this.kraj.Text = "kraj";
            this.kraj.Width = 135;
            // 
            // dodajWytwornieForm
            // 
            this.ClientSize = new System.Drawing.Size(887, 695);
            this.Controls.Add(this.panel1);
            this.Name = "dodajWytwornieForm";
            this.Load += new System.EventHandler(this.dodajWytwornieForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDodajWytwornie;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox krajTextBox;
        private System.Windows.Forms.TextBox wytworniaTextBox;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader nazwa;
        private System.Windows.Forms.ColumnHeader kraj;
    }
}