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
	public partial class FrmAbout : Form
	{
		public FrmAbout()
		{
			InitializeComponent ();
		}

		private void Klick(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				this.Close ();
			}
		}

		private void FrmAbout_Load(object sender, EventArgs e)
		{
			RTB.LoadFile ("About.rtf", RichTextBoxStreamType.RichText);
		}
	}
}
