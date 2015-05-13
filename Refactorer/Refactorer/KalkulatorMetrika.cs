using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            rezultat.Kompleksnost = DajBrojUslovnihGrananjaBezElse() + DajBrojPetlji();

            return rezultat;
        }

        private int DajBrojPetlji()
        {
            int brojPetlji = 0;

            Regex patern = new Regex(@"\bfor *\(");
            brojPetlji += patern.Matches(Kod).Count;

            patern = new Regex(@"\bwhile *\(");
            brojPetlji += patern.Matches(Kod).Count;

            patern = new Regex(@"\bforeach *\(");
            brojPetlji += patern.Matches(Kod).Count;

            return brojPetlji;
        }

        private int DajBrojUslovnihGrananjaBezElse()
        {
            // Bez else je jer else ne utice na McCabe metriku
            int brojUslova = 0;

            //Broji i if i else if, buduci da je oboma utican na metriku +1, to je prihvatljivo
            Regex patern = new Regex(@"\bif *\(");
            brojUslova += patern.Matches(Kod).Count;

            patern = new Regex(@"\bcase\b");
            brojUslova += patern.Matches(Kod).Count;

            return brojUslova;
        }
    }
}
