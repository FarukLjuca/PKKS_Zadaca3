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
        private List<String> graf;

        public frmGraf(List<String> graf)
        {
            InitializeComponent();
            this.graf = graf;
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
			Brush boja = new System.Drawing.Drawing2D.LinearGradientBrush(
				new Rectangle (x, y, w, h),
				Color.DarkGreen, Color.Yellow,
				System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
			g.FillEllipse (boja, x, y, w, h);
		}

        private void Crtaj(object sender, PaintEventArgs e)
        {
			Graphics g = e.Graphics;
			int sredina = e.ClipRectangle.Width / 2;
			bool prviIf = true;
			int visina = 20;
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen olovka = new Pen(Color.Black, 3);

                int brojElsa = 0;

                foreach (String komanda in graf)
                {
                    if (komanda == "if") {

                        if (prviIf != true)
                        {
                            visina += 120;

                            g.DrawLine(olovka, sredina + 10, visina - 20, sredina + 10, visina);
                            g.DrawLine(olovka, sredina + 10, visina, sredina + 5, visina - 5);
                            g.DrawLine(olovka, sredina + 10, visina, sredina + 15, visina - 5);
                        }
                        prviIf = false;
						Popuni (g, sredina, visina); //dodati i parametre ako se promijeni ovo 20, 20
                        g.DrawEllipse(olovka, sredina, visina, 20, 20);
                        g.DrawLine(olovka, sredina+10, visina + 20, sredina+10, visina + 40);
                        g.DrawLine(olovka, sredina + 10, visina + 40, sredina + 5, visina + 35);
                        g.DrawLine(olovka, sredina + 10, visina + 40, sredina + 15, visina + 35);
                        visina += 40;

						Popuni (g, sredina, visina); //dodati i parametre ako se promijeni ovo 20, 20
                        g.DrawEllipse(olovka, sredina, visina, 20, 20);
                        g.DrawLine(olovka, sredina + 10, visina + 20, sredina + 10, visina + 40);
                        g.DrawLine(olovka, sredina + 10, visina + 40, sredina + 5, visina + 35);
                        g.DrawLine(olovka, sredina + 10, visina + 40, sredina + 15, visina + 35);
                        visina += 40;
						Popuni (g, sredina, visina); //dodati i parametre ako se promijeni ovo 20, 20
                        g.DrawEllipse(olovka, sredina, visina, 20, 20);
                        visina -= 80;
                    }
                    else if (komanda == "elseif" || komanda == "else")
                    {
                        if (brojElsa == 0)
                        {
							Popuni (g, sredina - 40, visina + 40); //dodati i parametre ako se promijeni ovo 20, 20
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
                        else if (brojElsa == 1)
                        {
							Popuni (g, sredina + 40, visina + 40); //dodati i parametre ako se promijeni ovo 20, 20
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
                        else if (brojElsa == 2)
                        {
							Popuni (g, sredina - 80, visina + 40); //dodati i parametre ako se promijeni ovo 20, 20
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
                        else if (brojElsa == 3)
                        {
							Popuni (g, sredina + 80, visina + 40); //dodati i parametre ako se promijeni ovo 20, 20
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
                    if (komanda == "else")
                    {
                        brojElsa = 0;
                    }
                }
				base.OnPaint (e);
                //g.DrawLine(olovka, 0, 0, 100, 100);
                //g.DrawEllipse(olovka, 50, 50, 50, 50);
            }
        }
    }
}
