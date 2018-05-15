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
    public partial class Nome_e_descrizione : Form
    {
        public static string NomeVerifica;
        public static string DescrizioneVerifica;

        public Nome_e_descrizione()
        {
            InitializeComponent();
        }

        private void Invia_Click(object sender, EventArgs e)
        {
            NomeVerifica = Nome.Text;
            DescrizioneVerifica = Descrizione.Text;
        }

        private void Nome_e_descrizione_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Nome_e_descrizione_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Invia.Focus(); Invia.PerformClick(); }
        }
    }
}
