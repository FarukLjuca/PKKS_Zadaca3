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
    public partial class frmRefactorer : Form
    {
        public frmRefactorer()
        {
            InitializeComponent();
        }

        private void btnMcCabe_Click(object sender, EventArgs e)
        {
            KalkulatorMetrika kalkulator = new KalkulatorMetrika(tbxKod.Text);
            McCabeRezultat rezultat = kalkulator.DajMcCabePodatke();

            MessageBox.Show("McCabe kompleksnost koda koji ste unijeli iznosi: " + rezultat.Kompleksnost.ToString());
        }

        private void llbPravila_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String pravila = "Pravila za korištenje programa:\n\n" +
                "1. Sve tijela petlji i uslovnih grananja moraju biti ograničeni vitičastim zagradama, čak i ako su jednolinijski.";

            MessageBox.Show(pravila);
        }

        private void btnGraf_Click(object sender, EventArgs e)
        {
            KalkulatorMetrika kalkulator = new KalkulatorMetrika(tbxKod.Text);

            //frmGraf forma = new frmGraf();
            //forma.Show();

            List<string> tekst = kalkulator.DajGraf();

            foreach (string s in tekst)
            {
                MessageBox.Show(s);
            }
        }
    }
}
