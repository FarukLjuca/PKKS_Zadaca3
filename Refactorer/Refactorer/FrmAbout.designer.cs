namespace Refactorer
{
	partial class FrmAbout
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
			this.RTB = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// RTB
			// 
			this.RTB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RTB.Location = new System.Drawing.Point(0, 0);
			this.RTB.Name = "RTB";
			this.RTB.ReadOnly = true;
			this.RTB.Size = new System.Drawing.Size(581, 463);
			this.RTB.TabIndex = 1;
			this.RTB.Text = "";
			// 
			// FrmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 463);
			this.Controls.Add(this.RTB);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "FrmAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dobrodošli | unaprijad hvala na čitanju :)";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FrmAbout_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Klick);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox RTB;
	}
}