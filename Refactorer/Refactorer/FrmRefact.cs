using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refactorer
{
	public partial class FrmRefact : Form
	{
		public FrmRefact(string code)
		{
			InitializeComponent ();
			tbxKod.Text = code;
		}

		private void FrmRefact_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var s = tbxKod.Text;
			var re = new Regex(@"(<=?|>=?|==)\s*([+-]?\b\d*\.?\d+)\b",
				 RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace |
				  RegexOptions.Multiline);
			var sb = new StringBuilder ();
			var c = checkBox1.Checked;
			var rnd = new Random ();
			foreach (Match M in re.Matches (s))
			{
				if (!M.Success)
					continue;
				var mval = M.Groups[2].Value;
				var isint = !mval.Contains (".");
				var svar = "VAR_" + rnd.Next (0, 1000).ToString ();
				var ssvar = svar + " = " + mval; ;
				var s_stari = s;
				s = Regex.Replace (s, @"(<=?|>=?|==)\s*(" + Regex.Escape (mval) + @")\b", M.Groups[1].Value  + " " + svar);
				if (s != s_stari)
					sb.AppendLine ((c ? "const " : "") + (isint ? "int " : "double ") + ssvar + "; // promijeniti ime");
			}
			tbxKod.Text = sb.ToString () + Environment.NewLine + s;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Trim() == "")
			{
				MessageBox.Show ("Nije uneseno staro ime za varijablu!");
				return;
			}
			if (textBox2.Text.Trim () == "")
			{
				MessageBox.Show ("Nije uneseno novo ime za varijablu!");
				return;
			}
			var s = textBox1.Text.Trim();
			var n = textBox2.Text.Trim();
			var rn = new Regex (@"\b" + Regex.Escape (n) + @"\b");
			var rs = @"\b" + Regex.Escape (s) + @"\b";
			var sc = tbxKod.Text;
			if (rn.IsMatch (sc))
			{
				MessageBox.Show ("Varijabla '" + n + "' već postoji u kôdu!");
				return;
			}
			if (!Regex.Match(sc, rs).Success)
			{
				MessageBox.Show ("Varijabla '" + s + "' NE postoji u kôdu!");
				return;
			}
			tbxKod.Text = Regex.Replace (sc, rs, n);

		}
	}
}
