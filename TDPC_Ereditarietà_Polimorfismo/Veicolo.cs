using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDPC_Ereditarietà_Polimorfismo
{
    class Veicolo
    {
        public string Modello { get; set; }
        public int Ruote { get; set; }
        public bool Assicurazione { get; set; }

        public virtual void AzionePrincipale()
        {
            Console.WriteLine("questo è il modello: " + this.Modello + "\n questo veicolo ha queste ruote: " + this.Ruote);
        }
    }
}
