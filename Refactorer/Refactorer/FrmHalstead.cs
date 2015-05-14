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
	public partial class FrmHalstead : Form
	{
		Halstead h;
		/// <summary>
		/// Onaj kôd koji se analizira
		/// </summary>
		/// <param name="input"></param>
		public FrmHalstead(string input)
		{
			InitializeComponent ();
			h = new Halstead (input);
			n1.Text = h.n1.ToString();
			n2.Text = h.n2.ToString ();
			N10.Text = h.N1.ToString ();
			N20.Text = h.N2.ToString ();
			n.Text = h.n.ToString ();
			N0.Text = h.N.ToString ();
			V.Text = h.V.ToString ("0.000");
			D.Text = h.D.ToString ("0.000");
			E.Text = h.E.ToString ("0.000");
			T.Text = h.T.ToString ("0.000");
			B.Text = h.B.ToString ("0.000");
			L.Text = h.L.ToString ("0.000");
			
		}

		private void BtnOperatori_Click(object sender, EventArgs e)
		{
			var F = new FrmVieww (Halstead.SviOperatori, "Operandi");
			F.ShowDialog (this);
		}

		private void BtnOperandi_Click(object sender, EventArgs e)
		{
			var F = new FrmVieww (Halstead.SviOperandi, "Operatori");
			F.ShowDialog (this);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close ();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			
			var x = h.Operandi;
			string[] s = new string [x.Count];
			int b = 0;
			foreach (var i in x)
				s[b++] = string.Format ("{0, -15}{1,-3}", i.Key + ":", i.Value);
			new FrmVieww (s, "Operandi").ShowDialog (this);
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var x = h.Operatori;
			string[] s = new string[x.Count];
			int b = 0;
			foreach (var i in x)
				s[b++] = string.Format ("{0, -15}{1,-3}", i.Key + ":", i.Value);
			new FrmVieww (s, "Operatori").ShowDialog (this);
		}

		private void FrmHalstead_Load(object sender, EventArgs e)
		{

		}
	}
}
