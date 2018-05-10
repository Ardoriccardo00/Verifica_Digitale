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
        string Risposta1 = "giusta";
        string Risposta2 = "giusta";
        string Risposta3 = "risposta";
        string Risposta4 = "sbagliata";

        

        int Punti;
        public static int PassaPunti;

        public Completamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Punti = 0;

                 if (testo1.Text == Risposta1) { Punti = Punti + 1; }
            else if (testo1.Text != Risposta1) { Punti = Punti + 0; }

                 if (testo2.Text == Risposta2) { Punti = Punti + 1; }
            else if (testo2.Text != Risposta2) { Punti = Punti + 0; }

                 if (testo3.Text == Risposta3) { Punti = Punti + 1; }
            else if (testo3.Text != Risposta3) { Punti = Punti + 0; }
            

            if (testo4.Text == Risposta4) { Punti = Punti + 1; }
            else if (testo4.Text != Risposta4) { Punti = Punti + 0; }

            PassaPunti = Punti;

            MessageBox.Show(Convert.ToString(Punti));
        }
    }
}
