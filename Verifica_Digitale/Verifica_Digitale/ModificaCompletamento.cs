﻿using System;
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
    public partial class ModificaCompletamento : Form
    {
        public static bool domanda1;
        public static bool domanda2;
        public static bool domanda3;
        public static bool domanda4;

        public static bool risposta1;
        public static bool risposta2;
        public static bool risposta3;
        public static bool risposta4;

        public ModificaCompletamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Completamento.domanda1 = Domanda1.Text;
            Completamento.domanda2 = Domanda2.Text;
            Completamento.domanda3 = Domanda3.Text;
            Completamento.domanda4 = Domanda4.Text;

            Completamento.risposta1 = Risposta1.Text;
            Completamento.risposta2 = Risposta12.Text;
            Completamento.risposta3 = Risposta13.Text;
            Completamento.risposta4 = Risposta14.Text;
        }
    }
}
