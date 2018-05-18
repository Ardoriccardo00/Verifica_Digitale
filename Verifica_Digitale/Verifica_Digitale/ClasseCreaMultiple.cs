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
    public partial class ClasseCreaMultiple : Form
    {
        int numeroDomande;
        int Barra;
        string nomeDomanda;
        
        public ClasseCreaMultiple()
        {
            InitializeComponent();
        }

        private void inserisciNumero_Click(object sender, EventArgs e)
        {
            numeroDomande = Convert.ToInt32(testoNumeroDomande.Text);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Barra = trackBar1.Value;
        }

        private void ClasseCreaMultiple_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = numeroDomande;
            trackBar1.TickStyle = TickStyle.BottomRight;
            trackBar1.TickFrequency = 1;
        }

        private void inserisciNomeDomanda_Click(object sender, EventArgs e)
        {
            
        }

        private void inserisciRisposte_Click(object sender, EventArgs e)
        {
            string[] Risposte = { risp1.Text, risp2.Text, risp3.Text, risp4.Text };
            Domanda d = new Domanda(testoNomeDomanda.Text,Risposte);
        }
    }
}
