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
    public partial class ModificaMultiple : Form
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


        public ModificaMultiple()
        {
            InitializeComponent();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SceltaMultipla.domanda1 = Domanda1.Text;
            SceltaMultipla.domanda2 = Domanda2.Text;
            SceltaMultipla.domanda3 = Domanda3.Text;
            SceltaMultipla.domanda4 = Domanda4.Text;

            SceltaMultipla.risposta11 = Risposta1.Text;
            SceltaMultipla.risposta21 = Risposta2.Text;
            SceltaMultipla.risposta31 = Risposta3.Text;
            SceltaMultipla.risposta41 = Risposta4.Text;
            SceltaMultipla.risposta12 = Risposta12.Text;
            SceltaMultipla.risposta22 = Risposta22.Text;
            SceltaMultipla.risposta32 = Risposta32.Text;
            SceltaMultipla.risposta42 = Risposta42.Text;
            SceltaMultipla.risposta13 = Risposta13.Text;
            SceltaMultipla.risposta23 = Risposta23.Text;
            SceltaMultipla.risposta33 = Risposta33.Text;
            SceltaMultipla.risposta43 = Risposta43.Text;
            SceltaMultipla.risposta14 = Risposta14.Text;
            SceltaMultipla.risposta24 = Risposta24.Text;
            SceltaMultipla.risposta34 = Risposta34.Text;
            SceltaMultipla.risposta44 = Risposta44.Text;



            if (checkBox2.Checked == true) { SceltaMultipla.brisposta11 = true; } 
            if (checkBox3.Checked == true) { SceltaMultipla.brisposta21 = true; }
            if (checkBox4.Checked == true) { SceltaMultipla.brisposta31 = true; }
            if (checkBox5.Checked == true) { SceltaMultipla.brisposta41 = true; }
            if (checkBox7.Checked == true) { SceltaMultipla.brisposta12 = true; }
            if (checkBox8.Checked == true) { SceltaMultipla.brisposta22 = true; }
            if (checkBox9.Checked == true) { SceltaMultipla.brisposta32 = true; }
            if (checkBox10.Checked == true) { SceltaMultipla.brisposta42 = true; }
            if (checkBox12.Checked == true) { SceltaMultipla.brisposta13 = true; }
            if (checkBox13.Checked == true) { SceltaMultipla.brisposta23 = true; }
            if (checkBox14.Checked == true) { SceltaMultipla.brisposta33 = true; }
            if (checkBox15.Checked == true) { SceltaMultipla.brisposta43 = true; }
            if (checkBox17.Checked == true) { SceltaMultipla.brisposta14 = true; }
            if (checkBox18.Checked == true) { SceltaMultipla.brisposta24 = true; }
            if (checkBox19.Checked == true) { SceltaMultipla.brisposta34 = true; }
            if (checkBox20.Checked == true) { SceltaMultipla.brisposta44 = true; }

            
        }
    }
}


//domanda1 = Domanda1.Text;
//domanda2 = Domanda2.Text;
//domanda3 = Domanda3.Text;
//domanda4 = Domanda4.Text;
//risposta11 = Risposta1.Text;
//risposta21 = Risposta2.Text;
//risposta31 = Risposta3.Text;
//risposta41 = Risposta4.Text;
//risposta12 = Risposta12.Text;
//risposta22 = Risposta22.Text;
//risposta32 = Risposta32.Text;
//risposta42 = Risposta42.Text;
//risposta13 = Risposta13.Text;
//risposta23 = Risposta23.Text;
//risposta33 = Risposta33.Text;
//risposta43 = Risposta43.Text;
//risposta14 = Risposta14.Text;
//risposta24 = Risposta24.Text;
//risposta34 = Risposta34.Text;
//risposta44 = Risposta44.Text;

//public static string domanda1;
//public static string domanda2;
//public static string domanda3;
//public static string domanda4;
//public static string risposta11;
//public static string risposta21;
//public static string risposta31;
//public static string risposta41;
//public static string risposta12;
//public static string risposta22;
//public static string risposta32;
//public static string risposta42;
//public static string risposta13;
//public static string risposta23;
//public static string risposta33;
//public static string risposta43;
//public static string risposta14;
//public static string risposta24;
//public static string risposta34;
//public static string risposta44;

//if (checkBox1.Checked == true)  { SceltaMultipla.bdomanda1 = true; }
//if (checkBox6.Checked == true)  { SceltaMultipla.bdomanda2 = true; }
//if (checkBox11.Checked == true) { SceltaMultipla.bdomanda3 = true; }
//if (checkBox16.Checked == true) { SceltaMultipla.bdomanda4 = true; }