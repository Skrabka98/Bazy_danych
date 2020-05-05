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
    public partial class dodajGatunekForm : Form
    {
        public dodajGatunekForm()
        {
            InitializeComponent();
            string connectionString = "datasource=hosting2043243.online.pro;port=3306;username=00344320_wypozyczalnia;password=ramziuch12;database=00344320_wypozyczalnia";
            string query = "SELECT * FROM Gatunek_filmu";

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

                    string[] row = { reader.GetString(0), reader.GetString(1) };
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

        private void textBoxGatunek_Enter(object sender, EventArgs e)
        {
            String gatunek = textBoxGatunek.Text;
            if (gatunek.Equals("Gatunek"))
            {
                textBoxGatunek.Text = "";
                textBoxGatunek.ForeColor = Color.Black;
            }
        }

        private void textBoxGatunek_Leave(object sender, EventArgs e)
        {
            String gatunek = textBoxGatunek.Text;
            if (gatunek.Equals(""))
            {
                textBoxGatunek.Text = "Gatunek";
                textBoxGatunek.ForeColor = Color.Gray;
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

        private void buttonDodajAktora_Click(object sender, EventArgs e)
        {
            bazaDanych bd = new bazaDanych();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Gatunek_filmu`( `gatunek`) VALUES (@gatunek)", bd.getConnection());
            command.Parameters.Add("@gatunek", MySqlDbType.VarChar).Value = textBoxGatunek.Text;


            bd.openConn();
            if (!fieldsIsEmpty())
            {

                if (!gatunekExist())
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Udało się dodać gatunek filmu!");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
                else
                {
                    MessageBox.Show("Taki gatunek istnieje");

                }
            }
            else
            {
                MessageBox.Show("Najpierw podaj wszystkie dane!");
            }

            bd.closeConn();
        }

        private void dodajGatunekForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            zalogowanoAdminForm adminForm = new zalogowanoAdminForm();
            adminForm.Show();
        }
        public Boolean gatunekExist()
        {
            bazaDanych bd = new bazaDanych();
            String gatunek = textBoxGatunek.Text;
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Gatunek_filmu` WHERE `gatunek` = @gatunek", bd.getConnection());
            command.Parameters.Add("@gatunek", MySqlDbType.VarChar).Value = gatunek;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }
        public Boolean fieldsIsEmpty()
        {
            String gatunek = textBoxGatunek.Text;
            if (gatunek.Equals("Gatunek"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
