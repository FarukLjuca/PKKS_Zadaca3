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
    public partial class frmGraf : Form
    {
        public frmGraf()
        {
            InitializeComponent();
        }

        private void frmGraf_Load(object sender, EventArgs e)
        {
            pnlGraf.Paint += new PaintEventHandler(Crtaj);
        }

        private void Crtaj(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen olovka = new Pen(Color.Black, 3);
                g.DrawLine(olovka, 0, 0, 100, 100);
                g.DrawEllipse(olovka, 50, 50, 50, 50);
            }
        }
    }
}
