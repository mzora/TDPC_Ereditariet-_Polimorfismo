using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDPC_Ereditarietà_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            Moto moto1 = new Moto();

            auto1.Modello = "punto";
            auto1.Ruote = 4;
            auto1.Assicurazione = true;

            moto1.Modello = "CBR";
            moto1.Ruote = 2;
            moto1.Assicurazione = false;

            List<Veicolo> veicoli = new List<Veicolo>();
            veicoli.Add(auto1);
            veicoli.Add(moto1);


            foreach(Veicolo veicolo in veicoli)
            {

                if(veicolo.Assicurazione) 
                    veicolo.AzionePrincipale();
            }
            Console.ReadKey();

        }
    }
}
