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
            this.imgPlayPause = new System.Windows.Forms.PictureBox();
            this.lblPlayTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayPause)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPlayPause
            // 
            this.imgPlayPause.InitialImage = global::ReproductorMultimedia.Properties.Resources.play_icon_png;
            this.imgPlayPause.Location = new System.Drawing.Point(108, 120);
            this.imgPlayPause.Name = "imgPlayPause";
            this.imgPlayPause.Size = new System.Drawing.Size(44, 42);
            this.imgPlayPause.TabIndex = 0;
            this.imgPlayPause.TabStop = false;
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.AutoSize = true;
            this.lblPlayTime.Location = new System.Drawing.Point(158, 120);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(35, 13);
            this.lblPlayTime.TabIndex = 1;
            this.lblPlayTime.Text = "label1";
            // 
            // ReproductorMultimedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPlayTime);
            this.Controls.Add(this.imgPlayPause);
            this.Name = "ReproductorMultimedia";
            this.Size = new System.Drawing.Size(388, 270);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPlayPause;
        private System.Windows.Forms.Label lblPlayTime;
    }
}
