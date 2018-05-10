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
    public partial class Form1 : System.Windows.Forms.Form
    {
        int Totale;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                SceltaMultipla sm = new SceltaMultipla();
                sm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
                Crocette c = new Crocette();
                c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Completamento cc = new Completamento();
            cc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                Totale = SceltaMultipla.PassaPuntiMultipla + Crocette.PassaPuntiCrocette + Completamento.PassaPunti;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

                listBox1.Visible = true;

                listBox1.Items.Add("Scelta multipla: " + Convert.ToString(SceltaMultipla.PassaPuntiMultipla));
                listBox1.Items.Add("Crocette: " + Convert.ToString(Crocette.PassaPuntiCrocette));
                listBox1.Items.Add("Completamento: " + Convert.ToString(Completamento.PassaPunti));
                listBox1.Items.Add("");
                listBox1.Items.Add(Totale);
            
        }
    }
}
