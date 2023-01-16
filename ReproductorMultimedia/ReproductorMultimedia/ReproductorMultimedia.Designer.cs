namespace ReproductorMultimedia
{
    partial class ReproductorMultimedia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayTime = new System.Windows.Forms.Label();
            this.imgPrevious = new System.Windows.Forms.PictureBox();
            this.imgNext = new System.Windows.Forms.PictureBox();
            this.imgPlayPause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayPause)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.AutoSize = true;
            this.lblPlayTime.Location = new System.Drawing.Point(279, 134);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(35, 13);
            this.lblPlayTime.TabIndex = 1;
            this.lblPlayTime.Text = "label1";
            // 
            // imgPrevious
            // 
            this.imgPrevious.Location = new System.Drawing.Point(111, 121);
            this.imgPrevious.Name = "imgPrevious";
            this.imgPrevious.Size = new System.Drawing.Size(44, 42);
            this.imgPrevious.TabIndex = 4;
            this.imgPrevious.TabStop = false;
            this.imgPrevious.Click += new System.EventHandler(this.imgPlayPause_Click);
            // 
            // imgNext
            // 
            this.imgNext.Image = global::ReproductorMultimedia.Properties.Resources.nextButton;
            this.imgNext.Location = new System.Drawing.Point(211, 121);
            this.imgNext.Name = "imgNext";
            this.imgNext.Size = new System.Drawing.Size(44, 42);
            this.imgNext.TabIndex = 3;
            this.imgNext.TabStop = false;
            this.imgNext.Click += new System.EventHandler(this.imgPlayPause_Click);
            // 
            // imgPlayPause
            // 
            this.imgPlayPause.InitialImage = global::ReproductorMultimedia.Properties.Resources.play;
            this.imgPlayPause.Location = new System.Drawing.Point(161, 121);
            this.imgPlayPause.Name = "imgPlayPause";
            this.imgPlayPause.Size = new System.Drawing.Size(44, 42);
            this.imgPlayPause.TabIndex = 0;
            this.imgPlayPause.TabStop = false;
            this.imgPlayPause.Click += new System.EventHandler(this.imgPlayPause_Click);
            // 
            // ReproductorMultimedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgPrevious);
            this.Controls.Add(this.imgNext);
            this.Controls.Add(this.lblPlayTime);
            this.Controls.Add(this.imgPlayPause);
            this.Name = "ReproductorMultimedia";
            this.Size = new System.Drawing.Size(388, 270);
            ((System.ComponentModel.ISupportInitialize)(this.imgPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPlayPause;
        private System.Windows.Forms.Label lblPlayTime;
        private System.Windows.Forms.PictureBox imgNext;
        private System.Windows.Forms.PictureBox imgPrevious;
    }
}
