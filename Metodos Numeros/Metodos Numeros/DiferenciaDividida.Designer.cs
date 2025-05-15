namespace Metodos_Numeros
{
    partial class DiferenciaDividida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVDiferenciaDividida = new System.Windows.Forms.DataGridView();
            this.DGVEntrada = new System.Windows.Forms.DataGridView();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtPolinomio = new System.Windows.Forms.TextBox();
            this.btnAgregarPunto = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiferenciaDividida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDiferenciaDividida
            // 
            this.DGVDiferenciaDividida.AllowUserToAddRows = false;
            this.DGVDiferenciaDividida.AllowUserToDeleteRows = false;
            this.DGVDiferenciaDividida.AllowUserToResizeColumns = false;
            this.DGVDiferenciaDividida.AllowUserToResizeRows = false;
            this.DGVDiferenciaDividida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDiferenciaDividida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVDiferenciaDividida.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.DGVDiferenciaDividida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDiferenciaDividida.Location = new System.Drawing.Point(388, 269);
            this.DGVDiferenciaDividida.Name = "DGVDiferenciaDividida";
            this.DGVDiferenciaDividida.ReadOnly = true;
            this.DGVDiferenciaDividida.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVDiferenciaDividida.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVDiferenciaDividida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVDiferenciaDividida.Size = new System.Drawing.Size(476, 186);
            this.DGVDiferenciaDividida.TabIndex = 0;
            // 
            // DGVEntrada
            // 
            this.DGVEntrada.AllowUserToAddRows = false;
            this.DGVEntrada.AllowUserToDeleteRows = false;
            this.DGVEntrada.AllowUserToResizeColumns = false;
            this.DGVEntrada.AllowUserToResizeRows = false;
            this.DGVEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVEntrada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVEntrada.BackgroundColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEntrada.Location = new System.Drawing.Point(12, 269);
            this.DGVEntrada.Name = "DGVEntrada";
            this.DGVEntrada.ReadOnly = true;
            this.DGVEntrada.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVEntrada.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVEntrada.Size = new System.Drawing.Size(348, 186);
            this.DGVEntrada.TabIndex = 1;
            this.DGVEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEntrada_CellContentClick);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(103, 95);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(110, 20);
            this.txtX.TabIndex = 2;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(233, 95);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(110, 20);
            this.txtY.TabIndex = 3;
            // 
            // txtPolinomio
            // 
            this.txtPolinomio.Location = new System.Drawing.Point(903, 326);
            this.txtPolinomio.Multiline = true;
            this.txtPolinomio.Name = "txtPolinomio";
            this.txtPolinomio.ReadOnly = true;
            this.txtPolinomio.Size = new System.Drawing.Size(240, 26);
            this.txtPolinomio.TabIndex = 4;
            // 
            // btnAgregarPunto
            // 
            this.btnAgregarPunto.Location = new System.Drawing.Point(154, 135);
            this.btnAgregarPunto.Name = "btnAgregarPunto";
            this.btnAgregarPunto.Size = new System.Drawing.Size(142, 23);
            this.btnAgregarPunto.TabIndex = 5;
            this.btnAgregarPunto.Text = "Agregar Punto";
            this.btnAgregarPunto.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(87, 176);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 36);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(233, 176);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 39);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(1120, 447);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(104, 40);
            this.btnRegresar.TabIndex = 85;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(6, 9);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(407, 35);
            this.lbl6.TabIndex = 87;
            this.lbl6.Text = "Metodo Diferencia Dividida";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(999, 310);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(52, 13);
            this.lbl3.TabIndex = 86;
            this.lbl3.Text = "Polinomio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 89;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 90;
            this.label3.Text = "Diferencia Dividida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 91;
            this.label4.Text = "Puntos";
            // 
            // DiferenciaDividida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1236, 499);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregarPunto);
            this.Controls.Add(this.txtPolinomio);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.DGVEntrada);
            this.Controls.Add(this.DGVDiferenciaDividida);
            this.Name = "DiferenciaDividida";
            this.Text = "DiferenciaDividida";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDiferenciaDividida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDiferenciaDividida;
        private System.Windows.Forms.DataGridView DGVEntrada;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtPolinomio;
        private System.Windows.Forms.Button btnAgregarPunto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}