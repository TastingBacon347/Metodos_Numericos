namespace Metodos_Numeros
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.DGVBiseccion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCorrerBiseccion = new System.Windows.Forms.Button();
            this.txtErrorBiseccion = new System.Windows.Forms.TextBox();
            this.lblError1 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txtParametroBBiseccion = new System.Windows.Forms.TextBox();
            this.txtParametroABiseccion = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtFuncionBiseccion = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnGraficaBiseccion = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBiseccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(945, 514);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(105, 30);
            this.btnRegresar.TabIndex = 84;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // DGVBiseccion
            // 
            this.DGVBiseccion.AllowUserToDeleteRows = false;
            this.DGVBiseccion.AllowUserToResizeColumns = false;
            this.DGVBiseccion.AllowUserToResizeRows = false;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBiseccion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.DGVBiseccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBiseccion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVBiseccion.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.DGVBiseccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBiseccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.DGVBiseccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBiseccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11});
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVBiseccion.DefaultCellStyle = dataGridViewCellStyle47;
            this.DGVBiseccion.EnableHeadersVisualStyles = false;
            this.DGVBiseccion.GridColor = System.Drawing.Color.LightSeaGreen;
            this.DGVBiseccion.Location = new System.Drawing.Point(19, 292);
            this.DGVBiseccion.Margin = new System.Windows.Forms.Padding(4);
            this.DGVBiseccion.Name = "DGVBiseccion";
            this.DGVBiseccion.ReadOnly = true;
            this.DGVBiseccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVBiseccion.RowHeadersVisible = false;
            this.DGVBiseccion.RowHeadersWidth = 60;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DGVBiseccion.RowsDefaultCellStyle = dataGridViewCellStyle48;
            this.DGVBiseccion.Size = new System.Drawing.Size(1035, 215);
            this.DGVBiseccion.TabIndex = 82;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridViewTextBoxColumn1.HeaderText = "a";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewTextBoxColumn2.HeaderText = "b";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewTextBoxColumn3.HeaderText = "c";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridViewTextBoxColumn4.HeaderText = "f(a)";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle43;
            this.dataGridViewTextBoxColumn5.HeaderText = "f(c)";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle44;
            this.dataGridViewTextBoxColumn7.HeaderText = "f(a) * f(c)";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle45;
            this.dataGridViewTextBoxColumn8.HeaderText = "Izq o Der";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle46;
            this.dataGridViewTextBoxColumn11.HeaderText = "ErrorAbsoluto";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // btnCorrerBiseccion
            // 
            this.btnCorrerBiseccion.Location = new System.Drawing.Point(321, 219);
            this.btnCorrerBiseccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCorrerBiseccion.Name = "btnCorrerBiseccion";
            this.btnCorrerBiseccion.Size = new System.Drawing.Size(124, 34);
            this.btnCorrerBiseccion.TabIndex = 81;
            this.btnCorrerBiseccion.Text = "Correr";
            this.btnCorrerBiseccion.UseVisualStyleBackColor = true;
            this.btnCorrerBiseccion.Click += new System.EventHandler(this.btnCorrerBiseccion_Click);
            // 
            // txtErrorBiseccion
            // 
            this.txtErrorBiseccion.Location = new System.Drawing.Point(161, 228);
            this.txtErrorBiseccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtErrorBiseccion.Name = "txtErrorBiseccion";
            this.txtErrorBiseccion.Size = new System.Drawing.Size(83, 22);
            this.txtErrorBiseccion.TabIndex = 74;
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Location = new System.Drawing.Point(15, 228);
            this.lblError1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(144, 16);
            this.lblError1.TabIndex = 79;
            this.lblError1.Text = "Ingrese error deseado:";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.ForeColor = System.Drawing.Color.Red;
            this.lblNo.Location = new System.Drawing.Point(15, 199);
            this.lblNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(277, 16);
            this.lblNo.TabIndex = 78;
            this.lblNo.Text = "Datos faltantes o incorrectos, intente denuevo";
            this.lblNo.Visible = false;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(29, 11);
            this.lbl6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(401, 44);
            this.lbl6.TabIndex = 73;
            this.lbl6.Text = "Metodo de Biseccion";
            // 
            // txtParametroBBiseccion
            // 
            this.txtParametroBBiseccion.Location = new System.Drawing.Point(161, 171);
            this.txtParametroBBiseccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtParametroBBiseccion.Name = "txtParametroBBiseccion";
            this.txtParametroBBiseccion.Size = new System.Drawing.Size(81, 22);
            this.txtParametroBBiseccion.TabIndex = 72;
            // 
            // txtParametroABiseccion
            // 
            this.txtParametroABiseccion.Location = new System.Drawing.Point(160, 135);
            this.txtParametroABiseccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtParametroABiseccion.Name = "txtParametroABiseccion";
            this.txtParametroABiseccion.Size = new System.Drawing.Size(83, 22);
            this.txtParametroABiseccion.TabIndex = 71;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(15, 175);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(131, 16);
            this.lbl1.TabIndex = 70;
            this.lbl1.Text = "Ingrese parametro b:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(15, 137);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(131, 16);
            this.lbl2.TabIndex = 69;
            this.lbl2.Text = "Ingrese parametro a:";
            // 
            // txtFuncionBiseccion
            // 
            this.txtFuncionBiseccion.Location = new System.Drawing.Point(225, 81);
            this.txtFuncionBiseccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuncionBiseccion.Name = "txtFuncionBiseccion";
            this.txtFuncionBiseccion.Size = new System.Drawing.Size(220, 22);
            this.txtFuncionBiseccion.TabIndex = 68;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(33, 85);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(170, 16);
            this.lbl3.TabIndex = 67;
            this.lbl3.Text = "Ingrese la funcion a evaluar";
            // 
            // btnGraficaBiseccion
            // 
            this.btnGraficaBiseccion.Location = new System.Drawing.Point(455, 510);
            this.btnGraficaBiseccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnGraficaBiseccion.Name = "btnGraficaBiseccion";
            this.btnGraficaBiseccion.Size = new System.Drawing.Size(217, 47);
            this.btnGraficaBiseccion.TabIndex = 86;
            this.btnGraficaBiseccion.Text = "Generar Grafica";
            this.btnGraficaBiseccion.UseVisualStyleBackColor = true;
            this.btnGraficaBiseccion.Click += new System.EventHandler(this.btnGraficaBiseccion_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Metodos_Numeros.Properties.Resources.Paso4Bis;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.InitialImage = global::Metodos_Numeros.Properties.Resources.Paso_1;
            this.pictureBox3.Location = new System.Drawing.Point(499, 149);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(549, 124);
            this.pictureBox3.TabIndex = 85;
            this.pictureBox3.TabStop = false;
            // 
            // image
            // 
            this.image.BackgroundImage = global::Metodos_Numeros.Properties.Resources.Paso3;
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.InitialImage = global::Metodos_Numeros.Properties.Resources.Paso_1;
            this.image.Location = new System.Drawing.Point(860, 11);
            this.image.Margin = new System.Windows.Forms.Padding(4);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(187, 124);
            this.image.TabIndex = 77;
            this.image.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Metodos_Numeros.Properties.Resources.Paso2Bis1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.InitialImage = global::Metodos_Numeros.Properties.Resources.Paso_1;
            this.pictureBox2.Location = new System.Drawing.Point(681, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 124);
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Metodos_Numeros.Properties.Resources.Paso_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = global::Metodos_Numeros.Properties.Resources.Paso_1;
            this.pictureBox1.Location = new System.Drawing.Point(499, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 124);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnGraficaBiseccion);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.DGVBiseccion);
            this.Controls.Add(this.btnCorrerBiseccion);
            this.Controls.Add(this.txtErrorBiseccion);
            this.Controls.Add(this.lblError1);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.txtParametroBBiseccion);
            this.Controls.Add(this.txtParametroABiseccion);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtFuncionBiseccion);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.image);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo de Biseccion";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBiseccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView DGVBiseccion;
        private System.Windows.Forms.Button btnCorrerBiseccion;
        private System.Windows.Forms.TextBox txtErrorBiseccion;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txtParametroBBiseccion;
        private System.Windows.Forms.TextBox txtParametroABiseccion;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtFuncionBiseccion;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGraficaBiseccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}