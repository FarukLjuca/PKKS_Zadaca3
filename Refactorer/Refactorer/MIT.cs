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
			reg = new Regex (@"\s*(unsigned|signed)?\s+" + 
				@"(void|int|char|short|long|float|double|bool|auto|constexpr)\s+(\w+)\s*\((.*)\)\s*{(.*[\s\S]*?)}",
				 RegexOptions.CultureInvariant | RegexOptions.IgnoreCase |
				 RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline);
			m = new List<Funckija>();
			var M = reg.Match(Code);
			foreach (Group t in M.Groups)
			{
				m.Add (new Funckija (
					t.Captures[0].Value.Trim (),
					t.Captures[1].Value.Trim (),
					t.Captures[2].Value.Trim(),
					t.Captures[3].Value
				));
			}
		}
		private List<Funckija> m;
		public class Funckija
		{
			public string PovratniTip { get; private set; }
			public string Ime { get; private set; }
			public List<KeyValuePair<string, string>> Parametri { get; private set; }
			public bool ImaReturn { get { return PovratniTip != "void"; } }
			public string Tijelo { get; private set; }
			
			public Funckija(string ime, string tip, string param, string tijelo)
			{
				Ime = ime.Trim ();
				PovratniTip = tip.Trim ();
				Tijelo = tijelo;
				var ps = param.Split (',');
				if (ps.Length > 0)
				{
					foreach (string t in ps)
					{
						var p = t.Trim().Split (' ');
						Parametri.Add (
							new KeyValuePair<string, string> (
								(p.Length > 1 ? p[1].Trim () : "{nema_imena}"), p[0].Trim ()));
					}
				}
			}
		}
		public int FanIn (int funkcija)
		{
			if (funkcija < 0 || funkcija >= m.Count)
				throw new ArgumentException ("Index izvan opsega!");
			return m[funkcija].Parametri.Count;
		}
		/// <summary>
		/// Radi jednosavnosti (da ne analiziramo strukture), ovo moze 
		/// vratiti samo 1 (ako funkcija ima return) ili 0 (ako je void). 
		/// Znamo da C++ dozvoljava vracanje samo jedne vrijednosti iz funkcije
		/// </summary>
		/// <param name="funkcija">Index željene funkcije u kôdu. Ako kôd ima samo jednu funkciju, onda navesti 0</param>
		/// <returns></returns>
		public int FanOut(int funkcija)
		{
			if (funkcija < 0 || funkcija >= m.Count)
				throw new ArgumentException ("Index izvan opsega!");
			return m[funkcija].ImaReturn ? 1 : 0;
		}
		public List<Funckija> ListaFunkcija
		{
			get
			{
				return m;
			}
		}
	}
}
