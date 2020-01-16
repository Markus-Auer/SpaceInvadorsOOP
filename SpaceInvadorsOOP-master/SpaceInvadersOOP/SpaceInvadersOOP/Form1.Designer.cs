namespace SpaceInvadersOOP
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pBplayer = new System.Windows.Forms.PictureBox();
            this.positionXplayer = new System.Windows.Forms.Label();
            this.positionXplayer2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pBplayer
            // 
            this.pBplayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBplayer.Location = new System.Drawing.Point(356, 357);
            this.pBplayer.Name = "pBplayer";
            this.pBplayer.Size = new System.Drawing.Size(22, 24);
            this.pBplayer.TabIndex = 0;
            this.pBplayer.TabStop = false;
            // 
            // positionXplayer
            // 
            this.positionXplayer.AutoSize = true;
            this.positionXplayer.Location = new System.Drawing.Point(262, 100);
            this.positionXplayer.Name = "positionXplayer";
            this.positionXplayer.Size = new System.Drawing.Size(44, 13);
            this.positionXplayer.TabIndex = 1;
            this.positionXplayer.Text = "Position";
            // 
            // positionXplayer2
            // 
            this.positionXplayer2.AutoSize = true;
            this.positionXplayer2.Location = new System.Drawing.Point(378, 219);
            this.positionXplayer2.Name = "positionXplayer2";
            this.positionXplayer2.Size = new System.Drawing.Size(44, 13);
            this.positionXplayer2.TabIndex = 2;
            this.positionXplayer2.Text = "Position";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.positionXplayer2);
            this.Controls.Add(this.positionXplayer);
            this.Controls.Add(this.pBplayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pBplayer;
        private System.Windows.Forms.Label positionXplayer;
        private System.Windows.Forms.Label positionXplayer2;
    }
}

