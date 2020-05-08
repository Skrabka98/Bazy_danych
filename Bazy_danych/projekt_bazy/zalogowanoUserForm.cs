using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projekt_bazy
{
    public partial class zalogowanoUserForm : Form
    {
        String id;
        string idFilmu = "";
        public zalogowanoUserForm(String idUser)
        {
            this.id = idUser;
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

                    string row = reader.GetString(1) ;

                    listBox1.Items.Add(row);


                }


                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonRezerwacja_Click(object sender, EventArgs e)
        {
           

        }



        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bazaDanych bd = new bazaDanych();
                bd.openConn();
                DataTable filmTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                MySqlDataAdapter adapterFilm = new MySqlDataAdapter();
                MySqlCommand commandFilm = new MySqlCommand("SELECT * FROM `Dodawanie_filmu` WHERE `tytul`= @tytul", bd.getConnection());
                commandFilm.Parameters.Add("@tytul", MySqlDbType.VarChar).Value = listBox1.SelectedItem.ToString();
                adapterFilm.SelectCommand = commandFilm;
                adapterFilm.Fill(filmTable);
                labelGatunek.Text = filmTable.Rows[0]["gatunek"].ToString();
                labelOpis.Text = filmTable.Rows[0]["opis_filmu"].ToString();
                labelTytuł.Text = filmTable.Rows[0]["tytul"].ToString();
                labelPremiera.Text = filmTable.Rows[0]["premiera"].ToString();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `Obsada_filmu` WHERE `id_film`= @id", bd.getConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = filmTable.Rows[0]["id_filmu"].ToString();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                String aktorzy = "";
                this.idFilmu = filmTable.Rows[0]["id_filmu"].ToString();

                for (int i = 0; i < table.Rows.Count; i++)

                {
                    if (aktorzy == "")
                    {
                        aktorzy += table.Rows[i]["imie"].ToString() + " " + table.Rows[i]["nazwisko"].ToString();
                    }
                    else
                    {
                        aktorzy += ", " + table.Rows[i]["imie"].ToString() + " " + table.Rows[i]["nazwisko"].ToString();
                    }
                }
                labelObsada.Text = aktorzy;


                check(int.Parse(filmTable.Rows[0]["id_filmu"].ToString()));

                bd.closeConn();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void check(int idFilmCheck)
        {
            bazaDanych bd = new bazaDanych();
            bd.openConn();
            MySqlDataAdapter adapterRezerwacja = new MySqlDataAdapter();
            DataTable tableRezerwacja = new DataTable();
            MySqlCommand commandRezerwacja = new MySqlCommand("SELECT * FROM `Wypozyczone_filmy` WHERE `id_filmu`= @idFilm", bd.getConnection());
            commandRezerwacja.Parameters.Add("@idFilm", MySqlDbType.VarChar).Value = idFilmCheck;
            adapterRezerwacja.SelectCommand = commandRezerwacja;
            adapterRezerwacja.Fill(tableRezerwacja);



            if (tableRezerwacja.Rows.Count>0)
            {
                button1.Visible = false;
                labelZarezerwowane.Text = "Ten film jest zarezerwowany";
            }
            else
            {
                button1.Visible = true;
                labelZarezerwowane.Text = "";
                
            }
            bd.closeConn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bazaDanych bd = new bazaDanych();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Wypozyczone_filmy`( `id_uzytkownika`, `id_filmu`) VALUES (@id_uzytkownika,@id_filmu)", bd.getConnection());
            command.Parameters.Add("@id_uzytkownika", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@id_filmu", MySqlDbType.VarChar).Value = idFilmu;
            bd.openConn();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Film został zarezerwowany");
                InitializeComponent();
            }
            bd.closeConn();
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
    }
}
