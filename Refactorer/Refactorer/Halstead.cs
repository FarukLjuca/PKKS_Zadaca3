using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Refactorer
{
	public class Halstead
	{
		private string Code = "";

		//Konstante koje je Halstead empirijski otkrio
		private const int Halstead_Vrijeme = 18;
		private const int Halstead_Bugovi = 3000;
		private const double Halstead_KoeficijentBugova = 2.0 / 3.0;

		public Halstead(string code)
		{
			Code = code;
		}
		static readonly string [] operatori = {"extern", "inline", "register", "static", "typedef", "virtual", "mutable",
		"const", "friend", "volatile","internal", "asm", "break", "case", "class", "continue", "default",
		"delete", "do", "else", "enum", "for", "goto", "if", "new", "operator", "private", 
		"protected", "public", "return", "sizeof", "struct", "switch", "this", "union", "while", 
		"namespace", "using", "try", "catch", "throw", "const_cast", "static_cast", "dynamic_cast",
		"reinterpret_cast", "typeid", "template","typedef", "explicit", "true", "false", "typename", "decltype", "class",
		"!=","%", "%=", "&", "&&", "||", "&=", "(", "*", "*=", "+", "++", "+=", "-", "--", "-=", "->",
		"...", "/", "/=", "::", "<", "<<", "<<=", "<=", "=", "==", ">", ">=", ">>", ">>=", "?", "[",
		"]", "^", "^=", "{", "|", "|=", "~"};
		static readonly string[] operandi = {"bool", "char", "short", "int","size_t", "wchar", "wchar_t", "float", "unsigned", "long", "double", "signed",
							"void"};
		private bool Sadrzi (string[] sta, string rijec, bool caseinsensitive = false)
		{
			foreach (var s in sta)
				if (caseinsensitive)
				{
					if (s.ToLower() == rijec.ToLower())
						return true;
				}
				else
				{
					if (s == rijec)
						return true;
				}
			return false;
		}
		public Dictionary<string, int> Operatori
		{
			get
			{
				Dictionary<string, int> m = new Dictionary<string, int>();
				foreach (var s in operatori)
					if (!Sadrzi (operandi, s, true))
					{
						var r = new Regex (@"" + Regex.Escape(s) + @"", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline | RegexOptions.CultureInvariant);
						if (r.IsMatch (Code))
						{
							if (!m.ContainsKey(s))
								m.Add (s, 0);
							foreach (var t in r.Matches(Code))
							{
								m[s]++;
							}
						}
					}
				return m;
			}
		}
		public Dictionary<string, int> Operandi
		{
			get
			{
				Dictionary<string, int> m = new Dictionary<string, int> ();
				var r = new Regex (@"(\w+)|('\w+')|(" + "\"" + @"\w+" + "\")", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline | RegexOptions.CultureInvariant);
				foreach (var t in r.Matches (Code))
				{
					if (!Sadrzi (operatori, t.ToString(), true) && !Sadrzi(operandi, t.ToString(), true))
					{
												
						if (!m.ContainsKey(t.ToString()))
								m.Add (t.ToString(), 0);

						m[t.ToString()]++;
					}
				}
				return m;

			}
		}
		public static string[] SviOperatori 
		{ 
			get 
			{
				return operatori;
			}
		}
		public static string[] SviOperandi
		{
			get
			{
				return operandi;
			}
		}
		/// <summary>
		/// Broj operatora
		/// </summary>
		public int n1
		{
			get { return Operatori.Count; }
		}
		/// <summary>
		/// Broj operanada
		/// </summary>
		public int n2
		{
			get { return Operandi.Count; }
		}
		/// <summary>
		/// Broj ukupnih brojeva operatora
		/// </summary>
		public int N1
		{
			get 
			{
				var i = 0;
				var o = Operatori;
				foreach (var t in o)
					i += t.Value;
				return i;
			}
		}
		/// <summary>
		/// Broj ukupnih brojeva operanada
		/// </summary>
		public int N2
		{
			get
			{
				var i = 0;
				var o = Operandi;
				foreach (var t in o)
					i += t.Value;
				return i;
			}
		}
		/// <summary>
		/// Dužina programa (N1 + N2)
		/// </summary>
		public int N { get { return N1 + N2; } }
		/// <summary>
		/// Dužina volabulara (n1 + n2) - broj jedinstvenih operatora i operanada
		/// </summary>
		public int n { get { return n1 + n2; } }
		/// <summary>
		/// Volumen programa: V = N * log2 (n)
		/// </summary>
		public double V { get { return N * Math.Log (n, 2.0); } }
		/// <summary>
		/// Nivo poteškoće: D = (n1 / 2.0) * (N2 / 2.0)
		/// </summary>
		public double D { get { return (n1 / 2.0) * (N2 / 2.0); } }
		/// <summary>
		/// Nivo programa: L = 1 / D
		/// </summary>
		public double L { get { return 1.0 / D; } }
		/// <summary>
		/// Napor implementacije: E = V * D
		/// </summary>
		public double E { get { return V * D; } }
		/// <summary>
		/// Vrijeme implementacije: T = E / Halstead_Vrijeme = E / 18
		/// </summary>
		public double T { get { return E / Halstead_Vrijeme; } }
		/// <summary>
		/// Broj isporučenih bugova: B = E ^ (2 / 3) / 3000
		/// </summary>
		public double B { get { return Math.Pow (E, Halstead_KoeficijentBugova) / Halstead_Bugovi; } }
	}
}
