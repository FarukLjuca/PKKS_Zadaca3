using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Refactorer
{
	public class MIT
	{
		string Code = "";
		Regex reg;
		public MIT(string code)
		{
			Code = code;
			//string sr = @"\s*(unsigned\s+|signed\s+)?(void|int|char|short|long|float|double|bool|auto|constexpr)\s+(\w+)\s*\((.*)\)\s*{(.*?[\s\S]*?)}";
            string sr = @"\s*(unsigned\s+|signed\s+)?(void|int|char|short|long|float|double|bool|auto|constexpr)\s+(\w+)\s*\((.*)\)\s*{(.*[\s\S]*)}";
			reg = new Regex(sr, RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace | RegexOptions.CultureInvariant);
			m = new List<Funkcija>();
			foreach (Match M in reg.Matches (code))
			{
				if (!M.Success)
					continue;
				m.Add (new Funkcija (
						M.Groups[3].Value.Trim(),
						M.Groups[2].Value.Trim (),
						M.Groups[4].Value.Trim (),
						M.Groups[5].Value.Trim ()
					));
			}

		}
		private List<Funkcija> m;
		public class Funkcija
		{
			public string PovratniTip { get; private set; }
			public string Ime { get; private set; }
			public List<KeyValuePair<string, string>> Parametri { get; private set; }
			public bool ImaReturn { get { return PovratniTip != "void"; } }
			public string Tijelo { get; private set; }
			public int FanIn { get { return Parametri.Count; } }
			public int FanOut { get { return ImaReturn ? 1 : 0; } }
			public int IFC { get { return (int) Math.Pow (FanIn * FanOut, 2); } }
			public int WIFC { get { return IFC * Duzina; } }
			public int Duzina 
				{
					get 
						{ 
							return Tijelo.Split (
								new string[] { "\n" },
								StringSplitOptions.RemoveEmptyEntries).Length;
						}
				}
			public Funkcija(string ime, string tip, string param, string tijelo)
			{
				Ime = ime.Trim ();
				PovratniTip = tip.Trim ();
				Parametri = new List<KeyValuePair<string, string>> ();
				Tijelo = tijelo;
				var ps = param.Trim().Split (new string[] {","}, StringSplitOptions.RemoveEmptyEntries);
				if (ps.Length > 0)
				{
					foreach (string t in ps)
					{
						var p = t.Trim().Split (new string [] {" "}, StringSplitOptions.RemoveEmptyEntries);
						Parametri.Add (
							new KeyValuePair<string, string> (
								(p.Length > 1 ? p[1].Trim () : "{nema_imena}"), p[0].Trim ()));
					}
				}
			}
			public override string ToString()
			{
				var s = "Ime: " + Ime + Environment.NewLine +
					"Duzina: " + Duzina + Environment.NewLine +
					"FanIn: " + FanIn + Environment.NewLine +
					"FanOut: " + FanOut + Environment.NewLine +
					"IFC: " + IFC + Environment.NewLine +
					"WIFC: " + WIFC + Environment.NewLine + Environment.NewLine +
					"Parametri: " + Environment.NewLine + "------------------" + Environment.NewLine;
				foreach (var t in Parametri)
				{
					s += t.Key + ", tip: " + t.Value + Environment.NewLine;
				}
				return s;
					
			}
		}
		public int FanIn (int funkcija)
		{
			if (funkcija < 0 || funkcija >= m.Count)
				throw new ArgumentException ("Index izvan opsega!");
			return m[funkcija].FanIn;
		}
		/// <summary>
		/// Radi jednostavnosti (da ne analiziramo strukture), ovo moze 
		/// vratiti samo 1 (ako funkcija ima return) ili 0 (ako je void). 
		/// Znamo da C++ dozvoljava vracanje samo jedne vrijednosti iz funkcije
		/// </summary>
		/// <param name="funkcija">Index željene funkcije u kôdu. Ako kôd ima samo jednu funkciju, onda navesti 0</param>
		/// <returns></returns>
		public int FanOut(int funkcija)
		{
			
			if (funkcija < 0 || funkcija >= m.Count)
				throw new ArgumentException ("Index izvan opsega!");
			return m[funkcija].FanOut;
		}
		/// <summary>
		/// Information Flow Complexity: FanIn^2 * FanOut^2
		/// </summary>
		/// <param name="funkcija"></param>
		/// <returns></returns>
		public int IFC(int funkcija)
		{
			
			if (funkcija < 0 || funkcija >= m.Count)
				throw new ArgumentException ("Index izvan opsega!");
			return m[funkcija].IFC;
		}
		/// <summary>
		/// Broj linija kôda funkcije, bez praznih redova
		/// </summary>
		/// <param name="funkcija"></param>
		/// <returns></returns>
		public int Duzina(int funkcija)
		{

			if (funkcija < 0 || funkcija >= m.Count)
				throw new ArgumentException ("Index izvan opsega!");
			return m[funkcija].Duzina;
		}
		/// <summary>
		/// Weight IFC: Duzina * IFC
		/// </summary>
		/// <param name="funkcija"></param>
		/// <returns></returns>
		public int WIFC(int funkcija)
		{

			if (funkcija < 0 || funkcija >= m.Count)
				throw new ArgumentException ("Index izvan opsega!");
			return m[funkcija].WIFC;
		}
		public List<Funkcija> ListaFunkcija
		{
			get
			{
				return m;
			}
		}
	}
}
