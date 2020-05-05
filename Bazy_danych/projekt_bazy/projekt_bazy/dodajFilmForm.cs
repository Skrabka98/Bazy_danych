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
            bazaDanych bd = new bazaDanych();
            InitializeComponent();
            string connectionString = "datasource=hosting2043243.online.pro;port=3306;username=00344320_wypozyczalnia;password=ramziuch12;database=00344320_wypozyczalnia";
            string query = "SELECT * FROM Film";
            string gatunki = "SELECT * FROM Gatunek_filmu";
            string wytwornia = "SELECT * FROM Wytwornia";
            string aktor = "SELECT * FROM Aktor";




            try
            {
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();



                while (reader.Read())
                {

                    string[] row = {reader.GetString(0), reader.GetString(1)};

                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);


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
                MySqlCommand commandDatabase = new MySqlCommand(gatunki, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader; databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();



                while (reader.Read())
                {

                  

                    comboBox1.Items.Add(reader.GetString("gatunek"));


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
                MySqlCommand commandDatabase = new MySqlCommand(wytwornia, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader; databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();



                while (reader.Read())
                {



                    comboBox2.Items.Add(reader.GetString("nazwa"));


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
        }


        

        private void buttonDodajAktora_Click(object sender, EventArgs e)
        {
            String gatunek1 = comboBox1.Text.ToString();
            String wytwornia1 = comboBox2.Text.ToString();
            try
            {
                bazaDanych bd = new bazaDanych();
                bd.openConn();
                DataTable gatunekTable = new DataTable();
                MySqlDataAdapter adapterGatunek = new MySqlDataAdapter();
                MySqlCommand commandGatunek = new MySqlCommand("SELECT * FROM `Gatunek_filmu` WHERE `gatunek` = @gatunek", bd.getConnection());
                commandGatunek.Parameters.Add("@gatunek", MySqlDbType.VarChar).Value = gatunek1;
                adapterGatunek.SelectCommand = commandGatunek;
                adapterGatunek.Fill(gatunekTable);
                var gat = gatunekTable.Rows[0]["Id_gatunku"].ToString();

                if (gatunekTable.Rows.Count > 0)
                {
                    DataTable wytworniaTable = new DataTable();
                    MySqlDataAdapter adapterWytwornia = new MySqlDataAdapter();
                    MySqlCommand commandWytwornia = new MySqlCommand("SELECT `id_wytworni` FROM `Wytwornia` WHERE `nazwa` = @wytwornia", bd.getConnection());
                    commandWytwornia.Parameters.Add("@wytwornia", MySqlDbType.VarChar).Value = wytwornia1;
                    adapterWytwornia.SelectCommand = commandWytwornia;
                    adapterWytwornia.Fill(wytworniaTable);
                    var wytw = wytworniaTable.Rows[0]["id_wytworni"].ToString();
                    if (wytworniaTable.Rows.Count > 0)
                    {
                        MySqlCommand command = new MySqlCommand("INSERT INTO `Film`( `tytul`, `premiera`, `Id_gatunek`, `id_wytwornia`, `opis_filmu`) VALUES (@tytul,@premiera,@gat,@wyt,@opis_filmu)", bd.getConnection());
                        command.Parameters.Add("@tytul", MySqlDbType.VarChar).Value = tytulTextBox.Text;
                        command.Parameters.Add("@premiera", MySqlDbType.VarChar).Value = premieraTextBox.Text;
                        command.Parameters.Add("@opis_filmu", MySqlDbType.Text).Value = opisTextBox.Text;
                        command.Parameters.Add("@gat", MySqlDbType.VarChar).Value = gat;
                        command.Parameters.Add("@wyt", MySqlDbType.VarChar).Value = wytw;




                        if (command.ExecuteNonQuery() == 1)
                        {
                            
                            MessageBox.Show("Filmu został dodany");
                        }

                       
                    }
                    bd.closeConn();

                }
                else MessageBox.Show("xxx");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (premiera.Equals("Data premiery"))
            {
                premieraTextBox.Text = "";
                premieraTextBox.ForeColor = Color.Gray;
            }
        }

        private void premieraTextBox_Leave(object sender, EventArgs e)
        {
            String premiera = premieraTextBox.Text;
            if (premiera.Equals(""))
            {
                premieraTextBox.Text = "Data premiery";
                premieraTextBox.ForeColor = Color.Gray;
            }
        }

        private void opisTextBox_Enter(object sender, EventArgs e)
        {
            String opis = opisTextBox.Text;
            if (opis.Equals("Opis"))
            {
                opisTextBox.Text = "";
                opisTextBox.ForeColor = Color.Gray;
            }
        }

        private void opisTextBox_Leave(object sender, EventArgs e)
        {
       
                String opis = opisTextBox.Text;
                if (opis.Equals(""))
                {
                    opisTextBox.Text = "Opis";
                    opisTextBox.ForeColor = Color.Gray;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            zalogowanoAdminForm adminForm = new zalogowanoAdminForm();
            adminForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bazaDanych bd = new bazaDanych();
            string str = "";
                            if (checkedListBox1.CheckedItems.Count > 0)
                            {
                                for (int i = 0; i< checkedListBox1.CheckedItems.Count; i++)
                                {
                                    if(str == "")
                                    {
                                        str = checkedListBox1.CheckedItems[i].ToString();
                                    }
                                    else
                                    {
                                        str+="," + checkedListBox1.CheckedItems[i].ToString();
                                    }
                                }
                 try{               MySqlCommand command = new MySqlCommand("INSERT INTO `Obsada`('id_aktor','id_film' ) VALUES (@idA,@idF)", bd.getConnection());
                command.Parameters.Add("@idA", MySqlDbType.VarChar).Value = str;
                command.Parameters.Add("@idF", MySqlDbType.VarChar).Value = 1;
                bd.openConn();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Dodano");
                }
                  
                else MessageBox.Show("Nie dodano");
                    }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                bd.closeConn();

            }
        }
    }
}
