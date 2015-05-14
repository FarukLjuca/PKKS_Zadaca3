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

            rezultat.Kompleksnost = DajBrojUslovnihGrananjaBezElse() + DajBrojPetlji() + 1;

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
            #region Stari kod
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
            List<int> indeksi = new List<int>();

            Regex patern = new Regex(@"\b(if|else|case)\b");
            foreach (Match pogodak in patern.Matches(Kod))
            {
                komande.Add("grananje");
                indeksi.Add(pogodak.Index);
            }

            patern = new Regex(@"\bswitch\b");
            foreach (Match pogodak in patern.Matches(Kod))
            {
                komande.Add("switch");
                indeksi.Add(pogodak.Index);
            }

            patern = new Regex(@"\b(for|while|foreach)\b");
            foreach (Match pogodak in patern.Matches(Kod))
            {
                komande.Add("petlja");
                indeksi.Add(pogodak.Index);
            }

            patern = new Regex(@"\bdo\b");
            foreach (Match pogodak in patern.Matches(Kod))
            {
                bool preskoci = false;

                foreach (int postojeciIndex in indeksi)
                    if (postojeciIndex == pogodak.Index)
                    {
                        preskoci = true;
                        break;
                    }

                if (true == preskoci)
                    continue;

                komande.Add("dowhile");
                indeksi.Add(pogodak.Index);
            }

            patern = new Regex(@"}");
            foreach (Match pogodak in patern.Matches(Kod))
            {
                komande.Add("kraj");
                indeksi.Add(pogodak.Index);
            }

            bool biloPromjene = true;

            while (true == biloPromjene)
            {
                biloPromjene = false;

                for (int i = 0; i < komande.Count - 1; i++)
                    if (indeksi[i] > indeksi[i + 1])
                    {
                        int temp = indeksi[i];
                        indeksi[i] = indeksi[i + 1];
                        indeksi[i + 1] = temp;

                        string tempString = komande[i];
                        komande[i] = komande[i + 1];
                        komande[i + 1] = tempString;

                        biloPromjene = true;
                    }
            }

            int prvaPetlja = -1;
            int drugaPetlja = -1;
            for (int i = 0; i < komande.Count; i++)
            {
                if (komande[i] == "petlja")
                {
                    if (prvaPetlja == -1)
                        prvaPetlja++;
                    else if (drugaPetlja == -1)
                        drugaPetlja++;
                    else
                        System.Windows.Forms.MessageBox.Show("Kod koji ste unjeli ima trostruko ugnježdenu petlju");
                }
                else if (komande[i] == "grananje" || komande[i] == "switch")
                {
                    if (prvaPetlja >= 0)
                        prvaPetlja++;
                    else if (drugaPetlja >= 0)
                        drugaPetlja++;
                }
                else if (komande[i] == "kraj")
                {
                    if (prvaPetlja == 0)
                        komande[i] = "krajPetlje";
                    else if (drugaPetlja == 0)
                        komande[i] = "krajPetlje";
                    else if (drugaPetlja > 0)
                        drugaPetlja--;
                    else if (prvaPetlja > 0)
                        prvaPetlja--;
                }
            }

            String str = "";
            foreach (string  s  in komande)
            {
                str += s + "\n";
            }

            System.Windows.Forms.MessageBox.Show(str);

            return komande;
        }
    }
}
