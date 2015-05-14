namespace Refactorer
{
    partial class frmGraf
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
			this.pnlGraf = new Refactorer.SpecPanel();
			this.SuspendLayout();
			// 
			// pnlGraf
			// 
			this.pnlGraf.BackColor = System.Drawing.Color.White;
			this.pnlGraf.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlGraf.Location = new System.Drawing.Point(0, 0);
			this.pnlGraf.Name = "pnlGraf";
			this.pnlGraf.Size = new System.Drawing.Size(321, 348);
			this.pnlGraf.TabIndex = 0;
			// 
			// frmGraf
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 348);
			this.Controls.Add(this.pnlGraf);
			this.KeyPreview = true;
			this.Name = "frmGraf";
			this.Text = "Graf";
			this.Load += new System.EventHandler(this.frmGraf_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGraf_KeyDown);
			this.ResumeLayout(false);

        }

        #endregion

        private SpecPanel pnlGraf;

    }
}