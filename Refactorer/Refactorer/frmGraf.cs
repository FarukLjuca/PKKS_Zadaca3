﻿using System;
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
        private List<String> komande;

        public frmGraf(List<String> komande)
        {
            InitializeComponent();
            this.komande = komande;
        }

        private void frmGraf_Load(object sender, EventArgs e)
        {
            pnlGraf.Paint += new PaintEventHandler(Crtaj);
        }
        /// <summary>
        /// Čisto da vidimo da li je bolje kad se popuni :D
        /// </summary>
        bool popuni = true;

        private void Popuni(Graphics g, int x, int y, int w = 20, int h = 20)
        {
            if (!popuni) return;
            Brush boja = new System.Drawing.Drawing2D.LinearGradientBrush(
                new Rectangle(x, y, w, h),
                Color.Orange, Color.White,
                System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
            g.FillEllipse(boja, x, y, w, h);
        }

        private void Crtaj(object sender, PaintEventArgs e)
        {
            #region Stari kod
            /*
            Graphics g = e.Graphics;
            int sredina = e.ClipRectangle.Width / 2;
            bool prviIf = true;
            int visina = 20;
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen olovka = new Pen(Color.Black, 3);

                
                int brojElsa = 0;
                bool provjeriSljedeci = false;
                int caseBrojac = 0;

                for (int i = 0; i < graf.Count; i++ )
                {
                    if (graf[i] != "case")
                    {
                        caseBrojac = 0;
                    }

                    if (provjeriSljedeci == true)
                    {
                        if (graf[i] == "end")
                        {
                            continue;
                        }
                        else if (graf[i] != "else" && graf[i] != "elseif" && graf[i] != "case")
                        {
                            g.DrawArc(olovka, sredina - 25, visina + 10, 50, 80, 90, 180);
                            g.DrawLine(olovka, sredina, visina + 90, sredina - 5, visina + 95);
                            g.DrawLine(olovka, sredina, visina + 90, sredina - 5, visina + 83);
                        }
                    }
                    provjeriSljedeci = false;

                    if (graf[i] == "if" || graf[i] == "case" && caseBrojac == 0)
                    {
                        caseBrojac++;
                        provjeriSljedeci = true;
                        brojElsa = 0;

                        if (prviIf != true)
                        {
                            visina += 120;

                            g.DrawLine(olovka, sredina + 10, visina - 20, sredina + 10, visina);
                            g.DrawLine(olovka, sredina + 10, visina, sredina + 5, visina - 5);
                            g.DrawLine(olovka, sredina + 10, visina, sredina + 15, visina - 5);
                        }
                        prviIf = false;

                        Popuni(g, sredina, visina);
                        g.DrawEllipse(olovka, sredina, visina, 20, 20);
                        g.DrawLine(olovka, sredina + 10, visina + 20, sredina + 10, visina + 40);
                        g.DrawLine(olovka, sredina + 10, visina + 40, sredina + 5, visina + 35);
                        g.DrawLine(olovka, sredina + 10, visina + 40, sredina + 15, visina + 35);
                        visina += 40;

                        Popuni(g, sredina, visina);
                        g.DrawEllipse(olovka, sredina, visina, 20, 20);
                        g.DrawLine(olovka, sredina + 10, visina + 20, sredina + 10, visina + 40);
                        g.DrawLine(olovka, sredina + 10, visina + 40, sredina + 5, visina + 35);
                        g.DrawLine(olovka, sredina + 10, visina + 40, sredina + 15, visina + 35);
                        visina += 40;
                        Popuni(g, sredina, visina);
                        g.DrawEllipse(olovka, sredina, visina, 20, 20);
                        visina -= 80;
                    }
                    else if (graf[i] == "elseif" || graf[i] == "else" || graf[i] == "case")
                    {
                        provjeriSljedeci = false;

                        if (brojElsa == 0 || graf[i] == "case" && caseBrojac == 1)
                        {
                            caseBrojac++;
                            Popuni(g, sredina - 40, visina + 40);
                            g.DrawEllipse(olovka, sredina - 40, visina + 40, 20, 20);

                            g.DrawLine(olovka, sredina, visina + 15, sredina - 25, visina + 40);
                            g.DrawLine(olovka, sredina - 25, visina + 40, sredina - 25, visina + 33);
                            g.DrawLine(olovka, sredina - 25, visina + 40, sredina - 18, visina + 40);
                            visina += 40;

                            g.DrawLine(olovka, sredina - 25, visina + 20, sredina, visina + 45);
                            g.DrawLine(olovka, sredina, visina + 45, sredina, visina + 38);
                            g.DrawLine(olovka, sredina, visina + 45, sredina - 7, visina + 45);
                            visina -= 40;

                            brojElsa++;
                        }
                        else if (brojElsa == 1 || graf[i] == "case" && caseBrojac == 2)
                        {
                            caseBrojac++;
                            Popuni(g, sredina + 40, visina + 40);
                            g.DrawEllipse(olovka, sredina + 40, visina + 40, 20, 20);

                            g.DrawLine(olovka, sredina + 20, visina + 15, sredina + 45, visina + 40);
                            g.DrawLine(olovka, sredina + 45, visina + 40, sredina + 45, visina + 33);
                            g.DrawLine(olovka, sredina + 45, visina + 40, sredina + 38, visina + 40);
                            visina += 40;

                            g.DrawLine(olovka, sredina + 45, visina + 20, sredina + 20, visina + 45);
                            g.DrawLine(olovka, sredina + 20, visina + 45, sredina + 20, visina + 38);
                            g.DrawLine(olovka, sredina + 20, visina + 45, sredina + 27, visina + 45);
                            visina -= 40;

                            brojElsa++;
                        }
                        else if (brojElsa == 2 || graf[i] == "case" && caseBrojac == 3)
                        {
                            caseBrojac++;
                            Popuni(g, sredina - 80, visina + 40);
                            g.DrawEllipse(olovka, sredina - 80, visina + 40, 20, 20);

                            g.DrawLine(olovka, sredina, visina + 10, sredina - 65, visina + 40);
                            g.DrawLine(olovka, sredina - 65, visina + 40, sredina - 62, visina + 33);
                            g.DrawLine(olovka, sredina - 65, visina + 40, sredina - 56, visina + 42);
                            visina += 40;

                            g.DrawLine(olovka, sredina - 65, visina + 20, sredina, visina + 50);
                            //g.DrawLine(olovka, sredina, visina + 50, sredina-2, visina + 35);
                            g.DrawLine(olovka, sredina, visina + 50, sredina - 7, visina + 53);
                            visina -= 40;

                            brojElsa++;
                        }
                        else if (brojElsa == 3 || graf[i] == "case" && caseBrojac == 4)
                        {
                            caseBrojac++;
                            Popuni(g, sredina + 80, visina + 40);
                            g.DrawEllipse(olovka, sredina + 80, visina + 40, 20, 20);

                            g.DrawLine(olovka, sredina + 20, visina + 10, sredina + 85, visina + 40);
                            g.DrawLine(olovka, sredina + 85, visina + 40, sredina + 83, visina + 33);
                            g.DrawLine(olovka, sredina + 85, visina + 40, sredina + 76, visina + 42);
                            visina += 40;

                            g.DrawLine(olovka, sredina + 85, visina + 20, sredina + 20, visina + 50);
                            //g.DrawLine(olovka, sredina + 20, visina + 50, sredina + 20, visina + 68);
                            g.DrawLine(olovka, sredina + 20, visina + 50, sredina + 27, visina + 53);
                            visina -= 40;

                            brojElsa++;
                        }
                        else if (brojElsa == 4)
                        {
                            MessageBox.Show("Niste postovali pravila o maksimalno 5 if else struktura");
                            this.Close();
                        }
                    }
                    if (graf[graf.Count - 1] == "if" && i == graf.Count - 1)
                    {
                        g.DrawArc(olovka, sredina - 25, visina + 10, 50, 80, 90, 180);
                        g.DrawLine(olovka, sredina, visina + 90, sredina - 5, visina + 95);
                        g.DrawLine(olovka, sredina, visina + 90, sredina - 5, visina + 83);
                    }
                    if (graf[i] == "else")
                    {
                        brojElsa = 0;
                    }

                    if (graf[i] == "petlja")
                    {
                        
                        Popuni(g, sredina, visina);
                        g.DrawEllipse(olovka, sredina, visina, 20, 20);
                        g.DrawLine(olovka, sredina + 10, visina + 20, sredina + 10, visina + 40);
                        g.DrawLine(olovka, sredina + 10, visina + 40, sredina + 5, visina + 35);
                        g.DrawLine(olovka, sredina + 10, visina + 40, sredina + 15, visina + 35);
                        visina += 40;
                    }
                    else if (graf[i] == "endPetlja")
                    {
                        visina += 120;
                        Popuni(g, sredina, visina);
                        g.DrawEllipse(olovka, sredina, visina, 20, 20);
                        g.DrawLine(olovka, sredina + 10, visina - 20, sredina + 10, visina);
                        g.DrawLine(olovka, sredina + 10, visina, sredina + 5, visina - 5);
                        g.DrawLine(olovka, sredina + 10, visina, sredina + 15, visina - 5);

                        visina += 40;
                        Popuni(g, sredina, visina);
                        g.DrawEllipse(olovka, sredina, visina, 20, 20);
                        g.DrawLine(olovka, sredina + 10, visina - 20, sredina + 10, visina);
                        g.DrawLine(olovka, sredina + 10, visina, sredina + 5, visina - 5);
                        g.DrawLine(olovka, sredina + 10, visina, sredina + 15, visina - 5);
                    }
                
                }
                base.OnPaint(e);
                //g.DrawLine(olovka, 0, 0, 100, 100);
                //g.DrawEllipse(olovka, 50, 50, 50, 50);
            }
             * */
        # endregion

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int sredina = e.ClipRectangle.Width / 2;
            int visina = 10;
            Pen olovka = new Pen(Color.Black, 3);

            int brojacGrananja = 0, visinaPetlje1 = 0, visinaPetlje2 = 0;
            bool prvaKomanda = true;
            bool samIf = false;

            foreach (string komanda in komande)
            {
                if (komanda == "grananje")
                {
                    if (brojacGrananja == 0)
                    {
                        if (true == samIf)
                        {
                            g.DrawArc(olovka, sredina - 35, visina - 90, 50, 80, 90, 180);
                            g.DrawLine(olovka, sredina - 10, visina - 10, sredina - 15, visina - 15);
                            g.DrawLine(olovka, sredina - 10, visina - 10, sredina - 15, visina - 5);
                            samIf = false;
                        }
                        samIf = true;

                        visina += 120;

                        if (false == prvaKomanda)
                        {
                            g.DrawLine(olovka, sredina, visina - 120, sredina, visina - 100);
                            g.DrawLine(olovka, sredina, visina - 100, sredina + 5, visina - 105);
                            g.DrawLine(olovka, sredina, visina - 100, sredina - 5, visina - 105);
                        }
                        prvaKomanda = false;
                        //TODO: Obojiti
                        Popuni(g, sredina - 10, visina - 100);
                        g.DrawEllipse(olovka, sredina - 10, visina - 100, 20, 20);
                        g.DrawLine(olovka, sredina, visina - 80, sredina, visina - 60);
                        g.DrawLine(olovka, sredina, visina - 60, sredina + 5, visina - 65);
                        g.DrawLine(olovka, sredina, visina - 60, sredina - 5, visina - 65);

                        Popuni(g, sredina - 10, visina - 60);
                        g.DrawEllipse(olovka, sredina - 10, visina - 60, 20, 20);
                        g.DrawLine(olovka, sredina, visina - 40, sredina, visina - 20);
                        g.DrawLine(olovka, sredina, visina - 20, sredina + 5, visina - 25);
                        g.DrawLine(olovka, sredina, visina - 20, sredina - 5, visina - 25);

                        Popuni(g, sredina - 10, visina - 20);
                        g.DrawEllipse(olovka, sredina - 10, visina - 20, 20, 20);
                    }
                    else if (brojacGrananja == 1)
                    {
                        samIf = false;

                        Popuni(g, sredina - 40, visina - 60);
                        g.DrawEllipse(olovka, sredina - 40, visina - 60, 20, 20);

                        g.DrawLine(olovka, sredina - 5, visina - 80, sredina - 25, visina - 60);
                        g.DrawLine(olovka, sredina - 25, visina - 60, sredina - 25, visina - 67);
                        g.DrawLine(olovka, sredina - 25, visina - 60, sredina - 18, visina - 60);

                        g.DrawLine(olovka, sredina - 25, visina - 40, sredina - 5, visina - 20);
                        g.DrawLine(olovka, sredina - 15, visina - 20, sredina - 5, visina - 18);
                    }
                    else if (brojacGrananja == 2)
                    {
                        samIf = false;

                        Popuni(g, sredina + 20, visina - 60);
                        g.DrawEllipse(olovka, sredina + 20, visina - 60, 20, 20);

                        g.DrawLine(olovka, sredina + 5, visina - 80, sredina + 25, visina - 60);
                        g.DrawLine(olovka, sredina + 25, visina - 60, sredina + 25, visina - 67);
                        g.DrawLine(olovka, sredina + 25, visina - 60, sredina + 18, visina - 60);

                        g.DrawLine(olovka, sredina + 25, visina - 40, sredina + 5, visina - 20);
                        g.DrawLine(olovka, sredina + 15, visina - 20, sredina + 5, visina - 18);
                    }
                    else if (brojacGrananja == 3)
                    {
                        samIf = false;

                        Popuni(g, sredina - 70, visina - 60);
                        g.DrawEllipse(olovka, sredina - 70, visina - 60, 20, 20);

                        g.DrawLine(olovka, sredina - 5, visina - 80, sredina - 55, visina - 60);
                        g.DrawLine(olovka, sredina - 55, visina - 60, sredina - 52, visina - 67);
                        g.DrawLine(olovka, sredina - 55, visina - 60, sredina - 46, visina - 58);

                        g.DrawLine(olovka, sredina - 55, visina - 40, sredina - 10, visina - 14);
                        g.DrawLine(olovka, sredina - 10, visina - 14, sredina - 17, visina - 10);
                    }
                    else if (brojacGrananja == 4)
                    {
                        samIf = false;

                        Popuni(g, sredina + 50, visina - 60);
                        g.DrawEllipse(olovka, sredina + 50, visina - 60, 20, 20);

                        g.DrawLine(olovka, sredina + 5, visina - 80, sredina + 55, visina - 60);
                        g.DrawLine(olovka, sredina + 55, visina - 60, sredina + 52, visina - 67);
                        g.DrawLine(olovka, sredina + 55, visina - 60, sredina + 46, visina - 58);

                        g.DrawLine(olovka, sredina + 55, visina - 40, sredina + 10, visina - 14);
                        g.DrawLine(olovka, sredina + 10, visina - 14, sredina + 17, visina - 10);
                    }

                    brojacGrananja++;
                }
                else if (komanda == "petlja")
                {
                    brojacGrananja = 0;

                    if (true == samIf)
                    {
                        g.DrawArc(olovka, sredina - 35, visina - 90, 50, 80, 90, 180);
                        g.DrawLine(olovka, sredina - 10, visina - 10, sredina - 15, visina - 15);
                        g.DrawLine(olovka, sredina - 10, visina - 10, sredina - 15, visina - 5);
                        samIf = false;
                    }

                    visina += 40;

                    if (false == prvaKomanda)
                    {
                        g.DrawLine(olovka, sredina, visina - 40, sredina, visina - 20);
                        g.DrawLine(olovka, sredina, visina - 20, sredina + 5, visina - 25);
                        g.DrawLine(olovka, sredina, visina - 20, sredina - 5, visina - 25);
                    }
                    prvaKomanda = false;

                    Popuni(g, sredina - 10, visina - 20);
                    g.DrawEllipse(olovka, sredina - 10, visina - 20, 20, 20);

                    if (visinaPetlje1 == 0)
                        visinaPetlje1 = visina - 10;
                    else if (visinaPetlje2 == 0)
                        visinaPetlje2 = visina - 10;
                }
                else if (komanda == "krajPetlje")
                {
                    brojacGrananja = 0;

                    if (true == samIf)
                    {
                        g.DrawArc(olovka, sredina - 35, visina - 90, 50, 80, 90, 180);
                        g.DrawLine(olovka, sredina - 10, visina - 10, sredina - 15, visina - 15);
                        g.DrawLine(olovka, sredina - 10, visina - 10, sredina - 15, visina - 5);
                        samIf = false;
                    }

                    visina += 80;

                    if (visinaPetlje2 != 0)
                    {
                        g.DrawLine(olovka, sredina, visina - 80, sredina, visina - 60);
                        g.DrawLine(olovka, sredina, visina - 60, sredina + 5, visina - 65);
                        g.DrawLine(olovka, sredina, visina - 60, sredina - 5, visina - 65);

                        Popuni(g, sredina - 10, visina - 60);
                        g.DrawEllipse(olovka, sredina - 10, visina - 60, 20, 20);
                        g.DrawArc(olovka, sredina - 50, visinaPetlje2, 120, visina - visinaPetlje2 - 50, -90, 180);
                        g.DrawLine(olovka, sredina + 10, visinaPetlje2, sredina + 15, visinaPetlje2 - 5);
                        g.DrawLine(olovka, sredina + 10, visinaPetlje2, sredina + 15, visinaPetlje2 + 5);

                        Popuni(g, sredina - 10, visina - 20);
                        g.DrawEllipse(olovka, sredina - 10, visina - 20, 20, 20);
                        g.DrawArc(olovka, sredina - 80, visinaPetlje2, 140, visina - visinaPetlje2 - 10, 90, 180);
                        g.DrawLine(olovka, sredina - 10, visina - 10, sredina - 15, visina - 5);
                        g.DrawLine(olovka, sredina - 10, visina - 10, sredina - 15, visina - 15);

                        visinaPetlje2 = 0;
                    }
                    else
                    {
                        g.DrawLine(olovka, sredina, visina - 80, sredina, visina - 60);
                        g.DrawLine(olovka, sredina, visina - 60, sredina + 5, visina - 65);
                        g.DrawLine(olovka, sredina, visina - 60, sredina - 5, visina - 65);

                        Popuni(g, sredina - 10, visina - 60);
                        g.DrawEllipse(olovka, sredina - 10, visina - 60, 20, 20);
                        g.DrawArc(olovka, sredina - 60, visinaPetlje1, 140, visina - visinaPetlje1 - 50, -90, 180);
                        g.DrawLine(olovka, sredina + 10, visinaPetlje1, sredina + 15, visinaPetlje1 - 5);
                        g.DrawLine(olovka, sredina + 10, visinaPetlje1, sredina + 15, visinaPetlje1 + 5);

                        Popuni(g, sredina - 10, visina - 20);
                        g.DrawEllipse(olovka, sredina - 10, visina - 20, 20, 20);
                        g.DrawArc(olovka, sredina - 90, visinaPetlje1, 160, visina - visinaPetlje1 - 10, 90, 180);
                        g.DrawLine(olovka, sredina - 10, visina - 10, sredina - 15, visina - 5);
                        g.DrawLine(olovka, sredina - 10, visina - 10, sredina - 15, visina - 15);

                        visinaPetlje1 = 0;
                    }
                }
            }

            if (true == samIf)
            {
                g.DrawArc(olovka, sredina - 35, visina - 90, 50, 80, 90, 180);
                g.DrawLine(olovka, sredina - 10, visina - 10, sredina - 15, visina - 15);
                g.DrawLine(olovka, sredina - 10, visina - 10, sredina - 15, visina - 5);
            }

            base.OnPaint(e);
        }

		private void frmGraf_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				this.Close ();
			}
		}
    }
}