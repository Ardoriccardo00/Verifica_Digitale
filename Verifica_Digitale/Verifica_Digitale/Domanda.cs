using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Digitale
{
    public class Domanda
    { 
        public string domanda { get; set; }
        public string[] _risposte = new string[4];
        public Domanda(string Domanda, string[] Risposte) {
            domanda = Domanda;
            for (int i = 0; i < 4; i++)
            {
                _risposte[i] = Risposte[i];
            }
        }
    
    }
}
