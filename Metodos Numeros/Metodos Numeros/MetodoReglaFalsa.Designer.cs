﻿namespace Metodos_Numeros
{
    partial class Metodo_De_Regla_Falsa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metodo_De_Regla_Falsa));
            this.DGVReglaFalsa = new System.Windows.Forms.DataGridView();
            this.lblMetodoReglaFalsa = new System.Windows.Forms.Label();
            this.lblErrorRF = new System.Windows.Forms.Label();
            this.lblParametroBRF = new System.Windows.Forms.Label();
            this.lvlParametroARF = new System.Windows.Forms.Label();
            this.lblFuncionRF = new System.Windows.Forms.Label();
            this.txtErrorReglaFGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtParametroBReglaFGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtParametroAReglaFGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFuncionReglaFGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.SinBordes = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.MoverForms = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnRegresar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAyuda = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnCorrerMetodo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnGrafica = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnAnimacion = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.MensajeGuna2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MensajeGuna1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MensajeGuna3 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MensajeGuna4 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MensajeGunaResultado = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MensajeGunaDatosFaltantes = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReglaFalsa)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVReglaFalsa
            // 
            this.DGVReglaFalsa.AllowUserToAddRows = false;
            this.DGVReglaFalsa.AllowUserToDeleteRows = false;
            this.DGVReglaFalsa.AllowUserToResizeColumns = false;
            this.DGVReglaFalsa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            this.DGVReglaFalsa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVReglaFalsa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVReglaFalsa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVReglaFalsa.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.DGVReglaFalsa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVReglaFalsa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVReglaFalsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVReglaFalsa.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVReglaFalsa.GridColor = System.Drawing.Color.Cornsilk;
            this.DGVReglaFalsa.Location = new System.Drawing.Point(12, 236);
            this.DGVReglaFalsa.Name = "DGVReglaFalsa";
            this.DGVReglaFalsa.ReadOnly = true;
            this.DGVReglaFalsa.RowHeadersVisible = false;
            this.DGVReglaFalsa.RowHeadersWidth = 51;
            this.DGVReglaFalsa.Size = new System.Drawing.Size(689, 237);
            this.DGVReglaFalsa.TabIndex = 82;
            this.DGVReglaFalsa.Visible = false;
            // 
            // lblMetodoReglaFalsa
            // 
            this.lblMetodoReglaFalsa.AutoSize = true;
            this.lblMetodoReglaFalsa.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoReglaFalsa.ForeColor = System.Drawing.Color.Black;
            this.lblMetodoReglaFalsa.Location = new System.Drawing.Point(12, 9);
            this.lblMetodoReglaFalsa.Name = "lblMetodoReglaFalsa";
            this.lblMetodoReglaFalsa.Size = new System.Drawing.Size(348, 35);
            this.lblMetodoReglaFalsa.TabIndex = 74;
            this.lblMetodoReglaFalsa.Text = "Metodo de Regla Falsa";
            // 
            // lblErrorRF
            // 
            this.lblErrorRF.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRF.Location = new System.Drawing.Point(15, 191);
            this.lblErrorRF.Name = "lblErrorRF";
            this.lblErrorRF.Size = new System.Drawing.Size(200, 39);
            this.lblErrorRF.TabIndex = 106;
            this.lblErrorRF.Text = "\r\nIngrese el error deseado:\r\n";
            // 
            // lblParametroBRF
            // 
            this.lblParametroBRF.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametroBRF.Location = new System.Drawing.Point(14, 144);
            this.lblParametroBRF.Name = "lblParametroBRF";
            this.lblParametroBRF.Size = new System.Drawing.Size(173, 39);
            this.lblParametroBRF.TabIndex = 105;
            this.lblParametroBRF.Text = "\r\nIngrese parametro b:\r\n";
            // 
            // lvlParametroARF
            // 
            this.lvlParametroARF.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlParametroARF.Location = new System.Drawing.Point(14, 102);
            this.lvlParametroARF.Name = "lvlParametroARF";
            this.lvlParametroARF.Size = new System.Drawing.Size(173, 39);
            this.lvlParametroARF.TabIndex = 104;
            this.lvlParametroARF.Text = "\r\nIngrese parametro a:\r\n";
            // 
            // lblFuncionRF
            // 
            this.lblFuncionRF.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionRF.Location = new System.Drawing.Point(14, 55);
            this.lblFuncionRF.Name = "lblFuncionRF";
            this.lblFuncionRF.Size = new System.Drawing.Size(156, 39);
            this.lblFuncionRF.TabIndex = 103;
            this.lblFuncionRF.Text = "\r\nIngrese la funcion:\r\n\r\n";
            this.lblFuncionRF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtErrorReglaFGuna
            // 
            this.txtErrorReglaFGuna.Animated = true;
            this.txtErrorReglaFGuna.AutoRoundedCorners = true;
            this.txtErrorReglaFGuna.BackColor = System.Drawing.Color.Transparent;
            this.txtErrorReglaFGuna.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtErrorReglaFGuna.BorderRadius = 12;
            this.txtErrorReglaFGuna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtErrorReglaFGuna.DefaultText = "";
            this.txtErrorReglaFGuna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtErrorReglaFGuna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtErrorReglaFGuna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtErrorReglaFGuna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtErrorReglaFGuna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtErrorReglaFGuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtErrorReglaFGuna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtErrorReglaFGuna.Location = new System.Drawing.Point(221, 203);
            this.txtErrorReglaFGuna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtErrorReglaFGuna.Name = "txtErrorReglaFGuna";
            this.txtErrorReglaFGuna.PlaceholderText = "";
            this.txtErrorReglaFGuna.SelectedText = "";
            this.txtErrorReglaFGuna.Size = new System.Drawing.Size(66, 27);
            this.txtErrorReglaFGuna.TabIndex = 102;
            // 
            // txtParametroBReglaFGuna
            // 
            this.txtParametroBReglaFGuna.Animated = true;
            this.txtParametroBReglaFGuna.AutoRoundedCorners = true;
            this.txtParametroBReglaFGuna.BackColor = System.Drawing.Color.Transparent;
            this.txtParametroBReglaFGuna.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtParametroBReglaFGuna.BorderRadius = 12;
            this.txtParametroBReglaFGuna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParametroBReglaFGuna.DefaultText = "";
            this.txtParametroBReglaFGuna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtParametroBReglaFGuna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtParametroBReglaFGuna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtParametroBReglaFGuna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtParametroBReglaFGuna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtParametroBReglaFGuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtParametroBReglaFGuna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtParametroBReglaFGuna.Location = new System.Drawing.Point(221, 156);
            this.txtParametroBReglaFGuna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtParametroBReglaFGuna.Name = "txtParametroBReglaFGuna";
            this.txtParametroBReglaFGuna.PlaceholderText = "";
            this.txtParametroBReglaFGuna.SelectedText = "";
            this.txtParametroBReglaFGuna.Size = new System.Drawing.Size(66, 27);
            this.txtParametroBReglaFGuna.TabIndex = 101;
            // 
            // txtParametroAReglaFGuna
            // 
            this.txtParametroAReglaFGuna.Animated = true;
            this.txtParametroAReglaFGuna.AutoRoundedCorners = true;
            this.txtParametroAReglaFGuna.BackColor = System.Drawing.Color.Transparent;
            this.txtParametroAReglaFGuna.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtParametroAReglaFGuna.BorderRadius = 12;
            this.txtParametroAReglaFGuna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParametroAReglaFGuna.DefaultText = "";
            this.txtParametroAReglaFGuna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtParametroAReglaFGuna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtParametroAReglaFGuna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtParametroAReglaFGuna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtParametroAReglaFGuna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtParametroAReglaFGuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtParametroAReglaFGuna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtParametroAReglaFGuna.Location = new System.Drawing.Point(221, 114);
            this.txtParametroAReglaFGuna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtParametroAReglaFGuna.Name = "txtParametroAReglaFGuna";
            this.txtParametroAReglaFGuna.PlaceholderText = "";
            this.txtParametroAReglaFGuna.SelectedText = "";
            this.txtParametroAReglaFGuna.Size = new System.Drawing.Size(66, 27);
            this.txtParametroAReglaFGuna.TabIndex = 100;
            // 
            // txtFuncionReglaFGuna
            // 
            this.txtFuncionReglaFGuna.Animated = true;
            this.txtFuncionReglaFGuna.AutoRoundedCorners = true;
            this.txtFuncionReglaFGuna.BackColor = System.Drawing.Color.Transparent;
            this.txtFuncionReglaFGuna.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtFuncionReglaFGuna.BorderRadius = 12;
            this.txtFuncionReglaFGuna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFuncionReglaFGuna.DefaultText = "";
            this.txtFuncionReglaFGuna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFuncionReglaFGuna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFuncionReglaFGuna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuncionReglaFGuna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuncionReglaFGuna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuncionReglaFGuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFuncionReglaFGuna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuncionReglaFGuna.Location = new System.Drawing.Point(175, 67);
            this.txtFuncionReglaFGuna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFuncionReglaFGuna.Name = "txtFuncionReglaFGuna";
            this.txtFuncionReglaFGuna.PlaceholderText = "";
            this.txtFuncionReglaFGuna.SelectedText = "";
            this.txtFuncionReglaFGuna.Size = new System.Drawing.Size(160, 27);
            this.txtFuncionReglaFGuna.TabIndex = 99;
            // 
            // SinBordes
            // 
            this.SinBordes.ContainerControl = this;
            this.SinBordes.DockIndicatorTransparencyValue = 0.6D;
            this.SinBordes.TransparentWhileDrag = true;
            // 
            // MoverForms
            // 
            this.MoverForms.DockIndicatorTransparencyValue = 0.6D;
            this.MoverForms.TargetControl = this;
            this.MoverForms.TransparentWhileDrag = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRegresar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRegresar.Image = global::Metodos_Numeros.Properties.Resources.arrow_return_left_icon_160458;
            this.btnRegresar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRegresar.ImageRotate = 0F;
            this.btnRegresar.Location = new System.Drawing.Point(724, 409);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRegresar.Size = new System.Drawing.Size(64, 54);
            this.btnRegresar.TabIndex = 98;
            this.btnRegresar.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAyuda.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAyuda.Image = global::Metodos_Numeros.Properties.Resources.stock_helpagent_104167;
            this.btnAyuda.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAyuda.ImageRotate = 0F;
            this.btnAyuda.Location = new System.Drawing.Point(735, -1);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAyuda.Size = new System.Drawing.Size(64, 68);
            this.btnAyuda.TabIndex = 88;
            this.btnAyuda.TabStop = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnCorrerMetodo
            // 
            this.btnCorrerMetodo.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrerMetodo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCorrerMetodo.HoverState.ImageSize = new System.Drawing.Size(250, 250);
            this.btnCorrerMetodo.Image = global::Metodos_Numeros.Properties.Resources.inisio_removebg_preview;
            this.btnCorrerMetodo.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCorrerMetodo.ImageRotate = 0F;
            this.btnCorrerMetodo.ImageSize = new System.Drawing.Size(250, 250);
            this.btnCorrerMetodo.Location = new System.Drawing.Point(395, 94);
            this.btnCorrerMetodo.Name = "btnCorrerMetodo";
            this.btnCorrerMetodo.PressedState.ImageSize = new System.Drawing.Size(250, 250);
            this.btnCorrerMetodo.Size = new System.Drawing.Size(204, 89);
            this.btnCorrerMetodo.TabIndex = 111;
            this.btnCorrerMetodo.Click += new System.EventHandler(this.btnCorrerMetodo_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.BorderRadius = 20;
            this.btnGrafica.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrafica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrafica.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGrafica.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGrafica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGrafica.FillColor = System.Drawing.Color.Cornsilk;
            this.btnGrafica.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGrafica.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGrafica.ForeColor = System.Drawing.Color.White;
            this.btnGrafica.Location = new System.Drawing.Point(707, 348);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(92, 55);
            this.btnGrafica.TabIndex = 113;
            this.btnGrafica.Text = "Generar Gráfica";
            this.btnGrafica.Visible = false;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnAnimacion
            // 
            this.btnAnimacion.BorderRadius = 20;
            this.btnAnimacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnimacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnimacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnimacion.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnimacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnimacion.FillColor = System.Drawing.Color.Cornsilk;
            this.btnAnimacion.FillColor2 = System.Drawing.Color.MediumVioletRed;
            this.btnAnimacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAnimacion.ForeColor = System.Drawing.Color.White;
            this.btnAnimacion.Location = new System.Drawing.Point(707, 266);
            this.btnAnimacion.Name = "btnAnimacion";
            this.btnAnimacion.Size = new System.Drawing.Size(92, 55);
            this.btnAnimacion.TabIndex = 112;
            this.btnAnimacion.Text = "Animación";
            this.btnAnimacion.Visible = false;
            this.btnAnimacion.Click += new System.EventHandler(this.btnAnimacion_Click);
            // 
            // MensajeGuna2
            // 
            this.MensajeGuna2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MensajeGuna2.Caption = "Error";
            this.MensajeGuna2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.MensajeGuna2.Parent = this;
            this.MensajeGuna2.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MensajeGuna2.Text = "Ingrese una funcion valida";
            // 
            // MensajeGuna1
            // 
            this.MensajeGuna1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MensajeGuna1.Caption = "Error";
            this.MensajeGuna1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.MensajeGuna1.Parent = this;
            this.MensajeGuna1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MensajeGuna1.Text = "Datos faltantes o incorrectos, Intente denuevo";
            // 
            // MensajeGuna3
            // 
            this.MensajeGuna3.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MensajeGuna3.Caption = "Error";
            this.MensajeGuna3.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.MensajeGuna3.Parent = this;
            this.MensajeGuna3.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MensajeGuna3.Text = "Valor de inicio invalido ";
            // 
            // MensajeGuna4
            // 
            this.MensajeGuna4.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MensajeGuna4.Caption = "Error";
            this.MensajeGuna4.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.MensajeGuna4.Parent = this;
            this.MensajeGuna4.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MensajeGuna4.Text = "Valor de fin invalido";
            // 
            // MensajeGunaResultado
            // 
            this.MensajeGunaResultado.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MensajeGunaResultado.Caption = "Método Biseccion Detectó";
            this.MensajeGunaResultado.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MensajeGunaResultado.Parent = this;
            this.MensajeGunaResultado.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MensajeGunaResultado.Text = "";
            // 
            // MensajeGunaDatosFaltantes
            // 
            this.MensajeGunaDatosFaltantes.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MensajeGunaDatosFaltantes.Caption = "Error";
            this.MensajeGunaDatosFaltantes.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.MensajeGunaDatosFaltantes.Parent = this;
            this.MensajeGunaDatosFaltantes.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MensajeGunaDatosFaltantes.Text = "Datos faltantes o Incorrectos, Intente denuevo";
            // 
            // Metodo_De_Regla_Falsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.ControlBox = false;
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.btnAnimacion);
            this.Controls.Add(this.btnCorrerMetodo);
            this.Controls.Add(this.lblErrorRF);
            this.Controls.Add(this.lblParametroBRF);
            this.Controls.Add(this.lvlParametroARF);
            this.Controls.Add(this.lblFuncionRF);
            this.Controls.Add(this.txtErrorReglaFGuna);
            this.Controls.Add(this.txtParametroBReglaFGuna);
            this.Controls.Add(this.txtParametroAReglaFGuna);
            this.Controls.Add(this.txtFuncionReglaFGuna);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.DGVReglaFalsa);
            this.Controls.Add(this.lblMetodoReglaFalsa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Metodo_De_Regla_Falsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo de Regla Falsa";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReglaFalsa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVReglaFalsa;
        private System.Windows.Forms.Label lblMetodoReglaFalsa;
        private Guna.UI2.WinForms.Guna2ImageButton btnAyuda;
        private Guna.UI2.WinForms.Guna2ImageButton btnRegresar;
        private System.Windows.Forms.Label lblErrorRF;
        private System.Windows.Forms.Label lblParametroBRF;
        private System.Windows.Forms.Label lvlParametroARF;
        private System.Windows.Forms.Label lblFuncionRF;
        private Guna.UI2.WinForms.Guna2TextBox txtErrorReglaFGuna;
        private Guna.UI2.WinForms.Guna2TextBox txtParametroBReglaFGuna;
        private Guna.UI2.WinForms.Guna2TextBox txtParametroAReglaFGuna;
        private Guna.UI2.WinForms.Guna2TextBox txtFuncionReglaFGuna;
        private Guna.UI2.WinForms.Guna2BorderlessForm SinBordes;
        private Guna.UI2.WinForms.Guna2DragControl MoverForms;
        private Guna.UI2.WinForms.Guna2ImageButton btnCorrerMetodo;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnGrafica;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAnimacion;
        private Guna.UI2.WinForms.Guna2MessageDialog MensajeGuna2;
        private Guna.UI2.WinForms.Guna2MessageDialog MensajeGuna1;
        private Guna.UI2.WinForms.Guna2MessageDialog MensajeGuna3;
        private Guna.UI2.WinForms.Guna2MessageDialog MensajeGuna4;
        private Guna.UI2.WinForms.Guna2MessageDialog MensajeGunaResultado;
        private Guna.UI2.WinForms.Guna2MessageDialog MensajeGunaDatosFaltantes;
    }
}