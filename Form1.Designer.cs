namespace macchinine
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.bgw1 = new System.ComponentModel.BackgroundWorker();
            this.bgw2 = new System.ComponentModel.BackgroundWorker();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).BeginInit();
            this.SuspendLayout();
            // 
            // pct1
            // 
            this.pct1.Image = global::macchinine.Properties.Resources.macchinabianca;
            this.pct1.Location = new System.Drawing.Point(46, 72);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(291, 142);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct1.TabIndex = 2;
            this.pct1.TabStop = false;
            this.pct1.Click += new System.EventHandler(this.pct1_Click);
            // 
            // pct2
            // 
            this.pct2.Image = global::macchinine.Properties.Resources.macchinarossa;
            this.pct2.Location = new System.Drawing.Point(46, 346);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(291, 144);
            this.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct2.TabIndex = 1;
            this.pct2.TabStop = false;
            // 
            // pct3
            // 
            this.pct3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pct3.Image = global::macchinine.Properties.Resources.road_trip_background_10864211;
            this.pct3.Location = new System.Drawing.Point(0, 0);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(1804, 568);
            this.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct3.TabIndex = 0;
            this.pct3.TabStop = false;
            this.pct3.Click += new System.EventHandler(this.pct3_Click);
            // 
            // bgw1
            // 
            this.bgw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw1_DoWork);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(46, 254);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(203, 65);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "avvia";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 568);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pct1);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct3);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct3;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.PictureBox pct1;
        private System.ComponentModel.BackgroundWorker bgw1;
        private System.ComponentModel.BackgroundWorker bgw2;
        private System.Windows.Forms.Button btn1;
    }
}

