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

        public List<String> DajGraf()
        {
            #region Prosli kod
            /*
            List<String> graf = new List<string>();

            bool pocelaPetlja = false;
            int tijeloPetlje = 0;
            bool imaCase = false;

            for (int i = 0; i < Kod.Length; i++)
            {
                if (Kod[i] == 'c' && Kod[i+1] == 'a' && Kod[i+2] == 's' && Kod[i+3] == 'e')
                {
                    graf.Add("case");
                    imaCase = true;
                }
                else if ((Kod[i] == 'f' && Kod[i + 1] == 'o' && Kod[i + 2] == 'r') ||
                    (Kod[i] == 'w' && Kod[i+1] == 'h' && Kod[i+2] == 'i' && Kod[i+3] == 'l'&& Kod[i+4] == 'e') ||
                    (Kod[i] == 'f' && Kod[i+1] == 'o' && Kod[i+2] == 'r' && Kod[i+3] == 'e'&& Kod[i+4] == 'a' && Kod[i+5] == 'c' && Kod[i+6] == 'h'))
                {
                    graf.Add("petlja");
                    pocelaPetlja = true;
                    tijeloPetlje++;
                }
                else if (i < Kod.Length-4 && Kod[i] == 'e' && Kod[i + 1] == 'l' && Kod[i + 2] == 's' && Kod[i + 3] == 'e' && Kod[i + 4] == ' ' && Kod[i + 5] == 'i' && Kod[i + 6] == 'f')
                {
                    graf.Add("elseif");
                    if (pocelaPetlja)
                        tijeloPetlje++;
                }
                else if (Kod[i] == 'i' && Kod[i + 1] == 'f' && ((i > 0 && Kod[i - 2] != 'e') || i == 0)/* && (Kod[i+2] == '(' || Kod[i+3] == '('))
                {
                    graf.Add("if");
                    if (pocelaPetlja)
                        tijeloPetlje++;
                }
                else if (i < Kod.Length - 4 && Kod[i] == 'e' && Kod[i + 1] == 'l' && Kod[i + 2] == 's' && Kod[i + 3] == 'e'/* && (Kod[i + 4] == '(' || Kod[i + 5] == '('))
                {
                    if (Kod[i + 5] != 'i')
                    {
                        graf.Add("else");
                        if (pocelaPetlja)
                            tijeloPetlje++;
                    }
                }
                else if (Kod[i] == '}')
                {
                    graf.Add("end");
                    if (pocelaPetlja)
                        tijeloPetlje--;
                    if ((tijeloPetlje == 0 && imaCase == false && pocelaPetlja == true) || (tijeloPetlje == -1 && imaCase == true))
                    {
                        graf.Add("endPetlja");
                        tijeloPetlje = 0;
                        imaCase = false;
                        pocelaPetlja = false;
                    }
                }
            }

            return graf;
        */
            # endregion

            List<String> komande = new List<String>();



            return komande;
        }
    }
}
