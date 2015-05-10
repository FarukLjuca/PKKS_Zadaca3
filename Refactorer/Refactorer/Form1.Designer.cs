namespace Refactorer
{
    partial class Form1
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMcCabe = new System.Windows.Forms.Button();
            this.tbxKod = new System.Windows.Forms.TextBox();
            this.btnHalstead = new System.Windows.Forms.Button();
            this.btnInformacioniTok = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbxKod);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unesite kod ispod:";
            // 
            // btnMcCabe
            // 
            this.btnMcCabe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMcCabe.Location = new System.Drawing.Point(6, 19);
            this.btnMcCabe.Name = "btnMcCabe";
            this.btnMcCabe.Size = new System.Drawing.Size(199, 23);
            this.btnMcCabe.TabIndex = 1;
            this.btnMcCabe.Text = "Izračunaj McCabe metriku";
            this.btnMcCabe.UseVisualStyleBackColor = true;
            // 
            // tbxKod
            // 
            this.tbxKod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxKod.Location = new System.Drawing.Point(6, 19);
            this.tbxKod.Multiline = true;
            this.tbxKod.Name = "tbxKod";
            this.tbxKod.Size = new System.Drawing.Size(396, 286);
            this.tbxKod.TabIndex = 2;
            // 
            // btnHalstead
            // 
            this.btnHalstead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHalstead.Location = new System.Drawing.Point(6, 48);
            this.btnHalstead.Name = "btnHalstead";
            this.btnHalstead.Size = new System.Drawing.Size(199, 23);
            this.btnHalstead.TabIndex = 2;
            this.btnHalstead.Text = "Izračunaj Halstead metriku";
            this.btnHalstead.UseVisualStyleBackColor = true;
            // 
            // btnInformacioniTok
            // 
            this.btnInformacioniTok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInformacioniTok.Location = new System.Drawing.Point(6, 77);
            this.btnInformacioniTok.Name = "btnInformacioniTok";
            this.btnInformacioniTok.Size = new System.Drawing.Size(199, 23);
            this.btnInformacioniTok.TabIndex = 3;
            this.btnInformacioniTok.Text = "Izračunaj Metriku informacionog toka";
            this.btnInformacioniTok.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnMcCabe);
            this.groupBox2.Controls.Add(this.btnInformacioniTok);
            this.groupBox2.Controls.Add(this.btnHalstead);
            this.groupBox2.Location = new System.Drawing.Point(426, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 311);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odaberite akciju:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refactorer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxKod;
        private System.Windows.Forms.Button btnMcCabe;
        private System.Windows.Forms.Button btnHalstead;
        private System.Windows.Forms.Button btnInformacioniTok;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

