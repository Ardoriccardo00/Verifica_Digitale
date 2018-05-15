using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_Digitale
{
    public partial class Login : Form
    {
        public static string Studente;
        string stud;
        string password;
        public Login()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
        }

        private void colomboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studente = "C://Users/Riccardo/Documents/TestVerifica/Risultati.txt";
            stud = "Colombo";
            password = "SteamedHamsForWhat";

            Accesso.Visible = true;
            Password.Visible = true;

        }



        private void altroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 p = new Form1();
            Studente = "C://Users/Riccardo/Desktop/Risultati.txt";
            p.Show();
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            Studente = "Admin";
            a.Show();
            //this.Hide();
        }







        private void selezionaUnoStudenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Accesso_Click(object sender, EventArgs e)
        {
            if (stud == "Colombo")
            {
                if (Password.Text == password) { MessageBox.Show("Benvenuto"); Form1 p = new Form1(); p.Show(); this.Hide(); }
                else { MessageBox.Show("Dati Errati"); }
            }
            }

        private void colomboToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Studente = "S:/4B06/Risultati Colombo.txt";
            stud = "Colombo";
            password = "test";

            Accesso.Visible = true;
            Password.Visible = true;
            Password.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Accesso.Focus(); Accesso.PerformClick(); }
        }
    }
    }

