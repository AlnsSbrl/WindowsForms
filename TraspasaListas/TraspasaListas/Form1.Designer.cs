namespace TraspasaListas
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
            this.components = new System.ComponentModel.Container();
            this.listElementos = new System.Windows.Forms.ListBox();
            this.btnEngadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTraspasarToLeft = new System.Windows.Forms.Button();
            this.btnTraspasarToRight = new System.Windows.Forms.Button();
            this.labelList1 = new System.Windows.Forms.Label();
            this.txbNuevoElemento = new System.Windows.Forms.TextBox();
            this.listElementosProtegidos = new System.Windows.Forms.ListBox();
            this.labelListProtegida = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listElementos
            // 
            this.listElementos.FormattingEnabled = true;
            this.listElementos.ItemHeight = 15;
            this.listElementos.Location = new System.Drawing.Point(68, 110);
            this.listElementos.Name = "listElementos";
            this.listElementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listElementos.Size = new System.Drawing.Size(186, 154);
            this.listElementos.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listElementos, "elementos que se poden eliminar");
            this.listElementos.Click += new System.EventHandler(this.listElementos_Click);
            // 
            // btnEngadir
            // 
            this.btnEngadir.Location = new System.Drawing.Point(164, 53);
            this.btnEngadir.Name = "btnEngadir";
            this.btnEngadir.Size = new System.Drawing.Size(90, 23);
            this.btnEngadir.TabIndex = 2;
            this.btnEngadir.Text = "Engadir";
            this.toolTip1.SetToolTip(this.btnEngadir, "boton engadir");
            this.btnEngadir.UseVisualStyleBackColor = true;
            this.btnEngadir.Click += new System.EventHandler(this.BtnEngadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(68, 291);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminar, "borra os elementos seleccionados");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTraspasarToLeft
            // 
            this.btnTraspasarToLeft.Location = new System.Drawing.Point(275, 139);
            this.btnTraspasarToLeft.Name = "btnTraspasarToLeft";
            this.btnTraspasarToLeft.Size = new System.Drawing.Size(90, 23);
            this.btnTraspasarToLeft.TabIndex = 4;
            this.btnTraspasarToLeft.Text = "<-Traspasar";
            this.toolTip1.SetToolTip(this.btnTraspasarToLeft, "traspasa á esquerda");
            this.btnTraspasarToLeft.UseVisualStyleBackColor = true;
            this.btnTraspasarToLeft.Click += new System.EventHandler(this.btnTraspasar_Click);
            // 
            // btnTraspasarToRight
            // 
            this.btnTraspasarToRight.Location = new System.Drawing.Point(275, 110);
            this.btnTraspasarToRight.Name = "btnTraspasarToRight";
            this.btnTraspasarToRight.Size = new System.Drawing.Size(90, 23);
            this.btnTraspasarToRight.TabIndex = 5;
            this.btnTraspasarToRight.Text = "Traspasar->";
            this.toolTip1.SetToolTip(this.btnTraspasarToRight, "tonto el que lo lea");
            this.btnTraspasarToRight.UseVisualStyleBackColor = true;
            this.btnTraspasarToRight.Click += new System.EventHandler(this.btnTraspasar_Click);
            // 
            // labelList1
            // 
            this.labelList1.AutoSize = true;
            this.labelList1.Location = new System.Drawing.Point(68, 92);
            this.labelList1.Name = "labelList1";
            this.labelList1.Size = new System.Drawing.Size(38, 15);
            this.labelList1.TabIndex = 6;
            this.labelList1.Text = "label1";
            this.toolTip1.SetToolTip(this.labelList1, "numero de elementos lista 1");
            // 
            // txbNuevoElemento
            // 
            this.txbNuevoElemento.Location = new System.Drawing.Point(68, 54);
            this.txbNuevoElemento.Name = "txbNuevoElemento";
            this.txbNuevoElemento.Size = new System.Drawing.Size(90, 23);
            this.txbNuevoElemento.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txbNuevoElemento, "elemento a engadir na lista 1");
            // 
            // listElementosProtegidos
            // 
            this.listElementosProtegidos.FormattingEnabled = true;
            this.listElementosProtegidos.ItemHeight = 15;
            this.listElementosProtegidos.Location = new System.Drawing.Point(382, 110);
            this.listElementosProtegidos.Name = "listElementosProtegidos";
            this.listElementosProtegidos.Size = new System.Drawing.Size(162, 154);
            this.listElementosProtegidos.TabIndex = 8;
            this.toolTip1.SetToolTip(this.listElementosProtegidos, "0");
            // 
            // labelListProtegida
            // 
            this.labelListProtegida.AutoSize = true;
            this.labelListProtegida.Location = new System.Drawing.Point(68, 267);
            this.labelListProtegida.Name = "labelListProtegida";
            this.labelListProtegida.Size = new System.Drawing.Size(38, 15);
            this.labelListProtegida.TabIndex = 9;
            this.labelListProtegida.Text = "label2";
            this.toolTip1.SetToolTip(this.labelListProtegida, "numero elementos lista protegida");
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEngadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 351);
            this.Controls.Add(this.labelListProtegida);
            this.Controls.Add(this.listElementosProtegidos);
            this.Controls.Add(this.txbNuevoElemento);
            this.Controls.Add(this.labelList1);
            this.Controls.Add(this.btnTraspasarToRight);
            this.Controls.Add(this.btnTraspasarToLeft);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEngadir);
            this.Controls.Add(this.listElementos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listElementos;
        private Button btnEngadir;
        private Button btnEliminar;
        private Button btnTraspasarToLeft;
        private Button btnTraspasarToRight;
        private Label labelList1;
        private TextBox txbNuevoElemento;
        private ListBox listElementosProtegidos;
        private Label labelListProtegida;
        private System.Windows.Forms.Timer timer1;
        private ToolTip toolTip1;
    }
}