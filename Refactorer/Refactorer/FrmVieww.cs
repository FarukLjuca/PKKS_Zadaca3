using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Refactorer
{
	public partial class FrmVieww : Form
	{
		private string PadBoth(string source, int length)
		{
			int spaces = length - source.Length;
			int padLeft = spaces / 2 + source.Length;
			return source.PadLeft (padLeft).PadRight (length);

		}
		public FrmVieww(string[] niz, string t)
		{
			InitializeComponent ();
			Text = t;
			StringBuilder sb = new StringBuilder ();
			foreach (var i in niz)
			{
				sb.AppendLine (i);
			}
			textBox1.Text = sb.ToString ();
		}

		private void FrmVieww_Load(object sender, EventArgs e)
		{

		}

		private void Klick(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				this.Close ();
			}
		}
	}
}
