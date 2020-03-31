using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDPC_Ereditarietà_Polimorfismo
{
    class Moto : Veicolo
    {

        public override void AzionePrincipale()
        {
            //base.AzionePrincipale();
            Console.WriteLine("è una moto");
        }
    }
}
