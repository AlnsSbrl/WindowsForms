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
            this.labelText1 = new LabelText.LabelText();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnSeparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelText1
            // 
            this.labelText1.Location = new System.Drawing.Point(45, 62);
            this.labelText1.Name = "labelText1";
            this.labelText1.Posicion = LabelText.ePosicion.IZQUIERDA;
            this.labelText1.PswChar = '\0';
            this.labelText1.Separacion = 0;
            this.labelText1.Size = new System.Drawing.Size(157, 20);
            this.labelText1.TabIndex = 0;
            this.labelText1.TextLbl = "LabelText";
            this.labelText1.TextTxt = "";
            this.labelText1.SeparationChanged += new System.EventHandler(this.labelText1_SeparationChanged);
            this.labelText1.TxtChanged += new System.EventHandler(this.labelText1_TxtChanged);
            this.labelText1.PosicionChanged += new System.EventHandler(this.labelText1_PosicionChanged);
            this.labelText1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelText1_KeyUp);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(45, 132);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 1;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnSeparar
            // 
            this.btnSeparar.Location = new System.Drawing.Point(150, 132);
            this.btnSeparar.Name = "btnSeparar";
            this.btnSeparar.Size = new System.Drawing.Size(75, 23);
            this.btnSeparar.TabIndex = 2;
            this.btnSeparar.Text = "Separar";
            this.btnSeparar.UseVisualStyleBackColor = true;
            this.btnSeparar.Click += new System.EventHandler(this.btnSeparar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 196);
            this.Controls.Add(this.btnSeparar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.labelText1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LabelText.LabelText labelText1;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnSeparar;
    }
}

