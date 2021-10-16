namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.h1 = new System.Windows.Forms.PictureBox();
            this.h3 = new System.Windows.Forms.PictureBox();
            this.h5 = new System.Windows.Forms.PictureBox();
            this.h2 = new System.Windows.Forms.PictureBox();
            this.h4 = new System.Windows.Forms.PictureBox();
            this.h6 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ptaszek = new System.Windows.Forms.PictureBox();
            this.t1 = new System.Windows.Forms.PictureBox();
            this.t2 = new System.Windows.Forms.PictureBox();
            this.t3 = new System.Windows.Forms.PictureBox();
            this.t5 = new System.Windows.Forms.PictureBox();
            this.t4 = new System.Windows.Forms.PictureBox();
            this.koniec = new System.Windows.Forms.Label();
            this.punkty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptaszek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 453);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(965, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // h1
            // 
            this.h1.Image = ((System.Drawing.Image)(resources.GetObject("h1.Image")));
            this.h1.Location = new System.Drawing.Point(252, 315);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(107, 253);
            this.h1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.h1.TabIndex = 6;
            this.h1.TabStop = false;
            // 
            // h3
            // 
            this.h3.Image = ((System.Drawing.Image)(resources.GetObject("h3.Image")));
            this.h3.Location = new System.Drawing.Point(566, 378);
            this.h3.Name = "h3";
            this.h3.Size = new System.Drawing.Size(107, 190);
            this.h3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.h3.TabIndex = 7;
            this.h3.TabStop = false;
            // 
            // h5
            // 
            this.h5.Image = ((System.Drawing.Image)(resources.GetObject("h5.Image")));
            this.h5.Location = new System.Drawing.Point(856, 348);
            this.h5.Name = "h5";
            this.h5.Size = new System.Drawing.Size(107, 220);
            this.h5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.h5.TabIndex = 8;
            this.h5.TabStop = false;
            // 
            // h2
            // 
            this.h2.Image = ((System.Drawing.Image)(resources.GetObject("h2.Image")));
            this.h2.Location = new System.Drawing.Point(252, -3);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(107, 179);
            this.h2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.h2.TabIndex = 9;
            this.h2.TabStop = false;
            // 
            // h4
            // 
            this.h4.Image = ((System.Drawing.Image)(resources.GetObject("h4.Image")));
            this.h4.Location = new System.Drawing.Point(566, -3);
            this.h4.Name = "h4";
            this.h4.Size = new System.Drawing.Size(107, 213);
            this.h4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.h4.TabIndex = 10;
            this.h4.TabStop = false;
            // 
            // h6
            // 
            this.h6.Image = ((System.Drawing.Image)(resources.GetObject("h6.Image")));
            this.h6.Location = new System.Drawing.Point(856, -3);
            this.h6.Name = "h6";
            this.h6.Size = new System.Drawing.Size(107, 163);
            this.h6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.h6.TabIndex = 11;
            this.h6.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ptaszek
            // 
            this.ptaszek.BackColor = System.Drawing.Color.Aqua;
            this.ptaszek.Image = ((System.Drawing.Image)(resources.GetObject("ptaszek.Image")));
            this.ptaszek.Location = new System.Drawing.Point(18, 235);
            this.ptaszek.Name = "ptaszek";
            this.ptaszek.Size = new System.Drawing.Size(53, 47);
            this.ptaszek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptaszek.TabIndex = 12;
            this.ptaszek.TabStop = false;
            // 
            // t1
            // 
            this.t1.Image = ((System.Drawing.Image)(resources.GetObject("t1.Image")));
            this.t1.Location = new System.Drawing.Point(18, 384);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(60, 69);
            this.t1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t1.TabIndex = 1;
            this.t1.TabStop = false;
            // 
            // t2
            // 
            this.t2.Image = ((System.Drawing.Image)(resources.GetObject("t2.Image")));
            this.t2.Location = new System.Drawing.Point(191, 365);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(64, 89);
            this.t2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t2.TabIndex = 2;
            this.t2.TabStop = false;
            // 
            // t3
            // 
            this.t3.Image = ((System.Drawing.Image)(resources.GetObject("t3.Image")));
            this.t3.Location = new System.Drawing.Point(408, 401);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(60, 52);
            this.t3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t3.TabIndex = 3;
            this.t3.TabStop = false;
            // 
            // t5
            // 
            this.t5.Image = ((System.Drawing.Image)(resources.GetObject("t5.Image")));
            this.t5.Location = new System.Drawing.Point(841, 355);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(64, 98);
            this.t5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t5.TabIndex = 4;
            this.t5.TabStop = false;
            // 
            // t4
            // 
            this.t4.Image = ((System.Drawing.Image)(resources.GetObject("t4.Image")));
            this.t4.Location = new System.Drawing.Point(640, 384);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(60, 68);
            this.t4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t4.TabIndex = 5;
            this.t4.TabStop = false;
            // 
            // koniec
            // 
            this.koniec.AutoSize = true;
            this.koniec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koniec.Location = new System.Drawing.Point(408, 222);
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(292, 87);
            this.koniec.TabIndex = 13;
            this.koniec.Text = "Koniec Gry\r\nF1 - zacznij od początku\r\nEsc - wyjście";
            this.koniec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // punkty
            // 
            this.punkty.AutoSize = true;
            this.punkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punkty.Location = new System.Drawing.Point(12, 9);
            this.punkty.Name = "punkty";
            this.punkty.Size = new System.Drawing.Size(24, 25);
            this.punkty.TabIndex = 14;
            this.punkty.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(960, 570);
            this.Controls.Add(this.punkty);
            this.Controls.Add(this.koniec);
            this.Controls.Add(this.ptaszek);
            this.Controls.Add(this.h6);
            this.Controls.Add(this.h4);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.h5);
            this.Controls.Add(this.h3);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptaszek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox h1;
        private System.Windows.Forms.PictureBox h3;
        private System.Windows.Forms.PictureBox h5;
        private System.Windows.Forms.PictureBox h2;
        private System.Windows.Forms.PictureBox h4;
        private System.Windows.Forms.PictureBox h6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox ptaszek;
        private System.Windows.Forms.PictureBox t1;
        private System.Windows.Forms.PictureBox t2;
        private System.Windows.Forms.PictureBox t3;
        private System.Windows.Forms.PictureBox t5;
        private System.Windows.Forms.PictureBox t4;
        private System.Windows.Forms.Label koniec;
        private System.Windows.Forms.Label punkty;
    }
}

