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

        string Risposta1 = "giusta";
        string Risposta2 = "giusta";
        string Risposta3 = "risposta";
        string Risposta4 = "sbagliata";

        string secret = "iLoveWaffles";

        int Punti;
        public static int PassaPunti;

        public Completamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Punti = 0;

                 if (testo1.Text == risposta1) { Punti = Punti + 1; }
            else if (testo1.Text != risposta1) { Punti = Punti + 0; }

                 if (testo2.Text == risposta2) { Punti = Punti + 1; }
            else if (testo2.Text != risposta2) { Punti = Punti + 0; }

                 if (testo3.Text == risposta3) { Punti = Punti + 1; }
            else if (testo3.Text != risposta3) { Punti = Punti + 0; }
            else if (testo3.Text == secret)    { testo3.Text = "Waffles"; }

            if      (testo4.Text == risposta4) { Punti = Punti + 1; }
            else if (testo4.Text != risposta4) { Punti = Punti + 0; }

            PassaPunti = Punti;

            MessageBox.Show(Convert.ToString(Punti));
        }

        private void Completamento_Load(object sender, EventArgs e)
        {
            label1.Text = domanda1;
            label2.Text = domanda2;
            label3.Text = domanda3;
            label4.Text = domanda4;


            this.KeyPreview = true;
        }

        private void Completamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { button1.Focus(); button1.PerformClick(); }
        }
    }
}
