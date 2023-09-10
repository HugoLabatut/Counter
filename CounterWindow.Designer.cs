namespace Counter
{
    partial class CounterWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainWindowInfo = new System.Windows.Forms.Label();
            this.UICounter = new System.Windows.Forms.Label();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainWindowInfo
            // 
            this.mainWindowInfo.AutoSize = true;
            this.mainWindowInfo.Location = new System.Drawing.Point(83, 13);
            this.mainWindowInfo.Name = "mainWindowInfo";
            this.mainWindowInfo.Size = new System.Drawing.Size(335, 13);
            this.mainWindowInfo.TabIndex = 1;
            this.mainWindowInfo.Text = "Cliquez sur (+) pour augmenter la valeur. Cliquez sur (-) pour la réduire.";
            // 
            // UICounter
            // 
            this.UICounter.AutoSize = true;
            this.UICounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UICounter.Location = new System.Drawing.Point(167, 65);
            this.UICounter.Name = "UICounter";
            this.UICounter.Size = new System.Drawing.Size(40, 42);
            this.UICounter.TabIndex = 2;
            this.UICounter.Text = "0";
            this.UICounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.Location = new System.Drawing.Point(86, 51);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 64);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.Location = new System.Drawing.Point(339, 51);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 64);
            this.Minus.TabIndex = 3;
            this.Minus.Text = "-";
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // CounterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 181);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.UICounter);
            this.Controls.Add(this.mainWindowInfo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CounterWindow";
            this.Text = "Counter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mainWindowInfo;
        private System.Windows.Forms.Label UICounter;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
    }
}

