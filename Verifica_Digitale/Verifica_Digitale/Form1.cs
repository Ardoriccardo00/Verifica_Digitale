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
    }
}
