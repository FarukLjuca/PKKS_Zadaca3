using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refactorer
{
	/// <summary>
	/// Specijalni panel koji podržava double buffering kao i neke akcije prilikom mijenjanja stila
	/// </summary>
	public class SpecPanel : Panel
	{
		public SpecPanel()
		{
			SetStyle (ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
			this.DoubleBuffered = true; //Ključno :D
		}
	}
}
