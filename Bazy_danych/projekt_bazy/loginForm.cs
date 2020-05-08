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
            this.ActiveControl = label1;
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

        public void buttonZaloguj_Click(object sender, EventArgs e)
        {
            bazaDanych bd = new bazaDanych();
            String login = textBoxLogin.Text;
            String haslo = textBoxHaslo.Text;
           
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Login` WHERE `login` = @log and `haslo` = @haslo", bd.getConnection());
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@haslo", MySqlDbType.VarChar).Value = haslo;
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
                


                if (dataTable.Rows.Count > 0)
                {
                var upra = dataTable.Rows[0]["uprawnienia"].ToString();
                var upraBool = bool.Parse(upra);
                var id = dataTable.Rows[0]["id_uzytkownika"].ToString();
                
              
                if (upraBool == false)
                    {
                        this.Hide();
                        zalogowanoUserForm user = new zalogowanoUserForm(id);
                        user.Show();
                    }
                    else if (upraBool == true)
                    {
                        this.Hide();
                        zalogowanoAdminForm admin = new zalogowanoAdminForm();
                        admin.Show();
                    }
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
            if (haslo.Equals(" Hasło"))
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
                textBoxHaslo.Text = " Hasło";
                textBoxHaslo.UseSystemPasswordChar = false;
                textBoxHaslo.ForeColor = Color.Gray;
            }
        }
      
        
    }
}
