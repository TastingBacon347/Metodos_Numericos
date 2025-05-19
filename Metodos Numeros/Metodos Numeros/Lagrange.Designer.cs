namespace Metodos_Numeros
{
    partial class Lagrange
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lagrange));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelBlanco = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.DGVEntrada = new System.Windows.Forms.DataGridView();
            this.btnGrafica = new Guna.UI2.WinForms.Guna2Button();
            this.txtPoliSimp = new System.Windows.Forms.TextBox();
            this.lblPoliSimp = new System.Windows.Forms.Label();
            this.btnCalcularG = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpiarG = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarPuntoG = new Guna.UI2.WinForms.Guna2Button();
            this.txtY = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtX = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPuntosDiferencias = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblLagrangePoli = new System.Windows.Forms.Label();
            this.txtPolinomio = new System.Windows.Forms.TextBox();
            this.lblPolinomio = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLagrange = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnRegresarG = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ElipseBlanco = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ArrastrasPagina = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ElipseNaranja = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ArrastraLateral = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DGVLagrange = new System.Windows.Forms.DataGridView();
            this.PanelBlanco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLagrange)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBlanco
            // 
            this.PanelBlanco.BackColor = System.Drawing.Color.White;
            this.PanelBlanco.Controls.Add(this.DGVLagrange);
            this.PanelBlanco.Controls.Add(this.DGVEntrada);
            this.PanelBlanco.Controls.Add(this.btnGrafica);
            this.PanelBlanco.Controls.Add(this.txtPoliSimp);
            this.PanelBlanco.Controls.Add(this.lblPoliSimp);
            this.PanelBlanco.Controls.Add(this.btnCalcularG);
            this.PanelBlanco.Controls.Add(this.btnLimpiarG);
            this.PanelBlanco.Controls.Add(this.btnAgregarPuntoG);
            this.PanelBlanco.Controls.Add(this.txtY);
            this.PanelBlanco.Controls.Add(this.txtX);
            this.PanelBlanco.Controls.Add(this.lblPuntosDiferencias);
            this.PanelBlanco.Controls.Add(this.lblPuntos);
            this.PanelBlanco.Controls.Add(this.lblLagrangePoli);
            this.PanelBlanco.Controls.Add(this.txtPolinomio);
            this.PanelBlanco.Controls.Add(this.lblPolinomio);
            this.PanelBlanco.Controls.Add(this.lblX);
            this.PanelBlanco.Controls.Add(this.lblY);
            this.PanelBlanco.FillColor = System.Drawing.Color.White;
            this.PanelBlanco.FillColor2 = System.Drawing.Color.White;
            this.PanelBlanco.Location = new System.Drawing.Point(12, 85);
            this.PanelBlanco.Name = "PanelBlanco";
            this.PanelBlanco.Size = new System.Drawing.Size(774, 557);
            this.PanelBlanco.TabIndex = 109;
            // 
            // DGVEntrada
            // 
            this.DGVEntrada.AllowUserToAddRows = false;
            this.DGVEntrada.AllowUserToDeleteRows = false;
            this.DGVEntrada.AllowUserToResizeColumns = false;
            this.DGVEntrada.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.PowderBlue;
            this.DGVEntrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVEntrada.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DGVEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVEntrada.DefaultCellStyle = dataGridViewCellStyle12;
            this.DGVEntrada.Enabled = false;
            this.DGVEntrada.Location = new System.Drawing.Point(24, 176);
            this.DGVEntrada.MultiSelect = false;
            this.DGVEntrada.Name = "DGVEntrada";
            this.DGVEntrada.ReadOnly = true;
            this.DGVEntrada.RowHeadersVisible = false;
            this.DGVEntrada.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVEntrada.Size = new System.Drawing.Size(348, 186);
            this.DGVEntrada.TabIndex = 110;
            // 
            // btnGrafica
            // 
            this.btnGrafica.BorderRadius = 20;
            this.btnGrafica.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrafica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrafica.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGrafica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGrafica.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnGrafica.ForeColor = System.Drawing.Color.White;
            this.btnGrafica.Location = new System.Drawing.Point(556, 380);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(200, 53);
            this.btnGrafica.TabIndex = 109;
            this.btnGrafica.Text = "Generar Grafica";
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // txtPoliSimp
            // 
            this.txtPoliSimp.Enabled = false;
            this.txtPoliSimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoliSimp.Location = new System.Drawing.Point(20, 520);
            this.txtPoliSimp.Multiline = true;
            this.txtPoliSimp.Name = "txtPoliSimp";
            this.txtPoliSimp.ReadOnly = true;
            this.txtPoliSimp.Size = new System.Drawing.Size(732, 34);
            this.txtPoliSimp.TabIndex = 107;
            this.txtPoliSimp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPoliSimp
            // 
            this.lblPoliSimp.BackColor = System.Drawing.Color.Transparent;
            this.lblPoliSimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoliSimp.Location = new System.Drawing.Point(26, 490);
            this.lblPoliSimp.Name = "lblPoliSimp";
            this.lblPoliSimp.Size = new System.Drawing.Size(276, 27);
            this.lblPoliSimp.TabIndex = 108;
            this.lblPoliSimp.Text = "Polinomio Simplificado:";
            // 
            // btnCalcularG
            // 
            this.btnCalcularG.BorderRadius = 20;
            this.btnCalcularG.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalcularG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalcularG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalcularG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalcularG.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularG.ForeColor = System.Drawing.Color.White;
            this.btnCalcularG.Location = new System.Drawing.Point(280, 380);
            this.btnCalcularG.Name = "btnCalcularG";
            this.btnCalcularG.Size = new System.Drawing.Size(200, 53);
            this.btnCalcularG.TabIndex = 106;
            this.btnCalcularG.Text = "Calcular Polinomio";
            this.btnCalcularG.Click += new System.EventHandler(this.btnCalcularG_Click);
            // 
            // btnLimpiarG
            // 
            this.btnLimpiarG.BorderRadius = 20;
            this.btnLimpiarG.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiarG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiarG.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarG.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarG.Location = new System.Drawing.Point(531, 49);
            this.btnLimpiarG.Name = "btnLimpiarG";
            this.btnLimpiarG.Size = new System.Drawing.Size(160, 53);
            this.btnLimpiarG.TabIndex = 105;
            this.btnLimpiarG.Text = "Limpiar";
            this.btnLimpiarG.Click += new System.EventHandler(this.btnLimpiarG_Click);
            // 
            // btnAgregarPuntoG
            // 
            this.btnAgregarPuntoG.BorderRadius = 20;
            this.btnAgregarPuntoG.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarPuntoG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarPuntoG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarPuntoG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarPuntoG.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPuntoG.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPuntoG.Location = new System.Drawing.Point(305, 49);
            this.btnAgregarPuntoG.Name = "btnAgregarPuntoG";
            this.btnAgregarPuntoG.Size = new System.Drawing.Size(160, 53);
            this.btnAgregarPuntoG.TabIndex = 104;
            this.btnAgregarPuntoG.Text = "Añadir Punto";
            this.btnAgregarPuntoG.Click += new System.EventHandler(this.btnAgregarPuntoG_Click);
            // 
            // txtY
            // 
            this.txtY.Animated = true;
            this.txtY.AutoRoundedCorners = true;
            this.txtY.BackColor = System.Drawing.Color.Transparent;
            this.txtY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtY.BorderRadius = 12;
            this.txtY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtY.DefaultText = "";
            this.txtY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtY.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtY.Location = new System.Drawing.Point(82, 90);
            this.txtY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtY.Name = "txtY";
            this.txtY.PlaceholderText = "";
            this.txtY.SelectedText = "";
            this.txtY.Size = new System.Drawing.Size(160, 27);
            this.txtY.TabIndex = 102;
            // 
            // txtX
            // 
            this.txtX.Animated = true;
            this.txtX.AutoRoundedCorners = true;
            this.txtX.BackColor = System.Drawing.Color.Transparent;
            this.txtX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtX.BorderRadius = 12;
            this.txtX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtX.DefaultText = "";
            this.txtX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtX.Location = new System.Drawing.Point(82, 47);
            this.txtX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtX.Name = "txtX";
            this.txtX.PlaceholderText = "";
            this.txtX.SelectedText = "";
            this.txtX.Size = new System.Drawing.Size(160, 27);
            this.txtX.TabIndex = 101;
            // 
            // lblPuntosDiferencias
            // 
            this.lblPuntosDiferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntosDiferencias.Location = new System.Drawing.Point(50, 13);
            this.lblPuntosDiferencias.Name = "lblPuntosDiferencias";
            this.lblPuntosDiferencias.Size = new System.Drawing.Size(193, 30);
            this.lblPuntosDiferencias.TabIndex = 100;
            this.lblPuntosDiferencias.Text = "Ingrese sus puntos:";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(151, 149);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(68, 24);
            this.lblPuntos.TabIndex = 91;
            this.lblPuntos.Text = "Puntos";
            // 
            // lblLagrangePoli
            // 
            this.lblLagrangePoli.AutoSize = true;
            this.lblLagrangePoli.BackColor = System.Drawing.Color.Transparent;
            this.lblLagrangePoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLagrangePoli.Location = new System.Drawing.Point(467, 149);
            this.lblLagrangePoli.Name = "lblLagrangePoli";
            this.lblLagrangePoli.Size = new System.Drawing.Size(224, 24);
            this.lblLagrangePoli.TabIndex = 90;
            this.lblLagrangePoli.Text = "Interpolacion de lagrange";
            // 
            // txtPolinomio
            // 
            this.txtPolinomio.Enabled = false;
            this.txtPolinomio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolinomio.Location = new System.Drawing.Point(24, 450);
            this.txtPolinomio.Multiline = true;
            this.txtPolinomio.Name = "txtPolinomio";
            this.txtPolinomio.ReadOnly = true;
            this.txtPolinomio.Size = new System.Drawing.Size(732, 34);
            this.txtPolinomio.TabIndex = 4;
            this.txtPolinomio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPolinomio
            // 
            this.lblPolinomio.BackColor = System.Drawing.Color.Transparent;
            this.lblPolinomio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolinomio.Location = new System.Drawing.Point(26, 420);
            this.lblPolinomio.Name = "lblPolinomio";
            this.lblPolinomio.Size = new System.Drawing.Size(128, 27);
            this.lblPolinomio.TabIndex = 86;
            this.lblPolinomio.Text = "Polinomio:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.Transparent;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(49, 49);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(34, 25);
            this.lblX.TabIndex = 88;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.BackColor = System.Drawing.Color.Transparent;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(49, 90);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(35, 25);
            this.lblY.TabIndex = 89;
            this.lblY.Text = "Y:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(183, -84);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(457, 48);
            this.lblTitulo.TabIndex = 108;
            this.lblTitulo.Text = "Diferencias Divididas";
            // 
            // lblLagrange
            // 
            this.lblLagrange.AutoSize = true;
            this.lblLagrange.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLagrange.ForeColor = System.Drawing.Color.White;
            this.lblLagrange.Location = new System.Drawing.Point(159, 22);
            this.lblLagrange.Name = "lblLagrange";
            this.lblLagrange.Size = new System.Drawing.Size(495, 48);
            this.lblLagrange.TabIndex = 111;
            this.lblLagrange.Text = "Interpolacion Lagrange";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(699, 16);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton1.TabIndex = 112;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // btnRegresarG
            // 
            this.btnRegresarG.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRegresarG.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRegresarG.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresarG.Image")));
            this.btnRegresarG.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRegresarG.ImageRotate = 0F;
            this.btnRegresarG.Location = new System.Drawing.Point(723, -90);
            this.btnRegresarG.Name = "btnRegresarG";
            this.btnRegresarG.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRegresarG.Size = new System.Drawing.Size(64, 54);
            this.btnRegresarG.TabIndex = 110;
            // 
            // ElipseBlanco
            // 
            this.ElipseBlanco.BorderRadius = 20;
            this.ElipseBlanco.TargetControl = this.PanelBlanco;
            // 
            // ArrastrasPagina
            // 
            this.ArrastrasPagina.DockIndicatorTransparencyValue = 0.6D;
            this.ArrastrasPagina.TargetControl = this;
            this.ArrastrasPagina.TransparentWhileDrag = false;
            // 
            // ElipseNaranja
            // 
            this.ElipseNaranja.BorderRadius = 40;
            this.ElipseNaranja.TargetControl = this;
            // 
            // ArrastraLateral
            // 
            this.ArrastraLateral.DockIndicatorTransparencyValue = 0.6D;
            this.ArrastraLateral.TargetControl = this.lblLagrange;
            this.ArrastraLateral.UseTransparentDrag = true;
            // 
            // DGVLagrange
            // 
            this.DGVLagrange.AllowUserToAddRows = false;
            this.DGVLagrange.AllowUserToDeleteRows = false;
            this.DGVLagrange.AllowUserToResizeColumns = false;
            this.DGVLagrange.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PowderBlue;
            this.DGVLagrange.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVLagrange.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLagrange.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVLagrange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVLagrange.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGVLagrange.Location = new System.Drawing.Point(393, 176);
            this.DGVLagrange.MultiSelect = false;
            this.DGVLagrange.Name = "DGVLagrange";
            this.DGVLagrange.ReadOnly = true;
            this.DGVLagrange.RowHeadersVisible = false;
            this.DGVLagrange.RowHeadersWidth = 51;
            this.DGVLagrange.Size = new System.Drawing.Size(363, 186);
            this.DGVLagrange.TabIndex = 111;
            // 
            // Lagrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.lblLagrange);
            this.Controls.Add(this.btnRegresarG);
            this.Controls.Add(this.PanelBlanco);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lagrange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lagrange";
            this.Load += new System.EventHandler(this.Lagrange_Load);
            this.PanelBlanco.ResumeLayout(false);
            this.PanelBlanco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLagrange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnRegresarG;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelBlanco;
        private System.Windows.Forms.DataGridView DGVEntrada;
        private Guna.UI2.WinForms.Guna2Button btnGrafica;
        private System.Windows.Forms.TextBox txtPoliSimp;
        private System.Windows.Forms.Label lblPoliSimp;
        private Guna.UI2.WinForms.Guna2Button btnCalcularG;
        private Guna.UI2.WinForms.Guna2Button btnLimpiarG;
        private Guna.UI2.WinForms.Guna2Button btnAgregarPuntoG;
        private Guna.UI2.WinForms.Guna2TextBox txtY;
        private Guna.UI2.WinForms.Guna2TextBox txtX;
        private System.Windows.Forms.Label lblPuntosDiferencias;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblLagrangePoli;
        private System.Windows.Forms.TextBox txtPolinomio;
        private System.Windows.Forms.Label lblPolinomio;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblLagrange;
        private Guna.UI2.WinForms.Guna2Elipse ElipseBlanco;
        private Guna.UI2.WinForms.Guna2DragControl ArrastrasPagina;
        private Guna.UI2.WinForms.Guna2Elipse ElipseNaranja;
        private Guna.UI2.WinForms.Guna2DragControl ArrastraLateral;
        private System.Windows.Forms.DataGridView DGVLagrange;
    }
}