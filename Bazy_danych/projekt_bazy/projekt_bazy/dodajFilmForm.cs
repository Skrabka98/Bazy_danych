using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projekt_bazy
{
    public partial class dodajFilmForm : Form
    {
        public dodajFilmForm()
        {
            InitializeComponent();
            InitializeComponent();
            string connectionString = "datasource=hosting2043243.online.pro;port=3306;username=00344320_wypozyczalnia;password=ramziuch12;database=00344320_wypozyczalnia";
            string query = "SELECT * FROM Film";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();



                while (reader.Read())
                {

                    string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);


                }


                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dodajFilmForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void buttonDodajAktora_Click(object sender, EventArgs e)
        {
            bazaDanych bd = new bazaDanych();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Film`( `tytul`,`premiera`,`zdjecie`opis_filmu) VALUES (@tytul,@premiera,@zdjecie,@opis_filmu)", bd.getConnection());
            command.Parameters.Add("@tytul", MySqlDbType.VarChar).Value = tytulTextBox.Text;
            command.Parameters.Add("@premiera", MySqlDbType.VarChar).Value = premieraTextBox.Text;
            command.Parameters.Add("@zdjecie", MySqlDbType.VarBinary).Value = pictureBox1.Image;
            command.Parameters.Add("@opis_filmu", MySqlDbType.Text).Value = opisTextBox.Text;


            bd.openConn();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Gatunek filmu został dodany");
            }

            bd.closeConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            zalogowanoAdminForm adminForm = new zalogowanoAdminForm();
            adminForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void tytulTextBox_Enter(object sender, EventArgs e)
        {
            String tytul = tytulTextBox.Text;
            if (tytul.Equals("Tytuł"))
            {
                tytulTextBox.Text = "";
                tytulTextBox.ForeColor = Color.Black;
            }
        }

        private void tytulTextBox_Leave(object sender, EventArgs e)
        {
            String tytul = tytulTextBox.Text;
            if (tytul.Equals(""))
            {
                tytulTextBox.Text = "Tytuł";
                tytulTextBox.ForeColor = Color.Gray;
            }
        }

        private void premieraTextBox_Enter(object sender, EventArgs e)
        {
            String premiera = premieraTextBox.Text;
            if (premiera.Equals("Premiera"))
            {
                tytulTextBox.Text = "";
                tytulTextBox.ForeColor = Color.Gray;
            }
        }

        private void premieraTextBox_Leave(object sender, EventArgs e)
        {
            String premiera = premieraTextBox.Text;
            if (premiera.Equals(""))
            {
                tytulTextBox.Text = "Premiera";
                tytulTextBox.ForeColor = Color.Gray;
            }
        }

        private void opisTextBox_Enter(object sender, EventArgs e)
        {
            String opis = opisTextBox.Text;
            if (opis.Equals("Opis"))
            {
                tytulTextBox.Text = "";
                tytulTextBox.ForeColor = Color.Gray;
            }
        }

        private void opisTextBox_Leave(object sender, EventArgs e)
        {
            String opis = opisTextBox.Text;
            if (opis.Equals(""))
            {
                tytulTextBox.Text = "Opis";
                tytulTextBox.ForeColor = Color.Gray;
            }
        }
    }
}
