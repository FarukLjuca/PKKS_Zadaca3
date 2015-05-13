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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMcCabe_Click(object sender, EventArgs e)
        {
            //KalkuratorMetrika kalkulator = new KalkuratorMetrika(tbxKod.Text);
            //kalkulator.IzracunajMcCabe();
            Regex r = new Regex(@"\bfor *\(");
            var i = r.Matches ("for                    (int i...) foreach for( int forever = 1;").Count;
            tbxKod.Text = i.ToString();
            //i += new Regex(@"\bwhile\s*\(").Matches(inputneki).ToString();

            // Radi li ovaj git XD
        }
    }
}
