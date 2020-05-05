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

        private void buttonDodajWytwornie_Click(object sender, EventArgs e)
        {
            bazaDanych bd = new bazaDanych();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Wytwornia`( `nazwa`, `kraj`) VALUES (@nazwa,@kraj)", bd.getConnection());
            command.Parameters.Add("@nazwa", MySqlDbType.VarChar).Value = wytworniaTextBox.Text;
            command.Parameters.Add("@kraj", MySqlDbType.VarChar).Value = krajTextBox.Text;

            bd.openConn();
            if (!fieldsIsEmpty())
            {

                if (!wytworniaExist())
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Udało się dodać wytwórnie filmową!");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
                else
                {
                    MessageBox.Show("Taka wytwórnia już istnieje");

                }
            }
            else
            {
                MessageBox.Show("Najpierw podaj wszystkie dane!");
            }
            bd.closeConn();
        }

        private void wytworniaTextBox_Enter(object sender, EventArgs e)
        {
            String wytwornia = wytworniaTextBox.Text;
            if (wytwornia.Equals("Wytwórnia"))
            {
                wytworniaTextBox.Text = "";
                wytworniaTextBox.ForeColor = Color.Black;
            }
        }

        private void wytworniaTextBox_Leave(object sender, EventArgs e)
        {
            String wytwornia = wytworniaTextBox.Text;
            if (wytwornia.Equals(""))
            {
                wytworniaTextBox.Text = "Wytwórnia";
                wytworniaTextBox.ForeColor = Color.Gray;
            }
        }

        private void krajTextBox_Enter(object sender, EventArgs e)
        {
            String kraj = krajTextBox.Text;
            if (kraj.Equals("Kraj"))
            {
                krajTextBox.Text = "";
                krajTextBox.ForeColor = Color.Black;
            }
        }

        private void krajTextBox_Leave(object sender, EventArgs e)
        {
            String kraj = krajTextBox.Text;
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
        public Boolean wytworniaExist()
        {
            bazaDanych bd = new bazaDanych();
            String wytwornia = wytworniaTextBox.Text;
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Wytwornia` WHERE `nazwa` = @wytwornia", bd.getConnection());
            command.Parameters.Add("@wytwornia", MySqlDbType.VarChar).Value = wytwornia;
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
            String wytwornia = wytworniaTextBox.Text;
            if (wytwornia.Equals("Wytwornia"))
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
