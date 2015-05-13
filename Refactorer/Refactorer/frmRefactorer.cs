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

            MessageBox.Show(rezultat.BrojCvorova.ToString());
        }

        private void llbPravila_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: Enil: sta ovdje treba da se desava, nova forma sa tekstom?
            //TODO: Dodati u pravila da se petlje i if uslovi moraju stavljati u viticastim zagradama, cak i ako je jedna linija
        }
    }
}
