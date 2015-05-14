using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refactorer
{
	public partial class FrmMIT : Form
	{
		private Label DajLabel (string text, bool da)
		{
			var l = new Label ();
			l.Dock = System.Windows.Forms.DockStyle.Fill;
			l.Font = new System.Drawing.Font ("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
			l.Location = new System.Drawing.Point (3, 0);
			l.Size = new System.Drawing.Size (194, 26);
			l.TabIndex = 0;
			l.ForeColor = Color.Blue;
			l.BackColor = da ? Color.LightGray : Color.DarkGray;
			l.Margin = new Padding (0);
			l.Padding = new Padding (0);
			l.Text = text;
			l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			return l;
		}
		public FrmMIT(string code)
		{
			InitializeComponent ();
			MIT m = new MIT (code);
			var f = m.ListaFunkcija;
			int i = 1;
			groupBox1.Text += f.Count.ToString ();
			foreach (MIT.Funkcija fun in f)
			{
				int j = 0;
				bool d = i % 2 == 0;
				TLP.RowStyles.Add (new RowStyle (SizeType.Absolute, 30));
				TLP.Controls.Add (DajLabel (fun.Ime, d), j++, i);
				TLP.Controls.Add (DajLabel (fun.FanIn.ToString (), d), j++, i);
				TLP.Controls.Add (DajLabel (fun.FanOut.ToString (), d), j++, i);
				TLP.Controls.Add (DajLabel (fun.Duzina.ToString (), d), j++, i);
				TLP.Controls.Add (DajLabel (fun.IFC.ToString (), d), j++, i);
				TLP.Controls.Add (DajLabel (fun.WIFC.ToString (), d), j++, i++);
				var p = fun.Parametri;
				TreeNode param = new TreeNode ("Parametri (" + p.Count.ToString() + ")");
				foreach (var z in p)
				{
					param.Nodes.Add (z.Key + " [" + z.Value + "]");
				}
				TreeNode fn = new TreeNode (fun.Ime);
				fn.Nodes.Add (new TreeNode ("Povratni tip: " + fun.PovratniTip));
				fn.Nodes.Add (new TreeNode ("Dužina (br. linija): " + fun.Duzina));
				fn.Nodes.Add (param);
				TV.Nodes.Add (fn);
			}
			TV.CollapseAll ();
		}

		private void FrmMIT_Load(object sender, EventArgs e)
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
