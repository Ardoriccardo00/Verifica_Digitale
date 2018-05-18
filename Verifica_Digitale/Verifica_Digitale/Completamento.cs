using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Verifica_Digitale
{
    public partial class Completamento : Form
    {
        public static string domanda1;
        public static string domanda2;
        public static string domanda3;
        public static string domanda4;
        public static string risposta1;
        public static string risposta2;
        public static string risposta3;
        public static string risposta4;

        string[] Ldomande = new string[4];
        string[] Lrisposte = new string[4];

        string secret = "iLoveWaffles";

        int Punti;
        public static int PassaPunti;

        public Completamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//0
            Punti = 0;

                 if (testo1.Text == Lrisposte[0]) { Punti = Punti + 1; }
            else if (testo1.Text != Lrisposte[0]) { Punti = Punti + 0; }

                 if (testo2.Text == Lrisposte[1]) { Punti = Punti + 1; }
            else if (testo2.Text != Lrisposte[1]) { Punti = Punti + 0; }

                 if (testo3.Text == Lrisposte[2]) { Punti = Punti + 1; }
            else if (testo3.Text != Lrisposte[2]) { Punti = Punti + 0; }
            else if (testo3.Text == secret)       { testo3.Text = "Waffles"; }

            if      (testo4.Text == Lrisposte[3]) { Punti = Punti + 1; }
            else if (testo4.Text != Lrisposte[3]) { Punti = Punti + 0; }

            PassaPunti = Punti;

            MessageBox.Show(Convert.ToString(Punti));
        }

        private void Completamento_Load(object sender, EventArgs e)
        {

            StreamReader SR = new StreamReader("C://Users/Riccardo/Documents/TestVerifica/Completamento.txt");

            for (int i = 0; i < 4; i++) {

                Ldomande[i] = SR.ReadLine();

            }

            for (int i = 0; i < 4; i++)
            {

                Lrisposte[i] = SR.ReadLine();

            }

            SR.Close();

            label1.Text = Ldomande[0];
            label2.Text = Ldomande[1];
            label3.Text = Ldomande[2];
            label4.Text = Ldomande[3];


            this.KeyPreview = true;
        }

        private void Completamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { button1.Focus(); button1.PerformClick(); }
        }
    }
}
