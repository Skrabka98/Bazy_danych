﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_bazy
{
    public partial class zalogowanoAdminForm : Form
    {
        public zalogowanoAdminForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonZarejestruj_Click(object sender, EventArgs e)
        {
            this.Close();
            dodajAktoraForm aktor = new dodajAktoraForm();
            aktor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            dodajGatunekForm gatunek = new dodajGatunekForm();
            gatunek.Show();
        }

        private void dodajWytwornie_Click(object sender, EventArgs e)
        {
            this.Close();
            dodajWytwornieForm wytwornia = new dodajWytwornieForm();
            wytwornia.Show();
        }

        private void dodajFilm_Click(object sender, EventArgs e)
        {
            this.Close();
            dodajFilmForm film = new dodajFilmForm();
            film.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm login = new loginForm();
            login.Show();
        }
    }
}
