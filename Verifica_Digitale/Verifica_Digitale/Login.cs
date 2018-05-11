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
        public Login()
        {
            InitializeComponent();
        }

        private void colomboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 p = new Form1();
            Studente = "C://Users/Riccardo/Documents/Risultati.txt";
            p.Show();
            //this.Hide();
        }



        private void altroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 p = new Form1();
            Studente = "C://Users/Riccardo/Desktop/Risultati.txt";
            p.Show();
            //this.Hide();
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
    }
}
