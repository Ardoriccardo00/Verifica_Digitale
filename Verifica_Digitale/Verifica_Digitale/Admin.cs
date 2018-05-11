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
    public partial class Admin : Form
    {
        string Password = ""; //LoveMuffin367
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Password) { MessageBox.Show("Benvenuto/a", "Acesso eseguito.");
                label1.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
            else { MessageBox.Show("Dati inseriti errati."); }
        }

        private void Admin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { button1.Focus();  button1.PerformClick(); }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ModificaMultiple mfm = new ModificaMultiple();
            mfm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ModificaCrocette mfc = new ModificaCrocette();
            mfc.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ModificaCompletamento mfcc = new ModificaCompletamento();
            mfcc.Show();
        }
    }
}
