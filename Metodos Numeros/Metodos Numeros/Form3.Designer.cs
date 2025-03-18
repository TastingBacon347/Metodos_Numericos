namespace Metodos_Numeros
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegreso2 = new System.Windows.Forms.Button();
            this.btnCorrerReglaFalsa = new System.Windows.Forms.Button();
            this.DGVReglaFalsa = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IzqoDer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorAbsoluto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtErrorReglaFalsa = new System.Windows.Forms.TextBox();
            this.lblError2 = new System.Windows.Forms.Label();
            this.lblNo2 = new System.Windows.Forms.Label();
            this.btnVerificarReglaFalsa = new System.Windows.Forms.Button();
            this.lbl12 = new System.Windows.Forms.Label();
            this.txtParametroBReglaFalsa = new System.Windows.Forms.TextBox();
            this.txtParametroAReglaFalsa = new System.Windows.Forms.TextBox();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.txtFuncionReglaFalsa = new System.Windows.Forms.TextBox();
            this.lbl15 = new System.Windows.Forms.Label();
            this.btnGraficaReglaFalsa = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReglaFalsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegreso2
            // 
            this.btnRegreso2.ForeColor = System.Drawing.Color.Black;
            this.btnRegreso2.Location = new System.Drawing.Point(709, 421);
            this.btnRegreso2.Name = "btnRegreso2";
            this.btnRegreso2.Size = new System.Drawing.Size(79, 24);
            this.btnRegreso2.TabIndex = 85;
            this.btnRegreso2.Text = "Regresar";
            this.btnRegreso2.UseVisualStyleBackColor = true;
            this.btnRegreso2.Click += new System.EventHandler(this.btnRegreso2_Click);
            // 
            // btnCorrerReglaFalsa
            // 
            this.btnCorrerReglaFalsa.ForeColor = System.Drawing.Color.Black;
            this.btnCorrerReglaFalsa.Location = new System.Drawing.Point(227, 191);
            this.btnCorrerReglaFalsa.Name = "btnCorrerReglaFalsa";
            this.btnCorrerReglaFalsa.Size = new System.Drawing.Size(93, 28);
            this.btnCorrerReglaFalsa.TabIndex = 83;
            this.btnCorrerReglaFalsa.Text = "Correr";
            this.btnCorrerReglaFalsa.UseVisualStyleBackColor = true;
            this.btnCorrerReglaFalsa.Visible = false;
            this.btnCorrerReglaFalsa.Click += new System.EventHandler(this.btnCorrerReglaFalsa_Click);
            // 
            // DGVReglaFalsa
            // 
            this.DGVReglaFalsa.AllowUserToDeleteRows = false;
            this.DGVReglaFalsa.AllowUserToResizeColumns = false;
            this.DGVReglaFalsa.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            this.DGVReglaFalsa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVReglaFalsa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVReglaFalsa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVReglaFalsa.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.DGVReglaFalsa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVReglaFalsa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVReglaFalsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReglaFalsa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b,
            this.c,
            this.fa,
            this.fb,
            this.fc,
            this.IzqoDer,
            this.ErrorAbsoluto});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVReglaFalsa.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVReglaFalsa.GridColor = System.Drawing.Color.Cornsilk;
            this.DGVReglaFalsa.Location = new System.Drawing.Point(14, 237);
            this.DGVReglaFalsa.Name = "DGVReglaFalsa";
            this.DGVReglaFalsa.ReadOnly = true;
            this.DGVReglaFalsa.RowHeadersVisible = false;
            this.DGVReglaFalsa.RowHeadersWidth = 51;
            this.DGVReglaFalsa.Size = new System.Drawing.Size(776, 175);
            this.DGVReglaFalsa.TabIndex = 82;
            this.DGVReglaFalsa.Visible = false;
            // 
            // a
            // 
            this.a.HeaderText = "a";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.ReadOnly = true;
            // 
            // b
            // 
            this.b.HeaderText = "b";
            this.b.MinimumWidth = 6;
            this.b.Name = "b";
            this.b.ReadOnly = true;
            // 
            // c
            // 
            this.c.HeaderText = "c";
            this.c.MinimumWidth = 6;
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // fa
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.fa.DefaultCellStyle = dataGridViewCellStyle7;
            this.fa.HeaderText = "f(a)";
            this.fa.MinimumWidth = 6;
            this.fa.Name = "fa";
            this.fa.ReadOnly = true;
            // 
            // fb
            // 
            this.fb.HeaderText = "f(b)";
            this.fb.MinimumWidth = 6;
            this.fb.Name = "fb";
            this.fb.ReadOnly = true;
            // 
            // fc
            // 
            this.fc.HeaderText = "f(c)";
            this.fc.MinimumWidth = 6;
            this.fc.Name = "fc";
            this.fc.ReadOnly = true;
            // 
            // IzqoDer
            // 
            this.IzqoDer.HeaderText = "Izq o Der";
            this.IzqoDer.MinimumWidth = 6;
            this.IzqoDer.Name = "IzqoDer";
            this.IzqoDer.ReadOnly = true;
            // 
            // ErrorAbsoluto
            // 
            this.ErrorAbsoluto.HeaderText = "ErrorAbsoluto";
            this.ErrorAbsoluto.MinimumWidth = 6;
            this.ErrorAbsoluto.Name = "ErrorAbsoluto";
            this.ErrorAbsoluto.ReadOnly = true;
            // 
            // txtErrorReglaFalsa
            // 
            this.txtErrorReglaFalsa.ForeColor = System.Drawing.Color.Black;
            this.txtErrorReglaFalsa.Location = new System.Drawing.Point(119, 179);
            this.txtErrorReglaFalsa.Name = "txtErrorReglaFalsa";
            this.txtErrorReglaFalsa.Size = new System.Drawing.Size(63, 20);
            this.txtErrorReglaFalsa.TabIndex = 81;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.ForeColor = System.Drawing.Color.Black;
            this.lblError2.Location = new System.Drawing.Point(9, 182);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(113, 13);
            this.lblError2.TabIndex = 80;
            this.lblError2.Text = "Ingrese error deseado:";
            // 
            // lblNo2
            // 
            this.lblNo2.AutoSize = true;
            this.lblNo2.ForeColor = System.Drawing.Color.Red;
            this.lblNo2.Location = new System.Drawing.Point(9, 159);
            this.lblNo2.Name = "lblNo2";
            this.lblNo2.Size = new System.Drawing.Size(225, 13);
            this.lblNo2.TabIndex = 79;
            this.lblNo2.Text = "Datos faltantes o incorrectos, intente denuevo";
            this.lblNo2.Visible = false;
            // 
            // btnVerificarReglaFalsa
            // 
            this.btnVerificarReglaFalsa.ForeColor = System.Drawing.Color.Black;
            this.btnVerificarReglaFalsa.Location = new System.Drawing.Point(218, 107);
            this.btnVerificarReglaFalsa.Name = "btnVerificarReglaFalsa";
            this.btnVerificarReglaFalsa.Size = new System.Drawing.Size(85, 45);
            this.btnVerificarReglaFalsa.TabIndex = 75;
            this.btnVerificarReglaFalsa.Text = "Verificar";
            this.btnVerificarReglaFalsa.UseVisualStyleBackColor = true;
            this.btnVerificarReglaFalsa.Click += new System.EventHandler(this.btnVerificarReglaFalsa_Click);
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.Black;
            this.lbl12.Location = new System.Drawing.Point(20, 6);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(348, 35);
            this.lbl12.TabIndex = 74;
            this.lbl12.Text = "Metodo de Regla Falsa";
            // 
            // txtParametroBReglaFalsa
            // 
            this.txtParametroBReglaFalsa.ForeColor = System.Drawing.Color.Black;
            this.txtParametroBReglaFalsa.Location = new System.Drawing.Point(119, 136);
            this.txtParametroBReglaFalsa.Name = "txtParametroBReglaFalsa";
            this.txtParametroBReglaFalsa.Size = new System.Drawing.Size(62, 20);
            this.txtParametroBReglaFalsa.TabIndex = 73;
            // 
            // txtParametroAReglaFalsa
            // 
            this.txtParametroAReglaFalsa.ForeColor = System.Drawing.Color.Black;
            this.txtParametroAReglaFalsa.Location = new System.Drawing.Point(118, 107);
            this.txtParametroAReglaFalsa.Name = "txtParametroAReglaFalsa";
            this.txtParametroAReglaFalsa.Size = new System.Drawing.Size(63, 20);
            this.txtParametroAReglaFalsa.TabIndex = 72;
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.ForeColor = System.Drawing.Color.Black;
            this.lbl13.Location = new System.Drawing.Point(9, 139);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(104, 13);
            this.lbl13.TabIndex = 71;
            this.lbl13.Text = "Ingrese parametro b:";
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.ForeColor = System.Drawing.Color.Black;
            this.lbl14.Location = new System.Drawing.Point(9, 108);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(104, 13);
            this.lbl14.TabIndex = 70;
            this.lbl14.Text = "Ingrese parametro a:";
            // 
            // txtFuncionReglaFalsa
            // 
            this.txtFuncionReglaFalsa.ForeColor = System.Drawing.Color.Black;
            this.txtFuncionReglaFalsa.Location = new System.Drawing.Point(167, 63);
            this.txtFuncionReglaFalsa.Name = "txtFuncionReglaFalsa";
            this.txtFuncionReglaFalsa.Size = new System.Drawing.Size(166, 20);
            this.txtFuncionReglaFalsa.TabIndex = 69;
            // 
            // lbl15
            // 
            this.lbl15.AutoSize = true;
            this.lbl15.ForeColor = System.Drawing.Color.Black;
            this.lbl15.Location = new System.Drawing.Point(23, 66);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(138, 13);
            this.lbl15.TabIndex = 68;
            this.lbl15.Text = "Ingrese la funcion a evaluar";
            // 
            // btnGraficaReglaFalsa
            // 
            this.btnGraficaReglaFalsa.Location = new System.Drawing.Point(341, 414);
            this.btnGraficaReglaFalsa.Name = "btnGraficaReglaFalsa";
            this.btnGraficaReglaFalsa.Size = new System.Drawing.Size(163, 38);
            this.btnGraficaReglaFalsa.TabIndex = 87;
            this.btnGraficaReglaFalsa.Text = "Generar Grafica";
            this.btnGraficaReglaFalsa.UseVisualStyleBackColor = true;
            this.btnGraficaReglaFalsa.Click += new System.EventHandler(this.btnGraficaBiseccion_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Metodos_Numeros.Properties.Resources.Paso3Regla;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.InitialImage = global::Metodos_Numeros.Properties.Resources.Paso_1;
            this.pictureBox4.Location = new System.Drawing.Point(372, 114);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(395, 87);
            this.pictureBox4.TabIndex = 78;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Metodos_Numeros.Properties.Resources.Paso2Regla;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.InitialImage = global::Metodos_Numeros.Properties.Resources.Paso_1;
            this.pictureBox5.Location = new System.Drawing.Point(582, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(185, 101);
            this.pictureBox5.TabIndex = 77;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Metodos_Numeros.Properties.Resources.Paso1Regla;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.InitialImage = global::Metodos_Numeros.Properties.Resources.Paso_1;
            this.pictureBox6.Location = new System.Drawing.Point(372, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(185, 101);
            this.pictureBox6.TabIndex = 76;
            this.pictureBox6.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnGraficaReglaFalsa);
            this.Controls.Add(this.btnRegreso2);
            this.Controls.Add(this.btnCorrerReglaFalsa);
            this.Controls.Add(this.DGVReglaFalsa);
            this.Controls.Add(this.txtErrorReglaFalsa);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.lblNo2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnVerificarReglaFalsa);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.txtParametroBReglaFalsa);
            this.Controls.Add(this.txtParametroAReglaFalsa);
            this.Controls.Add(this.lbl13);
            this.Controls.Add(this.lbl14);
            this.Controls.Add(this.txtFuncionReglaFalsa);
            this.Controls.Add(this.lbl15);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo de Regla Falsa";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReglaFalsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegreso2;
        private System.Windows.Forms.Button btnCorrerReglaFalsa;
        private System.Windows.Forms.DataGridView DGVReglaFalsa;
        private System.Windows.Forms.TextBox txtErrorReglaFalsa;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.Label lblNo2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnVerificarReglaFalsa;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.TextBox txtParametroBReglaFalsa;
        private System.Windows.Forms.TextBox txtParametroAReglaFalsa;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.TextBox txtFuncionReglaFalsa;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Button btnGraficaReglaFalsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn fa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fb;
        private System.Windows.Forms.DataGridViewTextBoxColumn fc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzqoDer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorAbsoluto;
    }
}