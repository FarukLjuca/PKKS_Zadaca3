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
        private System.Drawing.Graphics g;
        private System.Drawing.Pen olovka = new System.Drawing.Pen(Color.Blue, 2F);

        public frmGraf()
        {
            InitializeComponent();
        }

        private void frmGraf_Load(object sender, EventArgs e)
        {
            g = pbxGraf.CreateGraphics();
            g.DrawLine(olovka, 0, 0, 50, 50);
        }
    }
}
