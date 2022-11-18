namespace Formulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.botonColor = new System.Windows.Forms.Button();
            this.textBoxRutaImaxe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botonImaxe = new System.Windows.Forms.Button();
            this.botonSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "B";
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(41, 51);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(38, 23);
            this.textBoxR.TabIndex = 3;
            this.textBoxR.Enter += new System.EventHandler(this.textBoxR_Enter);
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(101, 51);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(38, 23);
            this.textBoxG.TabIndex = 4;
            this.textBoxG.Enter += new System.EventHandler(this.textBoxR_Enter);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(163, 51);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(38, 23);
            this.textBoxB.TabIndex = 5;
            this.textBoxB.Enter += new System.EventHandler(this.textBoxR_Enter);
            // 
            // botonColor
            // 
            this.botonColor.Location = new System.Drawing.Point(225, 50);
            this.botonColor.Name = "botonColor";
            this.botonColor.Size = new System.Drawing.Size(75, 23);
            this.botonColor.TabIndex = 6;
            this.botonColor.Text = "Cor";
            this.botonColor.UseVisualStyleBackColor = true;
            this.botonColor.Click += new System.EventHandler(this.BotonCor_Click);
            this.botonColor.MouseEnter += new System.EventHandler(this.Boton_MouseEnter);
            this.botonColor.MouseLeave += new System.EventHandler(this.Boton_MouseLeave);
            // 
            // textBoxRutaImaxe
            // 
            this.textBoxRutaImaxe.Location = new System.Drawing.Point(101, 96);
            this.textBoxRutaImaxe.Name = "textBoxRutaImaxe";
            this.textBoxRutaImaxe.Size = new System.Drawing.Size(100, 23);
            this.textBoxRutaImaxe.TabIndex = 7;
            this.textBoxRutaImaxe.Enter += new System.EventHandler(this.textBoxRutaImaxe_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ruta";
            // 
            // botonImaxe
            // 
            this.botonImaxe.Location = new System.Drawing.Point(225, 96);
            this.botonImaxe.Name = "botonImaxe";
            this.botonImaxe.Size = new System.Drawing.Size(75, 23);
            this.botonImaxe.TabIndex = 9;
            this.botonImaxe.Text = "Imaxe";
            this.botonImaxe.UseVisualStyleBackColor = true;
            this.botonImaxe.Click += new System.EventHandler(this.buttonImaxe_Click);
            this.botonImaxe.MouseEnter += new System.EventHandler(this.Boton_MouseEnter);
            this.botonImaxe.MouseLeave += new System.EventHandler(this.Boton_MouseLeave);
            // 
            // botonSair
            // 
            this.botonSair.Location = new System.Drawing.Point(110, 145);
            this.botonSair.Name = "botonSair";
            this.botonSair.Size = new System.Drawing.Size(75, 23);
            this.botonSair.TabIndex = 10;
            this.botonSair.Text = "Saír";
            this.botonSair.UseVisualStyleBackColor = true;
            this.botonSair.Click += new System.EventHandler(this.BotonSalir_Click);
            this.botonSair.MouseEnter += new System.EventHandler(this.Boton_MouseEnter);
            this.botonSair.MouseLeave += new System.EventHandler(this.Boton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(322, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 156);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.botonColor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.botonSair;
            this.ClientSize = new System.Drawing.Size(507, 201);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonSair);
            this.Controls.Add(this.botonImaxe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRutaImaxe);
            this.Controls.Add(this.botonColor);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxR;
        private TextBox textBoxG;
        private TextBox textBoxB;
        private Button botonColor;
        private TextBox textBoxRutaImaxe;
        private Label label4;
        private Button botonImaxe;
        private Button botonSair;
        private PictureBox pictureBox1;
    }
}