namespace Metodos_Numeros
{
    partial class Metodo_De_Biseccion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVBiseccion = new System.Windows.Forms.DataGridView();
            this.btnCorrerBiseccion = new System.Windows.Forms.Button();
            this.labelMetodoBiseccion = new System.Windows.Forms.Label();
            this.btnGraficaBiseccion = new System.Windows.Forms.Button();
            this.txtFuncionBiseccionGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtParametroABiseccionGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtParametroBBiseccionGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtErrorBiseccionGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.MensajeGunaDatosFaltantes = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.labelFuncion = new System.Windows.Forms.Label();
            this.labelParametroA = new System.Windows.Forms.Label();
            this.labelParametroB = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.MensajeGunaResultado = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ImageButtonRegresar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAyuda = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAnimacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBiseccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVBiseccion
            // 
            this.DGVBiseccion.AllowUserToDeleteRows = false;
            this.DGVBiseccion.AllowUserToResizeColumns = false;
            this.DGVBiseccion.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBiseccion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVBiseccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBiseccion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVBiseccion.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.DGVBiseccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBiseccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVBiseccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVBiseccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVBiseccion.EnableHeadersVisualStyles = false;
            this.DGVBiseccion.GridColor = System.Drawing.Color.LightSeaGreen;
            this.DGVBiseccion.Location = new System.Drawing.Point(12, 267);
            this.DGVBiseccion.Name = "DGVBiseccion";
            this.DGVBiseccion.ReadOnly = true;
            this.DGVBiseccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVBiseccion.RowHeadersVisible = false;
            this.DGVBiseccion.RowHeadersWidth = 60;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DGVBiseccion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVBiseccion.Size = new System.Drawing.Size(689, 196);
            this.DGVBiseccion.TabIndex = 82;
            // 
            // btnCorrerBiseccion
            // 
            this.btnCorrerBiseccion.Location = new System.Drawing.Point(707, 278);
            this.btnCorrerBiseccion.Name = "btnCorrerBiseccion";
            this.btnCorrerBiseccion.Size = new System.Drawing.Size(93, 28);
            this.btnCorrerBiseccion.TabIndex = 81;
            this.btnCorrerBiseccion.Text = "Correr";
            this.btnCorrerBiseccion.UseVisualStyleBackColor = true;
            this.btnCorrerBiseccion.Click += new System.EventHandler(this.btnCorrerBiseccion_Click);
            // 
            // labelMetodoBiseccion
            // 
            this.labelMetodoBiseccion.AutoSize = true;
            this.labelMetodoBiseccion.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetodoBiseccion.Location = new System.Drawing.Point(6, 9);
            this.labelMetodoBiseccion.Name = "labelMetodoBiseccion";
            this.labelMetodoBiseccion.Size = new System.Drawing.Size(323, 35);
            this.labelMetodoBiseccion.TabIndex = 73;
            this.labelMetodoBiseccion.Text = "Metodo de Biseccion";
            // 
            // btnGraficaBiseccion
            // 
            this.btnGraficaBiseccion.Location = new System.Drawing.Point(728, 323);
            this.btnGraficaBiseccion.Name = "btnGraficaBiseccion";
            this.btnGraficaBiseccion.Size = new System.Drawing.Size(62, 38);
            this.btnGraficaBiseccion.TabIndex = 86;
            this.btnGraficaBiseccion.Text = "Generar Grafica";
            this.btnGraficaBiseccion.UseVisualStyleBackColor = true;
            this.btnGraficaBiseccion.Click += new System.EventHandler(this.btnGraficaBiseccion_Click);
            // 
            // txtFuncionBiseccionGuna
            // 
            this.txtFuncionBiseccionGuna.Animated = true;
            this.txtFuncionBiseccionGuna.AutoRoundedCorners = true;
            this.txtFuncionBiseccionGuna.BackColor = System.Drawing.Color.Transparent;
            this.txtFuncionBiseccionGuna.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtFuncionBiseccionGuna.BorderRadius = 12;
            this.txtFuncionBiseccionGuna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFuncionBiseccionGuna.DefaultText = "";
            this.txtFuncionBiseccionGuna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFuncionBiseccionGuna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFuncionBiseccionGuna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuncionBiseccionGuna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuncionBiseccionGuna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuncionBiseccionGuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFuncionBiseccionGuna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuncionBiseccionGuna.Location = new System.Drawing.Point(173, 61);
            this.txtFuncionBiseccionGuna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFuncionBiseccionGuna.Name = "txtFuncionBiseccionGuna";
            this.txtFuncionBiseccionGuna.PlaceholderText = "";
            this.txtFuncionBiseccionGuna.SelectedText = "";
            this.txtFuncionBiseccionGuna.Size = new System.Drawing.Size(160, 27);
            this.txtFuncionBiseccionGuna.TabIndex = 88;
            // 
            // txtParametroABiseccionGuna
            // 
            this.txtParametroABiseccionGuna.Animated = true;
            this.txtParametroABiseccionGuna.AutoRoundedCorners = true;
            this.txtParametroABiseccionGuna.BackColor = System.Drawing.Color.Transparent;
            this.txtParametroABiseccionGuna.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtParametroABiseccionGuna.BorderRadius = 12;
            this.txtParametroABiseccionGuna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParametroABiseccionGuna.DefaultText = "";
            this.txtParametroABiseccionGuna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtParametroABiseccionGuna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtParametroABiseccionGuna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtParametroABiseccionGuna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtParametroABiseccionGuna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtParametroABiseccionGuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtParametroABiseccionGuna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtParametroABiseccionGuna.Location = new System.Drawing.Point(216, 103);
            this.txtParametroABiseccionGuna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtParametroABiseccionGuna.Name = "txtParametroABiseccionGuna";
            this.txtParametroABiseccionGuna.PlaceholderText = "";
            this.txtParametroABiseccionGuna.SelectedText = "";
            this.txtParametroABiseccionGuna.Size = new System.Drawing.Size(66, 27);
            this.txtParametroABiseccionGuna.TabIndex = 89;
            // 
            // txtParametroBBiseccionGuna
            // 
            this.txtParametroBBiseccionGuna.Animated = true;
            this.txtParametroBBiseccionGuna.AutoRoundedCorners = true;
            this.txtParametroBBiseccionGuna.BackColor = System.Drawing.Color.Transparent;
            this.txtParametroBBiseccionGuna.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtParametroBBiseccionGuna.BorderRadius = 12;
            this.txtParametroBBiseccionGuna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParametroBBiseccionGuna.DefaultText = "";
            this.txtParametroBBiseccionGuna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtParametroBBiseccionGuna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtParametroBBiseccionGuna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtParametroBBiseccionGuna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtParametroBBiseccionGuna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtParametroBBiseccionGuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtParametroBBiseccionGuna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtParametroBBiseccionGuna.Location = new System.Drawing.Point(216, 145);
            this.txtParametroBBiseccionGuna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtParametroBBiseccionGuna.Name = "txtParametroBBiseccionGuna";
            this.txtParametroBBiseccionGuna.PlaceholderText = "";
            this.txtParametroBBiseccionGuna.SelectedText = "";
            this.txtParametroBBiseccionGuna.Size = new System.Drawing.Size(66, 27);
            this.txtParametroBBiseccionGuna.TabIndex = 90;
            // 
            // txtErrorBiseccionGuna
            // 
            this.txtErrorBiseccionGuna.Animated = true;
            this.txtErrorBiseccionGuna.AutoRoundedCorners = true;
            this.txtErrorBiseccionGuna.BackColor = System.Drawing.Color.Transparent;
            this.txtErrorBiseccionGuna.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtErrorBiseccionGuna.BorderRadius = 12;
            this.txtErrorBiseccionGuna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtErrorBiseccionGuna.DefaultText = "";
            this.txtErrorBiseccionGuna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtErrorBiseccionGuna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtErrorBiseccionGuna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtErrorBiseccionGuna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtErrorBiseccionGuna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtErrorBiseccionGuna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtErrorBiseccionGuna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtErrorBiseccionGuna.Location = new System.Drawing.Point(216, 193);
            this.txtErrorBiseccionGuna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtErrorBiseccionGuna.Name = "txtErrorBiseccionGuna";
            this.txtErrorBiseccionGuna.PlaceholderText = "";
            this.txtErrorBiseccionGuna.SelectedText = "";
            this.txtErrorBiseccionGuna.Size = new System.Drawing.Size(66, 27);
            this.txtErrorBiseccionGuna.TabIndex = 91;
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
            // labelFuncion
            // 
            this.labelFuncion.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncion.Location = new System.Drawing.Point(8, 49);
            this.labelFuncion.Name = "labelFuncion";
            this.labelFuncion.Size = new System.Drawing.Size(151, 47);
            this.labelFuncion.TabIndex = 93;
            this.labelFuncion.Text = "\r\nIngrese la funcion:\r\n\r\n";
            this.labelFuncion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelParametroA
            // 
            this.labelParametroA.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParametroA.Location = new System.Drawing.Point(8, 91);
            this.labelParametroA.Name = "labelParametroA";
            this.labelParametroA.Size = new System.Drawing.Size(159, 39);
            this.labelParametroA.TabIndex = 94;
            this.labelParametroA.Text = "\r\nIngrese parametro a:\r\n";
            // 
            // labelParametroB
            // 
            this.labelParametroB.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParametroB.Location = new System.Drawing.Point(8, 133);
            this.labelParametroB.Name = "labelParametroB";
            this.labelParametroB.Size = new System.Drawing.Size(173, 39);
            this.labelParametroB.TabIndex = 95;
            this.labelParametroB.Text = "\r\nIngrese parametro b:\r\n";
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(9, 180);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(200, 39);
            this.labelError.TabIndex = 96;
            this.labelError.Text = "\r\nIngrese el error deseado:\r\n";
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
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImage = global::Metodos_Numeros.Properties.Resources.La_Chica;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.ErrorImage = global::Metodos_Numeros.Properties.Resources.La_Chica;
            this.guna2PictureBox1.Image = global::Metodos_Numeros.Properties.Resources.La_Chica;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = global::Metodos_Numeros.Properties.Resources.La_Chica;
            this.guna2PictureBox1.Location = new System.Drawing.Point(412, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(110, 74);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 98;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2ImageButtonRegresar
            // 
            this.guna2ImageButtonRegresar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButtonRegresar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButtonRegresar.Image = global::Metodos_Numeros.Properties.Resources.arrow_return_left_icon_160458;
            this.guna2ImageButtonRegresar.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButtonRegresar.ImageRotate = 0F;
            this.guna2ImageButtonRegresar.Location = new System.Drawing.Point(726, 409);
            this.guna2ImageButtonRegresar.Name = "guna2ImageButtonRegresar";
            this.guna2ImageButtonRegresar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButtonRegresar.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButtonRegresar.TabIndex = 97;
            this.guna2ImageButtonRegresar.Click += new System.EventHandler(this.guna2ImageButtonRegresar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAyuda.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAyuda.Image = global::Metodos_Numeros.Properties.Resources.stock_helpagent_104167;
            this.btnAyuda.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAyuda.ImageRotate = 0F;
            this.btnAyuda.Location = new System.Drawing.Point(737, -3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAyuda.Size = new System.Drawing.Size(64, 68);
            this.btnAyuda.TabIndex = 87;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnAnimacion
            // 
            this.btnAnimacion.Location = new System.Drawing.Point(586, 161);
            this.btnAnimacion.Name = "btnAnimacion";
            this.btnAnimacion.Size = new System.Drawing.Size(93, 28);
            this.btnAnimacion.TabIndex = 99;
            this.btnAnimacion.Text = "Correr";
            this.btnAnimacion.UseVisualStyleBackColor = true;
            // 
            // Metodo_De_Biseccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnimacion);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2ImageButtonRegresar);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelParametroB);
            this.Controls.Add(this.labelParametroA);
            this.Controls.Add(this.labelFuncion);
            this.Controls.Add(this.txtErrorBiseccionGuna);
            this.Controls.Add(this.txtParametroBBiseccionGuna);
            this.Controls.Add(this.txtParametroABiseccionGuna);
            this.Controls.Add(this.txtFuncionBiseccionGuna);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnGraficaBiseccion);
            this.Controls.Add(this.DGVBiseccion);
            this.Controls.Add(this.btnCorrerBiseccion);
            this.Controls.Add(this.labelMetodoBiseccion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Metodo_De_Biseccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animacion ";
            this.Load += new System.EventHandler(this.Metodo_De_Biseccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBiseccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVBiseccion;
        private System.Windows.Forms.Button btnCorrerBiseccion;
        private System.Windows.Forms.Label labelMetodoBiseccion;
        private System.Windows.Forms.Button btnGraficaBiseccion;
        private Guna.UI2.WinForms.Guna2ImageButton btnAyuda;
        private Guna.UI2.WinForms.Guna2TextBox txtFuncionBiseccionGuna;
        private Guna.UI2.WinForms.Guna2TextBox txtParametroABiseccionGuna;
        private Guna.UI2.WinForms.Guna2TextBox txtParametroBBiseccionGuna;
        private Guna.UI2.WinForms.Guna2TextBox txtErrorBiseccionGuna;
        private Guna.UI2.WinForms.Guna2MessageDialog MensajeGunaDatosFaltantes;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelParametroB;
        private System.Windows.Forms.Label labelParametroA;
        private System.Windows.Forms.Label labelFuncion;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButtonRegresar;
        private Guna.UI2.WinForms.Guna2MessageDialog MensajeGunaResultado;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Button btnAnimacion;
    }
}