namespace Prueba
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pbImagenGaleria = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reproductorMultimedia1 = new ReproductorMultimedia.ReproductorMultimedia();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenGaleria)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Selecciona directorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directorio seleccionado: ninguno";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // pbImagenGaleria
            // 
            this.pbImagenGaleria.Location = new System.Drawing.Point(226, 80);
            this.pbImagenGaleria.Name = "pbImagenGaleria";
            this.pbImagenGaleria.Size = new System.Drawing.Size(122, 137);
            this.pbImagenGaleria.TabIndex = 4;
            this.pbImagenGaleria.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Frecuencia";
            // 
            // reproductorMultimedia1
            // 
            this.reproductorMultimedia1.Location = new System.Drawing.Point(217, 223);
            this.reproductorMultimedia1.Name = "reproductorMultimedia1";
            this.reproductorMultimedia1.Size = new System.Drawing.Size(177, 42);
            this.reproductorMultimedia1.TabIndex = 2;
            this.reproductorMultimedia1.PlayClick += new System.EventHandler(this.reproductorMultimedia1_PlayClick);
            this.reproductorMultimedia1.DesbordaTiempo += new System.EventHandler(this.reproductorMultimedia1_DesbordaTiempo);
            this.reproductorMultimedia1.NextClick += new System.EventHandler(this.reproductorMultimedia1_NextClick);
            this.reproductorMultimedia1.PrevClick += new System.EventHandler(this.reproductorMultimedia1_PrevClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbImagenGaleria);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reproductorMultimedia1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenGaleria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private ReproductorMultimedia.ReproductorMultimedia reproductorMultimedia1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pbImagenGaleria;
        private System.Windows.Forms.Label label2;
    }
}

