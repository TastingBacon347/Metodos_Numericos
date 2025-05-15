namespace Metodos_Numeros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lbl12 = new System.Windows.Forms.Label();
            this.btnGraficaReglaFalsa = new System.Windows.Forms.Button();
            this.MensajeGuna4 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MensajeGuna3 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MensajeGuna1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MensajeGuna2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtErrorReglaFGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtParametroBReglaFGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtParametroAReglaFGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFuncionReglaFGuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAyuda = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReglaFalsa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCorrerReglaFalsa
            // 
            this.btnCorrerReglaFalsa.ForeColor = System.Drawing.Color.Black;
            this.btnCorrerReglaFalsa.Location = new System.Drawing.Point(543, 55);
            this.btnCorrerReglaFalsa.Name = "btnCorrerReglaFalsa";
            this.btnCorrerReglaFalsa.Size = new System.Drawing.Size(93, 28);
            this.btnCorrerReglaFalsa.TabIndex = 83;
            this.btnCorrerReglaFalsa.Text = "Correr";
            this.btnCorrerReglaFalsa.UseVisualStyleBackColor = true;
            this.btnCorrerReglaFalsa.Click += new System.EventHandler(this.btnCorrerReglaFalsa_Click);
            // 
            // DGVReglaFalsa
            // 
            this.DGVReglaFalsa.AllowUserToDeleteRows = false;
            this.DGVReglaFalsa.AllowUserToResizeColumns = false;
            this.DGVReglaFalsa.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Beige;
            this.DGVReglaFalsa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DGVReglaFalsa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVReglaFalsa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVReglaFalsa.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.DGVReglaFalsa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVReglaFalsa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVReglaFalsa.DefaultCellStyle = dataGridViewCellStyle22;
            this.DGVReglaFalsa.GridColor = System.Drawing.Color.Cornsilk;
            this.DGVReglaFalsa.Location = new System.Drawing.Point(12, 298);
            this.DGVReglaFalsa.Name = "DGVReglaFalsa";
            this.DGVReglaFalsa.ReadOnly = true;
            this.DGVReglaFalsa.RowHeadersVisible = false;
            this.DGVReglaFalsa.RowHeadersWidth = 51;
            this.DGVReglaFalsa.Size = new System.Drawing.Size(706, 175);
            this.DGVReglaFalsa.TabIndex = 82;
            // 
            // a
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.a.DefaultCellStyle = dataGridViewCellStyle14;
            this.a.HeaderText = "a";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.ReadOnly = true;
            // 
            // b
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.b.DefaultCellStyle = dataGridViewCellStyle15;
            this.b.HeaderText = "b";
            this.b.MinimumWidth = 6;
            this.b.Name = "b";
            this.b.ReadOnly = true;
            // 
            // c
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.c.DefaultCellStyle = dataGridViewCellStyle16;
            this.c.HeaderText = "c";
            this.c.MinimumWidth = 6;
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // fa
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.fa.DefaultCellStyle = dataGridViewCellStyle17;
            this.fa.HeaderText = "f(a)";
            this.fa.MinimumWidth = 6;
            this.fa.Name = "fa";
            this.fa.ReadOnly = true;
            // 
            // fb
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fb.DefaultCellStyle = dataGridViewCellStyle18;
            this.fb.HeaderText = "f(b)";
            this.fb.MinimumWidth = 6;
            this.fb.Name = "fb";
            this.fb.ReadOnly = true;
            // 
            // fc
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fc.DefaultCellStyle = dataGridViewCellStyle19;
            this.fc.HeaderText = "f(c)";
            this.fc.MinimumWidth = 6;
            this.fc.Name = "fc";
            this.fc.ReadOnly = true;
            // 
            // IzqoDer
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IzqoDer.DefaultCellStyle = dataGridViewCellStyle20;
            this.IzqoDer.HeaderText = "Izq o Der";
            this.IzqoDer.MinimumWidth = 6;
            this.IzqoDer.Name = "IzqoDer";
            this.IzqoDer.ReadOnly = true;
            // 
            // ErrorAbsoluto
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ErrorAbsoluto.DefaultCellStyle = dataGridViewCellStyle21;
            this.ErrorAbsoluto.HeaderText = "ErrorAbsoluto";
            this.ErrorAbsoluto.MinimumWidth = 6;
            this.ErrorAbsoluto.Name = "ErrorAbsoluto";
            this.ErrorAbsoluto.ReadOnly = true;
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("MS PGothic", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.Black;
            this.lbl12.Location = new System.Drawing.Point(12, 9);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(348, 35);
            this.lbl12.TabIndex = 74;
            this.lbl12.Text = "Metodo de Regla Falsa";
            // 
            // btnGraficaReglaFalsa
            // 
            this.btnGraficaReglaFalsa.Location = new System.Drawing.Point(515, 182);
            this.btnGraficaReglaFalsa.Name = "btnGraficaReglaFalsa";
            this.btnGraficaReglaFalsa.Size = new System.Drawing.Size(163, 38);
            this.btnGraficaReglaFalsa.TabIndex = 87;
            this.btnGraficaReglaFalsa.Text = "Generar Grafica";
            this.btnGraficaReglaFalsa.UseVisualStyleBackColor = true;
            this.btnGraficaReglaFalsa.Click += new System.EventHandler(this.btnGraficaBiseccion_Click);
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
            // MensajeGuna3
            // 
            this.MensajeGuna3.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MensajeGuna3.Caption = "Error";
            this.MensajeGuna3.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.MensajeGuna3.Parent = this;
            this.MensajeGuna3.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MensajeGuna3.Text = "Valor de inicio invalido ";
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
            // MensajeGuna2
            // 
            this.MensajeGuna2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MensajeGuna2.Caption = "Error";
            this.MensajeGuna2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.MensajeGuna2.Parent = this;
            this.MensajeGuna2.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MensajeGuna2.Text = "Ingrese una funcion valida";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 39);
            this.label4.TabIndex = 106;
            this.label4.Text = "\r\nIngrese el error deseado:\r\n";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 39);
            this.label3.TabIndex = 105;
            this.label3.Text = "\r\nIngrese parametro b:\r\n";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 104;
            this.label1.Text = "\r\nIngrese parametro a:\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 39);
            this.label2.TabIndex = 103;
            this.label2.Text = "\r\nIngrese la funcion:\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.txtParametroBReglaFGuna.Location = new System.Drawing.Point(193, 156);
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
            this.txtParametroAReglaFGuna.Location = new System.Drawing.Point(193, 114);
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
            this.txtFuncionReglaFGuna.Name = "txtFuncionReglaFGuna";
            this.txtFuncionReglaFGuna.PlaceholderText = "";
            this.txtFuncionReglaFGuna.SelectedText = "";
            this.txtFuncionReglaFGuna.Size = new System.Drawing.Size(160, 27);
            this.txtFuncionReglaFGuna.TabIndex = 99;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::Metodos_Numeros.Properties.Resources.arrow_return_left_icon_160458;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(724, 409);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton1.TabIndex = 98;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
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
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // Metodo_De_Regla_Falsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtErrorReglaFGuna);
            this.Controls.Add(this.txtParametroBReglaFGuna);
            this.Controls.Add(this.txtParametroAReglaFGuna);
            this.Controls.Add(this.txtFuncionReglaFGuna);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnGraficaReglaFalsa);
            this.Controls.Add(this.btnCorrerReglaFalsa);
            this.Controls.Add(this.DGVReglaFalsa);
            this.Controls.Add(this.lbl12);
            this.Name = "Metodo_De_Regla_Falsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo de Regla Falsa";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReglaFalsa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCorrerReglaFalsa;
        private System.Windows.Forms.DataGridView DGVReglaFalsa;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Button btnGraficaReglaFalsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn fa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fb;
        private System.Windows.Forms.DataGridViewTextBoxColumn fc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzqoDer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorAbsoluto;
        private Guna.UI2.WinForms.Guna2ImageButton btnAyuda;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2MessageDialog MensajeGuna4;
        private Guna.UI2.WinForms.Guna2MessageDialog MensajeGuna3;
        private Guna.UI2.WinForms.Guna2MessageDialog MensajeGuna1;
        private Guna.UI2.WinForms.Guna2MessageDialog MensajeGuna2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtErrorReglaFGuna;
        private Guna.UI2.WinForms.Guna2TextBox txtParametroBReglaFGuna;
        private Guna.UI2.WinForms.Guna2TextBox txtParametroAReglaFGuna;
        private Guna.UI2.WinForms.Guna2TextBox txtFuncionReglaFGuna;
    }
}