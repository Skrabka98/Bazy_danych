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
    public partial class loginForm : Form
    {
       public loginForm()
        {
            InitializeComponent();
            this.textBoxHaslo.AutoSize = false;
            this.textBoxHaslo.Size = new Size(this.textBoxHaslo.Width, 64);
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            bazaDanych bd = new bazaDanych();
            String login = textBoxLogin.Text;
            String haslo = textBoxHaslo.Text;
            
            String uprawnienia;
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Uzytkownik` WHERE `login` = @log and `haslo` = @haslo", bd.getConnection());
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@haslo", MySqlDbType.VarChar).Value = haslo;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
               
            }
            else
                if (login.Trim().Equals(""))
            {
                MessageBox.Show("Podaj login");
            }
           else if (haslo.Trim().Equals(""))
            {
                MessageBox.Show("Podaj haslo");
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło");
            }
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.Show();
        }

        private void createAccount_MouseEnter(object sender, EventArgs e)
        {
            createAccount.ForeColor = Color.White;
        }

        private void createAccount_MouseLeave(object sender, EventArgs e)
        {
            createAccount.ForeColor = Color.Black;
        }
    }
}
