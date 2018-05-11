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
    public partial class ModificaCrocette : Form
    {
        public static bool domanda1;
        public static bool domanda2;
        public static bool domanda3;
        public static bool domanda4;
        public static bool risposta11;
        public static bool risposta21;
        public static bool risposta31;
        public static bool risposta41;
        public static bool risposta12;
        public static bool risposta22;
        public static bool risposta32;
        public static bool risposta42;
        public static bool risposta13;
        public static bool risposta23;
        public static bool risposta33;
        public static bool risposta43;
        public static bool risposta14;
        public static bool risposta24;
        public static bool risposta34;
        public static bool risposta44;

        public ModificaCrocette()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crocette.domanda1 = Domanda1.Text;
            Crocette.domanda2 = Domanda2.Text;
            Crocette.domanda3 = Domanda3.Text;
            Crocette.domanda4 = Domanda4.Text;

            Crocette.risposta11 = Risposta1.Text;
            Crocette.risposta21 = Risposta2.Text;
            Crocette.risposta31 = Risposta3.Text;
            Crocette.risposta41 = Risposta4.Text;
            Crocette.risposta12 = Risposta12.Text;
            Crocette.risposta22 = Risposta22.Text;
            Crocette.risposta32 = Risposta32.Text;
            Crocette.risposta42 = Risposta42.Text;
            Crocette.risposta13 = Risposta13.Text;
            Crocette.risposta23 = Risposta23.Text;
            Crocette.risposta33 = Risposta33.Text;
            Crocette.risposta43 = Risposta43.Text;
            Crocette.risposta14 = Risposta14.Text;
            Crocette.risposta24 = Risposta24.Text;
            Crocette.risposta34 = Risposta34.Text;
            Crocette.risposta44 = Risposta44.Text;



            if (checkBox2.Checked == true) { Crocette.brisposta11 = true; }
            if (checkBox3.Checked == true) { Crocette.brisposta21 = true; }
            if (checkBox4.Checked == true) { Crocette.brisposta31 = true; }
            if (checkBox5.Checked == true) { Crocette.brisposta41 = true; }
            if (checkBox7.Checked == true) { Crocette.brisposta12 = true; }
            if (checkBox8.Checked == true) { Crocette.brisposta22 = true; }
            if (checkBox9.Checked == true) { Crocette.brisposta32 = true; }
            if (checkBox10.Checked == true) { Crocette.brisposta42 = true; }
            if (checkBox12.Checked == true) { Crocette.brisposta13 = true; }
            if (checkBox13.Checked == true) { Crocette.brisposta23 = true; }
            if (checkBox14.Checked == true) { Crocette.brisposta33 = true; }
            if (checkBox15.Checked == true) { Crocette.brisposta43 = true; }
            if (checkBox17.Checked == true) { Crocette.brisposta14 = true; }
            if (checkBox18.Checked == true) { Crocette.brisposta24 = true; }
            if (checkBox19.Checked == true) { Crocette.brisposta34 = true; }
            if (checkBox20.Checked == true) { Crocette.brisposta44 = true; }

            StreamWriter File = new StreamWriter("C://Users/Riccardo/Documents/TestVerifica/Crocette.txt");
            File.WriteLine(Domanda1.Text);
            File.WriteLine(Risposta1.Text);
            File.WriteLine(Risposta12.Text);
            File.WriteLine(Risposta13.Text);
            File.WriteLine(Risposta14.Text);
            File.WriteLine(Domanda2.Text);
            File.WriteLine(Risposta12.Text);
            File.WriteLine(Risposta22.Text);
            File.WriteLine(Risposta23.Text);
            File.WriteLine(Risposta24.Text);
            File.WriteLine(Domanda3.Text);
            File.WriteLine(Risposta13.Text);
            File.WriteLine(Risposta23.Text);
            File.WriteLine(Risposta33.Text);
            File.WriteLine(Risposta43.Text);
            File.WriteLine(Domanda4.Text);
            File.WriteLine(Risposta14.Text);
            File.WriteLine(Risposta24.Text);
            File.WriteLine(Risposta34.Text);
            File.WriteLine(Risposta44.Text);

            if (checkBox2.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox3.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox4.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox5.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox7.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox8.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox9.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox10.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox12.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox13.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox14.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox15.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox17.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox18.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox19.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }
            if (checkBox20.Checked == true) { File.WriteLine("s"); } else { File.WriteLine("n"); }

            File.Close();
        }

        private void ModificaCrocette_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void ModificaCrocette_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { button1.Focus(); button1.PerformClick(); }
        }
    }
}
