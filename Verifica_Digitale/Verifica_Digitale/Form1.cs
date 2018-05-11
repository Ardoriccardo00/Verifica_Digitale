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
    public partial class Form1 : System.Windows.Forms.Form
    {
        int Totale;
        int Barra;

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

        private async void button4_Click(object sender, EventArgs e)
        {
  

            this.Progresso.Start();

            trackBar1.Enabled = false;

            progressBar1.Visible = true;
           
            }

        private void Attiva_CheckedChanged(object sender, EventArgs e)
        {
            if (Attiva.Checked == true) { button4.Enabled = true; }
            else { button4.Enabled = false; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.TickStyle = TickStyle.BottomRight;
            trackBar1.TickFrequency = 10;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
          
            Barra = trackBar1.Value;
            if (Barra == 100) { Attiva.Enabled = true; }
            else { Attiva.Enabled = false; }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Progresso_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value >= 100) {

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
                txtText.Text = "Scelta multipla: " + Convert.ToString(SceltaMultipla.PassaPuntiMultipla) + ", "
                + "Crocette: " + Convert.ToString(Crocette.PassaPuntiCrocette) + ", "
                + "Completamento: " + Convert.ToString(Completamento.PassaPunti) + ", "
                + "Totale: "
                + Totale;


                StreamWriter File = new StreamWriter(Login.Studente);
                File.WriteLine("Scelta multipla: " + SceltaMultipla.PassaPuntiMultipla + ",");
                File.WriteLine(" Crocette: " + Crocette.PassaPuntiCrocette + ",");
                File.WriteLine(" Completamento: " + Completamento.PassaPunti + ",");
                File.WriteLine(" Totale: " + Totale);
                File.Close();

            }
        }
    }
    }



//Vecchio sistema di salvataggio
//            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents |*.txt", ValidateNames = true }) {
//                if (sfd.ShowDialog() == DialogResult.OK) {
//                    using (StreamWriter sw = new StreamWriter(sfd.FileName)) {
//                        await sw.WriteLineAsync(txtText.Text);
//MessageBox.Show("Scrittura completata", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                }
//            }
