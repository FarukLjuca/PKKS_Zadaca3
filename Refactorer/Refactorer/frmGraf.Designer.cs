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
            this.pbxGraf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGraf)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxGraf
            // 
            this.pbxGraf.Location = new System.Drawing.Point(12, 12);
            this.pbxGraf.Name = "pbxGraf";
            this.pbxGraf.Size = new System.Drawing.Size(260, 238);
            this.pbxGraf.TabIndex = 0;
            this.pbxGraf.TabStop = false;
            // 
            // frmGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pbxGraf);
            this.Name = "frmGraf";
            this.Text = "Graf";
            this.Load += new System.EventHandler(this.frmGraf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGraf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGraf;
    }
}