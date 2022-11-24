namespace Operaciones_Matematicas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.botonOperacion = new System.Windows.Forms.Button();
            this.radioSuma = new System.Windows.Forms.RadioButton();
            this.radioMultiplicacion = new System.Windows.Forms.RadioButton();
            this.radioDivision = new System.Windows.Forms.RadioButton();
            this.radioResta = new System.Windows.Forms.RadioButton();
            this.labelNombreNum1 = new System.Windows.Forms.Label();
            this.labelNombreNum2 = new System.Windows.Forms.Label();
            this.labelSimboloOperacion = new System.Windows.Forms.Label();
            this.textBoxResultados = new System.Windows.Forms.TextBox();
            this.textBoxErrores = new System.Windows.Forms.TextBox();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.labelNombreResultado = new System.Windows.Forms.Label();
            this.groupBoxOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(204, 31);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(77, 23);
            this.textBoxNum1.TabIndex = 0;
            this.textBoxNum1.TextChanged += new System.EventHandler(this.textBoxNum1_TextChanged);
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(327, 31);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(77, 23);
            this.textBoxNum2.TabIndex = 1;
            this.textBoxNum2.TextChanged += new System.EventHandler(this.textBoxNum2_TextChanged);
            // 
            // botonOperacion
            // 
            this.botonOperacion.Location = new System.Drawing.Point(249, 60);
            this.botonOperacion.Name = "botonOperacion";
            this.botonOperacion.Size = new System.Drawing.Size(105, 23);
            this.botonOperacion.TabIndex = 2;
            this.botonOperacion.Text = "Operar";
            this.botonOperacion.UseVisualStyleBackColor = true;
            this.botonOperacion.Click += new System.EventHandler(this.botonOperacion_Click);
            // 
            // radioSuma
            // 
            this.radioSuma.AutoSize = true;
            this.radioSuma.Checked = true;
            this.radioSuma.Location = new System.Drawing.Point(6, 18);
            this.radioSuma.Name = "radioSuma";
            this.radioSuma.Size = new System.Drawing.Size(33, 19);
            this.radioSuma.TabIndex = 3;
            this.radioSuma.TabStop = true;
            this.radioSuma.Tag = "1";
            this.radioSuma.Text = "+";
            this.radioSuma.UseVisualStyleBackColor = true;
            this.radioSuma.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioMultiplicacion
            // 
            this.radioMultiplicacion.AutoSize = true;
            this.radioMultiplicacion.Location = new System.Drawing.Point(58, 18);
            this.radioMultiplicacion.Name = "radioMultiplicacion";
            this.radioMultiplicacion.Size = new System.Drawing.Size(30, 19);
            this.radioMultiplicacion.TabIndex = 4;
            this.radioMultiplicacion.Tag = "3";
            this.radioMultiplicacion.Text = "*";
            this.radioMultiplicacion.UseVisualStyleBackColor = true;
            this.radioMultiplicacion.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioDivision
            // 
            this.radioDivision.AutoSize = true;
            this.radioDivision.Location = new System.Drawing.Point(58, 43);
            this.radioDivision.Name = "radioDivision";
            this.radioDivision.Size = new System.Drawing.Size(30, 19);
            this.radioDivision.TabIndex = 5;
            this.radioDivision.Tag = "4";
            this.radioDivision.Text = "/";
            this.radioDivision.UseVisualStyleBackColor = true;
            this.radioDivision.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioResta
            // 
            this.radioResta.AutoSize = true;
            this.radioResta.Location = new System.Drawing.Point(6, 43);
            this.radioResta.Name = "radioResta";
            this.radioResta.Size = new System.Drawing.Size(30, 19);
            this.radioResta.TabIndex = 6;
            this.radioResta.TabStop = true;
            this.radioResta.Tag = "2";
            this.radioResta.Text = "-";
            this.radioResta.UseVisualStyleBackColor = true;
            this.radioResta.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelNombreNum1
            // 
            this.labelNombreNum1.AutoSize = true;
            this.labelNombreNum1.Location = new System.Drawing.Point(204, 9);
            this.labelNombreNum1.Name = "labelNombreNum1";
            this.labelNombreNum1.Size = new System.Drawing.Size(57, 15);
            this.labelNombreNum1.TabIndex = 7;
            this.labelNombreNum1.Text = "sumando";
            // 
            // labelNombreNum2
            // 
            this.labelNombreNum2.AutoSize = true;
            this.labelNombreNum2.Location = new System.Drawing.Point(327, 9);
            this.labelNombreNum2.Name = "labelNombreNum2";
            this.labelNombreNum2.Size = new System.Drawing.Size(57, 15);
            this.labelNombreNum2.TabIndex = 8;
            this.labelNombreNum2.Text = "sumando";
            // 
            // labelSimboloOperacion
            // 
            this.labelSimboloOperacion.AutoSize = true;
            this.labelSimboloOperacion.Location = new System.Drawing.Point(296, 34);
            this.labelSimboloOperacion.Name = "labelSimboloOperacion";
            this.labelSimboloOperacion.Size = new System.Drawing.Size(15, 15);
            this.labelSimboloOperacion.TabIndex = 10;
            this.labelSimboloOperacion.Text = "+";
            // 
            // textBoxResultados
            // 
            this.textBoxResultados.Enabled = false;
            this.textBoxResultados.Location = new System.Drawing.Point(296, 104);
            this.textBoxResultados.Name = "textBoxResultados";
            this.textBoxResultados.Size = new System.Drawing.Size(58, 23);
            this.textBoxResultados.TabIndex = 12;
            // 
            // textBoxErrores
            // 
            this.textBoxErrores.Enabled = false;
            this.textBoxErrores.Location = new System.Drawing.Point(1, 142);
            this.textBoxErrores.Multiline = true;
            this.textBoxErrores.Name = "textBoxErrores";
            this.textBoxErrores.Size = new System.Drawing.Size(427, 41);
            this.textBoxErrores.TabIndex = 13;
            // 
            // groupBoxOperaciones
            // 
            this.groupBoxOperaciones.Controls.Add(this.radioSuma);
            this.groupBoxOperaciones.Controls.Add(this.radioMultiplicacion);
            this.groupBoxOperaciones.Controls.Add(this.radioResta);
            this.groupBoxOperaciones.Controls.Add(this.radioDivision);
            this.groupBoxOperaciones.Location = new System.Drawing.Point(22, 12);
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(104, 84);
            this.groupBoxOperaciones.TabIndex = 14;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "Operaciones:";
            // 
            // labelNombreResultado
            // 
            this.labelNombreResultado.AutoSize = true;
            this.labelNombreResultado.Location = new System.Drawing.Point(204, 107);
            this.labelNombreResultado.Name = "labelNombreResultado";
            this.labelNombreResultado.Size = new System.Drawing.Size(40, 15);
            this.labelNombreResultado.TabIndex = 15;
            this.labelNombreResultado.Text = "Suma:";
            // 
            // Form1
            // 
            this.AcceptButton = this.botonOperacion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 185);
            this.Controls.Add(this.labelNombreResultado);
            this.Controls.Add(this.groupBoxOperaciones);
            this.Controls.Add(this.textBoxErrores);
            this.Controls.Add(this.textBoxResultados);
            this.Controls.Add(this.labelSimboloOperacion);
            this.Controls.Add(this.labelNombreNum2);
            this.Controls.Add(this.labelNombreNum1);
            this.Controls.Add(this.botonOperacion);
            this.Controls.Add(this.textBoxNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxOperaciones.ResumeLayout(false);
            this.groupBoxOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private Button botonOperacion;
        private RadioButton radioSuma;
        private RadioButton radioMultiplicacion;
        private RadioButton radioDivision;
        private RadioButton radioResta;
        private Label labelNombreNum1;
        private Label labelNombreNum2;
        private Label labelSimboloOperacion;
        private TextBox textBoxResultados;
        private TextBox textBoxErrores;
        private GroupBox groupBoxOperaciones;
        private Label labelNombreResultado;
    }
}