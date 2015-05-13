using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactorer
{
    public class KalkulatorMetrika
    {
        public String Kod { get; set; }

        public KalkulatorMetrika(String kod)
        {
            Kod = kod;
        }

        public McCabeRezultat DajMcCabePodatke()
        {
            McCabeRezultat rezultat = new McCabeRezultat();

            // Budući da je u zadatku naglašeno da se ispituje metrika jedne funkcije, njen broj neovisnih dijelova je uvijek 1
            rezultat.BrojNeovisnihDjelova = 1;



            return rezultat;
        }
    }
}
