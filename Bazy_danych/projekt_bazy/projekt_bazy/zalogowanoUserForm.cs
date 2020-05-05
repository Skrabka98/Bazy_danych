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

        private void buttonRezerwacja_Click(object sender, EventArgs e)
        {
            /*if (listView1.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = listView1.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                String text = listView1.Items[intselectedindex].Text;
                var id = int.Parse(text);
                Console.WriteLine(id);
                if (id>=0)
                {
                    bazaDanych bd = new bazaDanych();
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM `Film` WHERE `id_filmu` = @id ", bd.getConnection());
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                    var xxx = dataTable.Rows[0]["opis_filmu"].ToString();
                    label3.Text = xxx;
                }



            }*/




        }
    }
}
