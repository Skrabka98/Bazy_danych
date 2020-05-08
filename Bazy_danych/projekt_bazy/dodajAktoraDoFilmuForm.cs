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
    public partial class dodajAktoraDoFilmuForm : Form
    {
        public dodajAktoraDoFilmuForm()
        {
            InitializeComponent();
            string connectionString = "datasource=hosting2043243.online.pro;port=3306;username=00344320_wypozyczalnia;password=ramziuch12;database=00344320_wypozyczalnia";
            string aktor = "SELECT * FROM Aktor";
            string film = "SELECT * FROM Film";
            try
            {


                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(aktor, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();



                while (reader.Read())
                {

                    string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2) };

                    ListViewItem item = new ListViewItem(row);
                    listView2.Items.Add(item);
                    checkedListBox1.Items.Add(reader.GetString("id_aktora"));


                }


                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(film, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader; databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();



                while (reader.Read())
                {



                    comboBox1.Items.Add(reader.GetString("tytul"));

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
            String film = comboBox1.Text.ToString();
            String xxx ;
            bazaDanych bd = new bazaDanych();
            bd.openConn();
            try
            {

                if (film != "")
                {
                    DataTable filmTable = new DataTable();

                    MySqlDataAdapter adapterFilm = new MySqlDataAdapter();
                    MySqlCommand commandFilm = new MySqlCommand("SELECT * FROM `Film` WHERE `tytul` = @film", bd.getConnection());
                    commandFilm.Parameters.Add("@film", MySqlDbType.VarChar).Value = film;
                    adapterFilm.SelectCommand = commandFilm;
                    adapterFilm.Fill(filmTable);
                    var filmId = filmTable.Rows[0]["id_filmu"].ToString();




                    if (filmTable.Rows.Count > 0)
                    {
                        if (checkedListBox1.CheckedItems.Count > 0)
                        {
                            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                            {

                                xxx = checkedListBox1.CheckedItems[i].ToString();
                                MySqlCommand command = new MySqlCommand("INSERT INTO `Obsada` (`Id_obsady`,`id_aktor`,`id_film` ) VALUES (NULL,@id_aktor,@id_film)", bd.getConnection());
                                command.Parameters.Add("@id_aktor", MySqlDbType.VarChar).Value = xxx;
                                command.Parameters.Add("@id_film", MySqlDbType.VarChar).Value = filmId;

                                if (command.ExecuteNonQuery() == 1)
                                {
                                    
                                }
                            }





                        }
                        MessageBox.Show("Dodano aktorów");
                        bd.closeConn();
                    }
                }
                else
                {
                    MessageBox.Show("Wybierz film");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            dodajFilmForm filmForm = new dodajFilmForm();
            filmForm.Show();
        }
    }
}
