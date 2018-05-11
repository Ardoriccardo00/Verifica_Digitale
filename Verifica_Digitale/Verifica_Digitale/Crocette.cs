using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verifica_Digitale
{
    public partial class Crocette : Form
    {

        string[] Ldomande = new string[4];
        string[] Lrisposte = new string[16];
        string[] Lvero = new string[16];

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

            if (checkBox1.Checked == true) { if (Lvero[0] == "s") Punti1 = Punti1 + 1; else if (Lvero[0] == "n") { Punti1 = Punti1 + 0; } }
            if (checkBox2.Checked == true) { if (Lvero[1] == "s") Punti1 = Punti1 + 1; else { Punti1 = Punti1 + 0; } }
            if (checkBox3.Checked == true) { if (Lvero[2] == "s") Punti1 = Punti1 + 1; else { Punti1 = Punti1 + 0; } }
            if (checkBox4.Checked == true) { if (Lvero[3] == "s") Punti1 = Punti1 + 1; else { Punti1 = Punti1 + 0; } }

            if (checkBox5.Checked == true) { if (Lvero[4] == "s") Punti2 = Punti2 + 1; else { Punti2 = Punti2 + 0; } }
            if (checkBox6.Checked == true) { if (Lvero[5] == "s") Punti2 = Punti2 + 1; else { Punti2 = Punti2 + 0; } }
            if (checkBox7.Checked == true) { if (Lvero[6] == "s") Punti2 = Punti2 + 1; else { Punti2 = Punti2 + 0; } }
            if (checkBox8.Checked == true) { if (Lvero[7] == "s") Punti2 = Punti2 + 1; else { Punti2 = Punti2 + 0; } }

            if (checkBox9.Checked == true) { if (Lvero[8] == "s") Punti3 = Punti3 + 1; else { Punti3 = Punti3 + 0; } }
            if (checkBox10.Checked == true) { if (Lvero[9] == "s") Punti3 = Punti3 + 1; else { Punti3 = Punti3 + 0; } }
            if (checkBox11.Checked == true) { if (Lvero[10] == "s") Punti3 = Punti3 + 1; else { Punti3 = Punti3 + 0; } }
            if (checkBox12.Checked == true) { if (Lvero[11] == "s") Punti3 = Punti3 + 1; else { Punti3 = Punti3 + 0; } }

            if (checkBox13.Checked == true) { if (Lvero[12] == "s") Punti4 = Punti4 + 1; else { Punti4 = Punti4 + 0; } }
            if (checkBox14.Checked == true) { if (Lvero[13] == "s") Punti4 = Punti4 + 1; else { Punti4 = Punti4 + 0; } }
            if (checkBox15.Checked == true) { if (Lvero[14] == "s") Punti4 = Punti4 + 1; else { Punti4 = Punti4 + 0; } }
            if (checkBox16.Checked == true) { if (Lvero[15] == "s") Punti4 = Punti4 + 1; else { Punti4 = Punti4 + 0; } }

            PuntiTotali = Punti1 + Punti2 + Punti3 + Punti4;
            PassaPuntiCrocette = PuntiTotali;

            MessageBox.Show(Convert.ToString(Punti1 + Punti2 + Punti3 + Punti4), messaggio);
        }

        private void Crocette_Load(object sender, EventArgs e)
        {
            StreamReader SR = new StreamReader("C://Users/Riccardo/Documents/TestVerifica/Crocette.txt");
            for (int i = 0; i < 4; i++)
            {

                Ldomande[i] = SR.ReadLine();

            }

            for (int i = 0; i < 16; i++)
            {

                Lrisposte[i] = SR.ReadLine();

            }

            for (int i = 0; i < 16; i++)
            {

                Lvero[i] = SR.ReadLine();

            }

            SR.Close();

            label1.Text = Ldomande[0];
            label2.Text = Ldomande[1];
            label3.Text = Ldomande[2];
            label4.Text = Ldomande[3];
            checkBox1.Text = Lrisposte[0];
            checkBox2.Text = Lrisposte[1];
            checkBox3.Text = Lrisposte[2];
            checkBox4.Text = Lrisposte[3];
            checkBox5.Text = Lrisposte[4];
            checkBox6.Text = Lrisposte[5];
            checkBox7.Text = Lrisposte[6];
            checkBox8.Text = Lrisposte[7];
            checkBox9.Text = Lrisposte[8];
            checkBox10.Text = Lrisposte[9];
            checkBox11.Text = Lrisposte[10];
            checkBox12.Text = Lrisposte[11];
            checkBox13.Text = Lrisposte[12];
            checkBox14.Text = Lrisposte[13];
            checkBox15.Text = Lrisposte[14];
            checkBox16.Text = Lrisposte[15];

            this.KeyPreview = true;
        }

        private void Crocette_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { button1.Focus(); button1.PerformClick(); }
        }
    }
}
