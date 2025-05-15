namespace GRADINGSYSTEM
{
    partial class ABOUT
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAboutMain = new System.Windows.Forms.Panel();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblDP = new System.Windows.Forms.Label();
            this.pnlAboutMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAboutMain
            // 
            this.pnlAboutMain.Controls.Add(this.lblDP);
            this.pnlAboutMain.Controls.Add(this.lblOwner);
            this.pnlAboutMain.Location = new System.Drawing.Point(93, 64);
            this.pnlAboutMain.Name = "pnlAboutMain";
            this.pnlAboutMain.Size = new System.Drawing.Size(413, 427);
            this.pnlAboutMain.TabIndex = 0;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.ForeColor = System.Drawing.Color.White;
            this.lblOwner.Location = new System.Drawing.Point(32, 37);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(354, 31);
            this.lblOwner.TabIndex = 0;
            this.lblOwner.Text = "Designer and Programmer";
            // 
            // lblDP
            // 
            this.lblDP.AutoSize = true;
            this.lblDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDP.ForeColor = System.Drawing.Color.White;
            this.lblDP.Location = new System.Drawing.Point(58, 109);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(76, 25);
            this.lblDP.TabIndex = 1;
            this.lblDP.Text = "label1";
            // 
            // ABOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlAboutMain);
            this.Name = "ABOUT";
            this.Size = new System.Drawing.Size(584, 626);
            this.Load += new System.EventHandler(this.ABOUT_Load);
            this.pnlAboutMain.ResumeLayout(false);
            this.pnlAboutMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAboutMain;
        private System.Windows.Forms.Label lblDP;
        private System.Windows.Forms.Label lblOwner;
    }
}
