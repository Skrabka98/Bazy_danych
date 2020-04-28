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
    public partial class dodajWytwornieForm : Form
    {
        public dodajWytwornieForm()
        {
            InitializeComponent();
            string connectionString = "datasource=hosting2043243.online.pro;port=3306;username=00344320_wypozyczalnia;password=ramziuch12;database=00344320_wypozyczalnia";
            string query = "SELECT * FROM Wytwornia";

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

                    string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2) };
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

        private void buttonDodajWytwórnie_Click(object sender, EventArgs e)
        {
            bazaDanych bd = new bazaDanych();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Wytwornia`( `nazwa`, `kraj`) VALUES (@nazwa, @kraj)", bd.getConnection());
            command.Parameters.Add("@nazwa", MySqlDbType.VarChar).Value = textBoxWytwornia.Text;
            command.Parameters.Add("@kraj", MySqlDbType.VarChar).Value = textBoxKraj.Text;

            bd.openConn();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Wytwórnia została dodana");
            }

            bd.closeConn();
        }
        private void dodajWytwornie_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }
        private void textBoxWytwornia_Enter(object sender, EventArgs e)
        {
            String gatunek = textBoxWytwornia.Text;
            if (gatunek.Equals("Wytwornia"))
            {
                textBoxWytwornia.Text = "";
                textBoxWytwornia.ForeColor = Color.Black;
            }
        }

        private void textBoxWytwornia_Leave(object sender, EventArgs e)
        {
            String gatunek = textBoxWytwornia.Text;
            if (gatunek.Equals(""))
            {
                textBoxWytwornia.Text = "Wytwornia";
                textBoxWytwornia.ForeColor = Color.Gray;
            }
        }
        private void textBoxKraj_Enter(object sender, EventArgs e)
        {
            String gatunek = textBoxWytwornia.Text;
            if (gatunek.Equals("Kraj"))
            {
                textBoxKraj.Text = "";
                textBoxKraj.ForeColor = Color.Black;
            }
        }

        private void textBoxKraj_Leave(object sender, EventArgs e)
        {
            String gatunek = textBoxWytwornia.Text;
            if (gatunek.Equals(""))
            {
                textBoxKraj.Text = "Kraj";
                textBoxKraj.ForeColor = Color.Gray;
            }
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            zalogowanoAdminForm adminForm = new zalogowanoAdminForm();
            adminForm.Show();
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
