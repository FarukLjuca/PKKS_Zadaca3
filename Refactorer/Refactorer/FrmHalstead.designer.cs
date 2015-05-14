namespace Refactorer
{
	partial class FrmHalstead
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHalstead));
			this.label1 = new System.Windows.Forms.Label();
			this.BtnOperandi = new System.Windows.Forms.Button();
			this.BtnOperatori = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.N20 = new System.Windows.Forms.TextBox();
			this.df = new System.Windows.Forms.Label();
			this.N10 = new System.Windows.Forms.TextBox();
			this.n2 = new System.Windows.Forms.TextBox();
			this.n1 = new System.Windows.Forms.TextBox();
			this.av = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.dfg = new System.Windows.Forms.Label();
			this.fgb = new System.Windows.Forms.Label();
			this.sdgf = new System.Windows.Forms.Label();
			this.D = new System.Windows.Forms.TextBox();
			this.V = new System.Windows.Forms.TextBox();
			this.N0 = new System.Windows.Forms.TextBox();
			this.n = new System.Windows.Forms.TextBox();
			this.fdx = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.ert = new System.Windows.Forms.Label();
			this.rtft = new System.Windows.Forms.Label();
			this.dfs = new System.Windows.Forms.Label();
			this.er = new System.Windows.Forms.Label();
			this.B = new System.Windows.Forms.TextBox();
			this.T = new System.Windows.Forms.TextBox();
			this.E = new System.Windows.Forms.TextBox();
			this.L = new System.Windows.Forms.TextBox();
			this.TT = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(5, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(607, 84);
			this.label1.TabIndex = 0;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// BtnOperandi
			// 
			this.BtnOperandi.Location = new System.Drawing.Point(535, 95);
			this.BtnOperandi.Name = "BtnOperandi";
			this.BtnOperandi.Size = new System.Drawing.Size(75, 23);
			this.BtnOperandi.TabIndex = 1;
			this.BtnOperandi.Text = "Operandi";
			this.BtnOperandi.UseVisualStyleBackColor = true;
			this.BtnOperandi.Click += new System.EventHandler(this.BtnOperandi_Click);
			// 
			// BtnOperatori
			// 
			this.BtnOperatori.Location = new System.Drawing.Point(455, 95);
			this.BtnOperatori.Name = "BtnOperatori";
			this.BtnOperatori.Size = new System.Drawing.Size(75, 23);
			this.BtnOperatori.TabIndex = 2;
			this.BtnOperatori.Text = "Operatori";
			this.BtnOperatori.UseVisualStyleBackColor = true;
			this.BtnOperatori.Click += new System.EventHandler(this.BtnOperatori_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MintCream;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.linkLabel2);
			this.panel1.Controls.Add(this.linkLabel1);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Location = new System.Drawing.Point(5, 125);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(605, 225);
			this.panel1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new System.Drawing.Point(525, 190);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 28);
			this.button1.TabIndex = 17;
			this.button1.Text = "Izađi";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(5, 205);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(304, 14);
			this.linkLabel2.TabIndex = 16;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Lista svih OPERATORA sa brojem njihovog pojavljivanja";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(5, 180);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(304, 14);
			this.linkLabel1.TabIndex = 15;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Lista svih OPERANADA sa brojem njihovog pojavljivanja";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.N20);
			this.panel6.Controls.Add(this.df);
			this.panel6.Controls.Add(this.N10);
			this.panel6.Controls.Add(this.n2);
			this.panel6.Controls.Add(this.n1);
			this.panel6.Controls.Add(this.av);
			this.panel6.Controls.Add(this.label20);
			this.panel6.Controls.Add(this.label21);
			this.panel6.Location = new System.Drawing.Point(5, 5);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(196, 165);
			this.panel6.TabIndex = 14;
			// 
			// N20
			// 
			this.N20.BackColor = System.Drawing.Color.White;
			this.N20.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.N20.Location = new System.Drawing.Point(55, 125);
			this.N20.Name = "N20";
			this.N20.ReadOnly = true;
			this.N20.Size = new System.Drawing.Size(130, 33);
			this.N20.TabIndex = 11;
			this.N20.Text = "12";
			this.N20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// df
			// 
			this.df.AutoSize = true;
			this.df.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.df.Location = new System.Drawing.Point(5, 130);
			this.df.Name = "df";
			this.df.Size = new System.Drawing.Size(41, 25);
			this.df.TabIndex = 9;
			this.df.Text = "N2";
			this.df.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TT.SetToolTip(this.df, "Broj ukupnih brojeva operanada");
			// 
			// N10
			// 
			this.N10.BackColor = System.Drawing.Color.White;
			this.N10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.N10.Location = new System.Drawing.Point(55, 85);
			this.N10.Name = "N10";
			this.N10.ReadOnly = true;
			this.N10.Size = new System.Drawing.Size(130, 33);
			this.N10.TabIndex = 8;
			this.N10.Text = "12";
			this.N10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// n2
			// 
			this.n2.BackColor = System.Drawing.Color.White;
			this.n2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.n2.Location = new System.Drawing.Point(55, 45);
			this.n2.Name = "n2";
			this.n2.ReadOnly = true;
			this.n2.Size = new System.Drawing.Size(130, 33);
			this.n2.TabIndex = 7;
			this.n2.Text = "12";
			this.n2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// n1
			// 
			this.n1.BackColor = System.Drawing.Color.White;
			this.n1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.n1.Location = new System.Drawing.Point(55, 5);
			this.n1.Name = "n1";
			this.n1.ReadOnly = true;
			this.n1.Size = new System.Drawing.Size(130, 33);
			this.n1.TabIndex = 6;
			this.n1.Text = "12";
			this.n1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// av
			// 
			this.av.AutoSize = true;
			this.av.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.av.Location = new System.Drawing.Point(5, 85);
			this.av.Name = "av";
			this.av.Size = new System.Drawing.Size(41, 25);
			this.av.TabIndex = 2;
			this.av.Text = "N1";
			this.av.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TT.SetToolTip(this.av, "Broj ukupnih brojeva operatora");
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label20.Location = new System.Drawing.Point(5, 45);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(38, 25);
			this.label20.TabIndex = 1;
			this.label20.Text = "n2";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TT.SetToolTip(this.label20, "Broj operanada");
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label21.Location = new System.Drawing.Point(5, 10);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(38, 25);
			this.label21.TabIndex = 0;
			this.label21.Text = "n1";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TT.SetToolTip(this.label21, "Broj operatora");
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.dfg);
			this.panel5.Controls.Add(this.fgb);
			this.panel5.Controls.Add(this.sdgf);
			this.panel5.Controls.Add(this.D);
			this.panel5.Controls.Add(this.V);
			this.panel5.Controls.Add(this.N0);
			this.panel5.Controls.Add(this.n);
			this.panel5.Controls.Add(this.fdx);
			this.panel5.Location = new System.Drawing.Point(205, 5);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(196, 165);
			this.panel5.TabIndex = 14;
			// 
			// dfg
			// 
			this.dfg.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dfg.Location = new System.Drawing.Point(5, 130);
			this.dfg.Name = "dfg";
			this.dfg.Size = new System.Drawing.Size(38, 25);
			this.dfg.TabIndex = 14;
			this.dfg.Text = "D";
			this.dfg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TT.SetToolTip(this.dfg, "Nivo poteškoće: D = (n1 / 2.0) * (N2 / 2.0)");
			// 
			// fgb
			// 
			this.fgb.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.fgb.Location = new System.Drawing.Point(5, 85);
			this.fgb.Name = "fgb";
			this.fgb.Size = new System.Drawing.Size(38, 25);
			this.fgb.TabIndex = 13;
			this.fgb.Text = "V";
			this.fgb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TT.SetToolTip(this.fgb, "Volumen programa: V = N * log2 (n)");
			// 
			// sdgf
			// 
			this.sdgf.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.sdgf.Location = new System.Drawing.Point(5, 45);
			this.sdgf.Name = "sdgf";
			this.sdgf.Size = new System.Drawing.Size(38, 25);
			this.sdgf.TabIndex = 12;
			this.sdgf.Text = "N";
			this.sdgf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TT.SetToolTip(this.sdgf, "Dužina programa (N1 + N2)");
			// 
			// D
			// 
			this.D.BackColor = System.Drawing.Color.White;
			this.D.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.D.Location = new System.Drawing.Point(55, 125);
			this.D.Name = "D";
			this.D.ReadOnly = true;
			this.D.Size = new System.Drawing.Size(130, 33);
			this.D.TabIndex = 11;
			this.D.Text = "12";
			this.D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// V
			// 
			this.V.BackColor = System.Drawing.Color.White;
			this.V.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.V.Location = new System.Drawing.Point(55, 85);
			this.V.Name = "V";
			this.V.ReadOnly = true;
			this.V.Size = new System.Drawing.Size(130, 33);
			this.V.TabIndex = 8;
			this.V.Text = "12";
			this.V.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// N0
			// 
			this.N0.BackColor = System.Drawing.Color.White;
			this.N0.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.N0.Location = new System.Drawing.Point(55, 45);
			this.N0.Name = "N0";
			this.N0.ReadOnly = true;
			this.N0.Size = new System.Drawing.Size(130, 33);
			this.N0.TabIndex = 7;
			this.N0.Text = "12";
			this.N0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// n
			// 
			this.n.BackColor = System.Drawing.Color.White;
			this.n.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.n.Location = new System.Drawing.Point(55, 5);
			this.n.Name = "n";
			this.n.ReadOnly = true;
			this.n.Size = new System.Drawing.Size(130, 33);
			this.n.TabIndex = 6;
			this.n.Text = "12";
			this.n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// fdx
			// 
			this.fdx.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.fdx.Location = new System.Drawing.Point(5, 10);
			this.fdx.Name = "fdx";
			this.fdx.Size = new System.Drawing.Size(38, 25);
			this.fdx.TabIndex = 0;
			this.fdx.Text = "n";
			this.fdx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TT.SetToolTip(this.fdx, "Dužina vokabulara (n1 + n2) - broj jedinstvenih operatora i operanada");
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.ert);
			this.panel4.Controls.Add(this.rtft);
			this.panel4.Controls.Add(this.dfs);
			this.panel4.Controls.Add(this.er);
			this.panel4.Controls.Add(this.B);
			this.panel4.Controls.Add(this.T);
			this.panel4.Controls.Add(this.E);
			this.panel4.Controls.Add(this.L);
			this.panel4.Location = new System.Drawing.Point(405, 5);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(196, 165);
			this.panel4.TabIndex = 13;
			// 
			// ert
			// 
			this.ert.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ert.Location = new System.Drawing.Point(5, 130);
			this.ert.Name = "ert";
			this.ert.Size = new System.Drawing.Size(38, 25);
			this.ert.TabIndex = 18;
			this.ert.Text = "B";
			this.ert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TT.SetToolTip(this.ert, "Broj isporučenih bugova: B = E ^ (2 / 3) / 3000");
			// 
			// rtft
			// 
			this.rtft.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.rtft.Location = new System.Drawing.Point(5, 85);
			this.rtft.Name = "rtft";
			this.rtft.Size = new System.Drawing.Size(38, 25);
			this.rtft.TabIndex = 17;
			this.rtft.Text = "T";
			this.rtft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TT.SetToolTip(this.rtft, "Vrijeme implementacije: T = E / Halstead_Vrijeme = E / 18");
			// 
			// dfs
			// 
			this.dfs.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dfs.Location = new System.Drawing.Point(5, 45);
			this.dfs.Name = "dfs";
			this.dfs.Size = new System.Drawing.Size(38, 25);
			this.dfs.TabIndex = 16;
			this.dfs.Text = "E";
			this.dfs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TT.SetToolTip(this.dfs, "Napor implementacije: E = V * D");
			// 
			// er
			// 
			this.er.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.er.Location = new System.Drawing.Point(5, 10);
			this.er.Name = "er";
			this.er.Size = new System.Drawing.Size(38, 25);
			this.er.TabIndex = 15;
			this.er.Text = "L";
			this.er.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TT.SetToolTip(this.er, "Nivo programa: L = 1 / D");
			// 
			// B
			// 
			this.B.BackColor = System.Drawing.Color.White;
			this.B.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.B.Location = new System.Drawing.Point(55, 125);
			this.B.Name = "B";
			this.B.ReadOnly = true;
			this.B.Size = new System.Drawing.Size(130, 33);
			this.B.TabIndex = 11;
			this.B.Text = "12";
			this.B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// T
			// 
			this.T.BackColor = System.Drawing.Color.White;
			this.T.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.T.Location = new System.Drawing.Point(55, 85);
			this.T.Name = "T";
			this.T.ReadOnly = true;
			this.T.Size = new System.Drawing.Size(130, 33);
			this.T.TabIndex = 8;
			this.T.Text = "12";
			this.T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// E
			// 
			this.E.BackColor = System.Drawing.Color.White;
			this.E.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.E.Location = new System.Drawing.Point(55, 45);
			this.E.Name = "E";
			this.E.ReadOnly = true;
			this.E.Size = new System.Drawing.Size(130, 33);
			this.E.TabIndex = 7;
			this.E.Text = "12";
			this.E.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// L
			// 
			this.L.BackColor = System.Drawing.Color.White;
			this.L.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.L.Location = new System.Drawing.Point(55, 5);
			this.L.Name = "L";
			this.L.ReadOnly = true;
			this.L.Size = new System.Drawing.Size(130, 33);
			this.L.TabIndex = 6;
			this.L.Text = "12";
			this.L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TT
			// 
			this.TT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.TT.ForeColor = System.Drawing.Color.Yellow;
			// 
			// FrmHalstead
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.button1;
			this.ClientSize = new System.Drawing.Size(614, 354);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.BtnOperatori);
			this.Controls.Add(this.BtnOperandi);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmHalstead";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Halstead metrika";
			this.Load += new System.EventHandler(this.FrmHalstead_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnOperandi;
		private System.Windows.Forms.Button BtnOperatori;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox N20;
		private System.Windows.Forms.Label df;
		private System.Windows.Forms.TextBox N10;
		private System.Windows.Forms.TextBox n2;
		private System.Windows.Forms.TextBox n1;
		private System.Windows.Forms.Label av;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox D;
		private System.Windows.Forms.TextBox V;
		private System.Windows.Forms.TextBox N0;
		private System.Windows.Forms.TextBox n;
		private System.Windows.Forms.Label fdx;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox B;
		private System.Windows.Forms.TextBox T;
		private System.Windows.Forms.TextBox E;
		private System.Windows.Forms.TextBox L;
		private System.Windows.Forms.ToolTip TT;
		private System.Windows.Forms.Label dfg;
		private System.Windows.Forms.Label fgb;
		private System.Windows.Forms.Label sdgf;
		private System.Windows.Forms.Label ert;
		private System.Windows.Forms.Label rtft;
		private System.Windows.Forms.Label dfs;
		private System.Windows.Forms.Label er;
	}
}