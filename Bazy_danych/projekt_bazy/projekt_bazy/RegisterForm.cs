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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelRejestracja;
        }

        private void textBoxImie_Enter(object sender, EventArgs e)
        {
            String imie = textBoxImie.Text;
            if (imie.Equals("Imie"))
            {
                textBoxImie.Text = "";
                textBoxImie.ForeColor = Color.Black;
            }
        }

        private void textBoxImie_Leave(object sender, EventArgs e)
        {
            String imie = textBoxImie.Text;
            if (imie.Equals(""))
            {
                textBoxImie.Text = "Imie";
                textBoxImie.ForeColor = Color.Gray;
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

        private void textBoxMail_Enter(object sender, EventArgs e)
        {
            String email = textBoxMail.Text;
            if (email.Equals("Email"))
            {
                textBoxMail.Text = "";
                textBoxMail.ForeColor = Color.Black;
            }
        }

        private void textBoxMail_Leave(object sender, EventArgs e)
        {
            String email = textBoxMail.Text;
            if (email.Equals(""))
            {
                textBoxMail.Text = "Email";
                textBoxMail.ForeColor = Color.Gray;
            }
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            String login = textBoxLogin.Text;
            if (login.Equals("Login"))
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            String login = textBoxLogin.Text;
            if (login.Equals(""))
            {
                textBoxLogin.Text = "Login";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void textBoxHaslo_Enter(object sender, EventArgs e)
        {
            String haslo = textBoxHaslo.Text;
            if (haslo.Equals("Hasło"))
            {
                textBoxHaslo.Text = "";
                textBoxHaslo.UseSystemPasswordChar = true;
                textBoxHaslo.ForeColor = Color.Black;
            }
        }

        private void textBoxHaslo_Leave(object sender, EventArgs e)
        {
            String haslo = textBoxHaslo.Text;
            if (haslo.Equals(""))
            {
                textBoxHaslo.Text = "Hasło";
                textBoxHaslo.UseSystemPasswordChar = false;
                textBoxHaslo.ForeColor = Color.Gray;
            }
        }

        private void textBoxPowHaslo_Enter(object sender, EventArgs e)
        {
            String powHaslo = textBoxPowHaslo.Text;
            if (powHaslo.Equals("Powtórz hasło"))
            {
                textBoxPowHaslo.Text = "";
                textBoxPowHaslo.UseSystemPasswordChar = true;
                textBoxPowHaslo.ForeColor = Color.Black;
            }
        }

        private void textBoxPowHaslo_Leave(object sender, EventArgs e)
        {
            String powHaslo = textBoxPowHaslo.Text;
            if (powHaslo.Equals(""))
            {
                textBoxPowHaslo.Text = "Powtórz hasło";
                textBoxPowHaslo.UseSystemPasswordChar = false;
                textBoxPowHaslo.ForeColor = Color.Gray;
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

        private void buttonZarejestruj_Click(object sender, EventArgs e)
        {
            bazaDanych bd = new bazaDanych();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Uzytkownik`( `imie`, `nazwisko`, `login`, `haslo`, `email`) VALUES (@imie,@nazwisko,@login,@haslo,@email)", bd.getConnection());
            command.Parameters.Add("@imie", MySqlDbType.VarChar).Value = textBoxImie.Text;
            command.Parameters.Add("@nazwisko", MySqlDbType.VarChar).Value = textBoxNazwisko.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxLogin.Text;
            command.Parameters.Add("@haslo", MySqlDbType.VarChar).Value = textBoxHaslo.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxMail.Text;


            bd.openConn();
            if (!fieldsIsEmpty())
            {
                if (textBoxHaslo.Text.Equals(textBoxPowHaslo.Text))
                {
                    if (loginIsBusy())
                    {
                        MessageBox.Show("Login jest już zajęty");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Udało się założyć konto!");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Podane hasła nie są takie same");
                }
            }
            else
            {
                MessageBox.Show("Najpierw podaj wszystkie dane!");
            }
            bd.closeConn();
        }

        public Boolean loginIsBusy()
        {
            bazaDanych bd = new bazaDanych();
            String login = textBoxLogin.Text;
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Uzytkownik` WHERE `login` = @log", bd.getConnection());
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
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
            String imie = textBoxImie.Text;
            String nazwisko = textBoxNazwisko.Text;
            String email = textBoxMail.Text;
            String login = textBoxLogin.Text;
            String haslo = textBoxHaslo.Text;
            if (imie.Equals("Imie") || nazwisko.Equals("Nazwisko") || email.Equals("Email") || login.Equals("Login") || haslo.Equals("Hasło"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void goToLoginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void goToLoginLabel_MouseEnter(object sender, EventArgs e)
        {
            goToLoginLabel.ForeColor = Color.White;

        }

        private void goToLoginLabel_MouseLeave(object sender, EventArgs e)
        {
            goToLoginLabel.ForeColor = Color.Black;
        }

        private void labelRejestracja_Click(object sender, EventArgs e)
        {

        }
    }
}
