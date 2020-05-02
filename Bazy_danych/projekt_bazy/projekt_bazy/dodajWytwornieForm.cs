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
   
        public dodajWytwornieForm ()
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


                databaseConnection.Close(); InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void buttonDodajWytwornie_Click(object sender, EventArgs e)
        {
            
            bazaDanych bd = new bazaDanych();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Wytwornia`( `nazwa`, `kraj`) VALUES (@nazwa,@kraj)", bd.getConnection());
            command.Parameters.Add("@nazwa", MySqlDbType.VarChar).Value = wytworniaTextBox.Text;
            command.Parameters.Add("@kraj", MySqlDbType.VarChar).Value = krajTextBox.Text;

            bd.openConn();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Wytwórnia została dodana!");
            }
            
            bd.closeConn();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dodajWytwornieForm_Load(object sender, EventArgs e)
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

        private void wytworniaTextBox_Enter(object sender, EventArgs e)
        {
            String nazwa = wytworniaTextBox.Text;
            if (nazwa.Equals("Wytwórnia"))
            {
                wytworniaTextBox.Text = "";
                wytworniaTextBox.ForeColor = Color.Black;
            }
        }

        private void wytworniaTextBox_Leave(object sender, EventArgs e)
        {
            String nazwa = wytworniaTextBox.Text;
            if (nazwa.Equals(""))
            {
                wytworniaTextBox.Text = "Wytwórnia";
                wytworniaTextBox.ForeColor = Color.Gray;
            }
        }

        private void krajTextBox_Enter(object sender, EventArgs e)
        {
            String kraj = wytworniaTextBox.Text;
            if (kraj.Equals("Kraj"))
            {
                krajTextBox.Text = "";
                krajTextBox.ForeColor = Color.Black;
            }
        }

        private void krajTextBox_Leave(object sender, EventArgs e)
        {
            String kraj = wytworniaTextBox.Text;
            if (kraj.Equals(""))
            {
                krajTextBox.Text = "Kraj";
                krajTextBox.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            zalogowanoAdminForm adminForm = new zalogowanoAdminForm();
            adminForm.Show();
        }
    }

}
