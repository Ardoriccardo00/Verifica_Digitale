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
    public partial class SceltaMultipla : System.Windows.Forms.Form
    {
        public static string domanda1;
        public static string domanda2;
        public static string domanda3;
        public static string domanda4;
        public static string risposta11;
        public static string risposta21;
        public static string risposta31;
        public static string risposta41;
        public static string risposta12;
        public static string risposta22;
        public static string risposta32;
        public static string risposta42;
        public static string risposta13;
        public static string risposta23;
        public static string risposta33;
        public static string risposta43;
        public static string risposta14;
        public static string risposta24;
        public static string risposta34;
        public static string risposta44;

        public static bool bdomanda1;
        public static bool bdomanda2;
        public static bool bdomanda3;
        public static bool bdomanda4;
        public static bool brisposta11;
        public static bool brisposta21;
        public static bool brisposta31;
        public static bool brisposta41;
        public static bool brisposta12;
        public static bool brisposta22;
        public static bool brisposta32;
        public static bool brisposta42;
        public static bool brisposta13;
        public static bool brisposta23;
        public static bool brisposta33;
        public static bool brisposta43;
        public static bool brisposta14;
        public static bool brisposta24;
        public static bool brisposta34;
        public static bool brisposta44;
        
        public static int PassaPuntiMultipla;
        int Punti1;
        int Punti2;
        int Punti3;
        int Punti4;
        int PuntiTotali;
        string messaggio = "I punti sono: ";
        public SceltaMultipla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Punti1 = 0;
            Punti2 = 0;
            Punti3 = 0;
            Punti4 = 0;

            if      (checkBox1.Checked == true)  { if (brisposta11 == true) Punti1 = Punti1 + 1; else { Punti1 = Punti1 + 0; } }
            if      (checkBox2.Checked == true) { if (brisposta21 == true) Punti1 = Punti1 + 1; else { Punti1 = Punti1 + 0; } }
            if      (checkBox3.Checked == true) { if (brisposta31 == true) Punti1 = Punti1 + 1; else { Punti1 = Punti1 + 0; } }
            if      (checkBox4.Checked == true) { if (brisposta41 == true) Punti1 = Punti1 + 1; else { Punti1 = Punti1 + 0; } }

            if      (checkBox5.Checked == true) { if (brisposta12 == true) Punti2 = Punti2 + 1; else { Punti2 = Punti2 + 0; } }
            if      (checkBox6.Checked == true) { if (brisposta22 == true) Punti2 = Punti2 + 1; else { Punti2 = Punti2 + 0; } }
            if      (checkBox7.Checked == true) { if (brisposta32 == true) Punti2 = Punti2 + 1; else { Punti2 = Punti2 + 0; } }
            if      (checkBox8.Checked == true) { if (brisposta42 == true) Punti2 = Punti2 + 1; else { Punti2 = Punti2 + 0; } }

            if      (checkBox9.Checked == true) { if (brisposta13 == true) Punti3 = Punti3 + 1; else { Punti3 = Punti3 + 0; } }
            if      (checkBox10.Checked == true) { if (brisposta23 == true) Punti3 = Punti3 + 1; else { Punti3 = Punti3 + 0; } }
            if      (checkBox11.Checked == true) { if (brisposta33 == true) Punti3 = Punti3 + 1; else { Punti3 = Punti3 + 0; } }
            if      (checkBox12.Checked == true) { if (brisposta43 == true) Punti3 = Punti3 + 1; else { Punti3 = Punti3 + 0; } }

            if      (checkBox13.Checked == true) { if (brisposta14 == true) Punti4 = Punti4 + 1; else { Punti4 = Punti4 + 0; } }
            if      (checkBox14.Checked == true) { if (brisposta24 == true) Punti4 = Punti4 + 1; else { Punti4 = Punti4 + 0; } }
            if      (checkBox15.Checked == true) { if (brisposta34 == true) Punti4 = Punti4 + 1; else { Punti4 = Punti4 + 0; } }
            if      (checkBox16.Checked == true) { if (brisposta44 == true) Punti4 = Punti4 + 1; else { Punti4 = Punti4 + 0; } }

            PuntiTotali = Punti1 + Punti2 + Punti3 + Punti4;
            PassaPuntiMultipla = PuntiTotali;

            MessageBox.Show(Convert.ToString(PuntiTotali), messaggio);

            //else if (checkBox1.Checked == false)  { Punti1 = Punti1 + 0; }
        }

        private void SceltaMultipla_Load(object sender, EventArgs e)
        {
            Domanda1.Text = domanda1;
            Domanda2.Text = domanda2;
            Domanda3.Text = domanda3;
            Domanda4.Text = domanda4;
            checkBox1.Text = risposta11;
            checkBox1.Text = risposta21;
            checkBox1.Text = risposta31;
            checkBox1.Text = risposta41;
            checkBox1.Text = risposta12;
            checkBox1.Text = risposta22;
            checkBox1.Text = risposta32;
            checkBox1.Text = risposta42;
            checkBox1.Text = risposta13;
            checkBox1.Text = risposta23;
            checkBox1.Text = risposta33;
            checkBox1.Text = risposta43;
            checkBox1.Text = risposta14;
            checkBox1.Text = risposta24; 
            checkBox1.Text = risposta34;
            checkBox1.Text = risposta44;
        }
    }
}
