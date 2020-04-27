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
    public partial class dodajAktoraForm : Form
    {
        public dodajAktoraForm()
        {
            InitializeComponent();
            string connectionString = "datasource=hosting2043243.online.pro;port=3306;username=00344320_wypozyczalnia;password=ramziuch12;database=00344320_wypozyczalnia";
            string query = "SELECT * FROM Aktor";

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

                        string[] row = {reader.GetString(1), reader.GetString(2)};
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

        private void buttonDodajAktora_Click(object sender, EventArgs e)
        {
            bazaDanych bd = new bazaDanych();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Aktor`( `imie`, `nazwisko`, `wiek`, `data_urodzenia`, `miejsce_urodzenia`) VALUES (@imie,@nazwisko,@wiek,@data,@miejsce)", bd.getConnection());
            command.Parameters.Add("@imie", MySqlDbType.VarChar).Value = imieTextBox.Text;
            command.Parameters.Add("@nazwisko", MySqlDbType.VarChar).Value = textBoxNazwisko.Text;
            command.Parameters.Add("@wiek", MySqlDbType.VarChar).Value = textBoxWiek.Text;
            command.Parameters.Add("@data", MySqlDbType.VarChar).Value = textBoxDataUro.Text;
            command.Parameters.Add("@miejsce", MySqlDbType.VarChar).Value = textBoxMiejsceUr.Text;


            bd.openConn();
            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Aktor został dodany!");
            }

            bd.closeConn();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imieTextBox_Enter(object sender, EventArgs e)
        {
            String imie = imieTextBox.Text;
            if (imie.Equals("Imie"))
            {
                imieTextBox.Text = "";
                imieTextBox.ForeColor = Color.Black;
            }
        }

        private void imieTextBox_Leave(object sender, EventArgs e)
        {
            String imie = imieTextBox.Text;
            if (imie.Equals(""))
            {
                imieTextBox.Text = "Imie";
                imieTextBox.ForeColor = Color.Gray;
            }
        }

        private void textBoxNazwisko_Enter(object sender, EventArgs e)
        {
            String nazwisko = textBoxNazwisko.Text;
            if (nazwisko.Equals("Nazwisko"))
            {
                textBoxNazwisko.Text = "";
                textBoxNazwisko.ForeColor = Color.Black;
            }
        }

        private void textBoxNazwisko_Leave(object sender, EventArgs e)
        {
            String nazwisko = textBoxNazwisko.Text;
            if (nazwisko.Equals(""))
            {
                textBoxNazwisko.Text = "Nazwisko";
                textBoxNazwisko.ForeColor = Color.Gray;
            }
        }

        private void textBoxWiek_Enter(object sender, EventArgs e)
        {
            String wiek = textBoxWiek.Text;
            if (wiek.Equals("Wiek"))
            {
                textBoxWiek.Text = "";
                textBoxWiek.ForeColor = Color.Black;
            }
        }

        private void textBoxWiek_Leave(object sender, EventArgs e)
        {
            String wiek = textBoxWiek.Text;
            if (wiek.Equals(""))
            {
                textBoxWiek.Text = "Wiek";
                textBoxWiek.ForeColor = Color.Gray;
            }
        }

        private void dodajAktoraForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;

        }

        private void textBoxDataUro_Enter(object sender, EventArgs e)
        {
            String data = textBoxDataUro.Text;
            if (data.Equals("Data uro"))
            {
                textBoxDataUro.Text = "";
                textBoxDataUro.ForeColor = Color.Black;
            }
        }

        private void textBoxDataUro_Leave(object sender, EventArgs e)
        {
            String data = textBoxDataUro.Text;
            if (data.Equals(""))
            {
                textBoxDataUro.Text = "Data uro";
                textBoxDataUro.ForeColor = Color.Gray;
            }
        }

        private void textBoxMiejsceUr_Enter(object sender, EventArgs e)
        {
            String miejsce = textBoxMiejsceUr.Text;
            if (miejsce.Equals("Miejsce uro"))
            {
                textBoxMiejsceUr.Text = "";
                textBoxMiejsceUr.ForeColor = Color.Black;
            }
        }

        private void textBoxMiejsceUr_Leave(object sender, EventArgs e)
        {
            String miejsce = textBoxMiejsceUr.Text;
            if (miejsce.Equals(""))
            {
                textBoxMiejsceUr.Text = "Miejsce uro";
                textBoxMiejsceUr.ForeColor = Color.Gray;
            }
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            zalogowanoAdminForm adminForm = new zalogowanoAdminForm();
            adminForm.Show();
        }
    }
}
