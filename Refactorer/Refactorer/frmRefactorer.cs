﻿using System;
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

            List<string> komande = kalkulator.DajGraf();
			//moram dodati ovo :D
			if (komande.Count == 0)
			{
				MessageBox.Show (this, "Niste unijeli kôd. Unesite podržan kôd prvo da biste mogli nacrtati graf.", "Nema kôda", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

            frmGraf forma = new frmGraf(komande);
			forma.StartPosition = FormStartPosition.CenterParent; 
            forma.ShowDialog(this); //neka bude Dialog :3

             /*
            foreach (string s in tekst)
            {
                MessageBox.Show(s);
            }
              * */
        }

        private void btnHalstead_Click(object sender, EventArgs e)
        {
            FrmHalstead forma = new FrmHalstead(tbxKod.Text);
            forma.ShowDialog(this);
        }
    }
}
