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
    public partial class Crocette : Form
    {
        public static int PassaPuntiCrocette;
        int Punti1;
        int Punti2;
        int Punti3;
        int Punti4;
        int PuntiTotali;
        string messaggio = "I punti sono: ";

        public Crocette()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Punti1 = 0;
            Punti2 = 0;
            Punti3 = 0;
            Punti4 = 0;
            if (checkBox1.Checked == true)  { Punti1 = Punti1 + 1; }
            if (checkBox2.Checked == true)  { Punti1 = Punti1 + 0; }
            if (checkBox3.Checked == true)  { Punti1 = Punti1 + 0; }
            if (checkBox4.Checked == true)  { Punti1 = Punti1 + 0; }

            if (checkBox5.Checked == true)  { Punti2 = Punti2 + 0; }
            if (checkBox6.Checked == true)  { Punti2 = Punti2 + 1; }
            if (checkBox7.Checked == true)  { Punti2 = Punti2 + 0; }
            if (checkBox8.Checked == true)  { Punti2 = Punti2 + 0; }

            if (checkBox9.Checked == true)  { Punti3 = Punti3 + 0; }
            if (checkBox10.Checked == true) { Punti3 = Punti3 + 0; }
            if (checkBox11.Checked == true) { Punti3 = Punti3 + 1; }
            if (checkBox12.Checked == true) { Punti3 = Punti3 + 0; }

            if (checkBox13.Checked == true) { Punti4 = Punti4 + 0; }
            if (checkBox14.Checked == true) { Punti4 = Punti4 + 0; }
            if (checkBox15.Checked == true) { Punti4 = Punti4 + 0; }
            if (checkBox16.Checked == true) { Punti4 = Punti4 + 1; }

            PuntiTotali = Punti1 + Punti2 + Punti3 + Punti4;
            PassaPuntiCrocette = PuntiTotali;

            MessageBox.Show(Convert.ToString(Punti1 + Punti2 + Punti3 + Punti4), messaggio);
        }
    }
}
