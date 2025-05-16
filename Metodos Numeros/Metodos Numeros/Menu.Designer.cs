namespace Metodos_Numeros
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.GunaBorderless = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMenu = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageCreditos = new System.Windows.Forms.TabPage();
            this.PanelCreditos = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageMetodos = new System.Windows.Forms.TabPage();
            this.PanelMetodos = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInterpolacion = new System.Windows.Forms.Button();
            this.bntBiseccion = new System.Windows.Forms.Button();
            this.btnDiferenciasDivididas = new System.Windows.Forms.Button();
            this.btnReglaFalsa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSalir = new System.Windows.Forms.Label();
            this.labelCreditos = new System.Windows.Forms.Label();
            this.labelMetodos = new System.Windows.Forms.Label();
            this.PanelMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnICreditos = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnIMetodos = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ArrastrarMenu = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ArrastraMetodos = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ArrastraCreditos = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ArrastraLateral = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ArrastraBoton = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageMenu.SuspendLayout();
            this.tabPageCreditos.SuspendLayout();
            this.PanelCreditos.SuspendLayout();
            this.tabPageMetodos.SuspendLayout();
            this.PanelMetodos.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GunaBorderless
            // 
            this.GunaBorderless.ContainerControl = this;
            this.GunaBorderless.DockIndicatorTransparencyValue = 0.6D;
            this.GunaBorderless.TransparentWhileDrag = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMenu);
            this.tabControl1.Controls.Add(this.tabPageCreditos);
            this.tabControl1.Controls.Add(this.tabPageMetodos);
            this.tabControl1.Location = new System.Drawing.Point(185, -24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 591);
            this.tabControl1.TabIndex = 88;
            // 
            // tabPageMenu
            // 
            this.tabPageMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageMenu.Controls.Add(this.label9);
            this.tabPageMenu.Controls.Add(this.label4);
            this.tabPageMenu.Location = new System.Drawing.Point(4, 25);
            this.tabPageMenu.Name = "tabPageMenu";
            this.tabPageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenu.Size = new System.Drawing.Size(768, 562);
            this.tabPageMenu.TabIndex = 1;
            this.tabPageMenu.Text = "Menu Principal";
            this.tabPageMenu.Click += new System.EventHandler(this.tabPageMenu_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(16, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(714, 81);
            this.label9.TabIndex = 1;
            this.label9.Text = "PROYECTO METODOS NUMERICOS";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(-27, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(801, 81);
            this.label4.TabIndex = 2;
            this.label4.Text = "Presione algun boton para acceder a las opciones ;3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageCreditos
            // 
            this.tabPageCreditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPageCreditos.Controls.Add(this.PanelCreditos);
            this.tabPageCreditos.Location = new System.Drawing.Point(4, 25);
            this.tabPageCreditos.Name = "tabPageCreditos";
            this.tabPageCreditos.Size = new System.Drawing.Size(768, 562);
            this.tabPageCreditos.TabIndex = 3;
            this.tabPageCreditos.Text = "Creditos";
            // 
            // PanelCreditos
            // 
            this.PanelCreditos.Controls.Add(this.label14);
            this.PanelCreditos.Controls.Add(this.label13);
            this.PanelCreditos.Controls.Add(this.label2);
            this.PanelCreditos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelCreditos.FillColor2 = System.Drawing.Color.Cyan;
            this.PanelCreditos.Location = new System.Drawing.Point(0, -7);
            this.PanelCreditos.Name = "PanelCreditos";
            this.PanelCreditos.Size = new System.Drawing.Size(772, 578);
            this.PanelCreditos.TabIndex = 87;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(147, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(463, 132);
            this.label14.TabIndex = 84;
            this.label14.Text = "Alberto Rodriguez Rios\r\nNo. Control: 22310532";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(147, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(463, 132);
            this.label13.TabIndex = 83;
            this.label13.Text = "Ignacio Eduardo Casillas Ramirez\r\nNo. Control: 22310564";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(279, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 53);
            this.label2.TabIndex = 82;
            this.label2.Text = "Hecho por:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageMetodos
            // 
            this.tabPageMetodos.Controls.Add(this.PanelMetodos);
            this.tabPageMetodos.Location = new System.Drawing.Point(4, 25);
            this.tabPageMetodos.Name = "tabPageMetodos";
            this.tabPageMetodos.Size = new System.Drawing.Size(768, 562);
            this.tabPageMetodos.TabIndex = 2;
            this.tabPageMetodos.Text = "Metodos";
            this.tabPageMetodos.UseVisualStyleBackColor = true;
            // 
            // PanelMetodos
            // 
            this.PanelMetodos.Controls.Add(this.label5);
            this.PanelMetodos.Controls.Add(this.label11);
            this.PanelMetodos.Controls.Add(this.label10);
            this.PanelMetodos.Controls.Add(this.btnInterpolacion);
            this.PanelMetodos.Controls.Add(this.bntBiseccion);
            this.PanelMetodos.Controls.Add(this.btnDiferenciasDivididas);
            this.PanelMetodos.Controls.Add(this.btnReglaFalsa);
            this.PanelMetodos.Controls.Add(this.label8);
            this.PanelMetodos.Controls.Add(this.label6);
            this.PanelMetodos.Controls.Add(this.label7);
            this.PanelMetodos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelMetodos.FillColor2 = System.Drawing.Color.Cyan;
            this.PanelMetodos.Location = new System.Drawing.Point(3, 3);
            this.PanelMetodos.Name = "PanelMetodos";
            this.PanelMetodos.Size = new System.Drawing.Size(841, 578);
            this.PanelMetodos.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(254, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 46);
            this.label5.TabIndex = 82;
            this.label5.Text = "Metodos disponibles ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(496, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(274, 29);
            this.label11.TabIndex = 85;
            this.label11.Text = "Metodo de Interpolacion";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(478, 23);
            this.label10.TabIndex = 83;
            this.label10.Text = "Seleccione un boton para acceder al metodo deseado";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInterpolacion
            // 
            this.btnInterpolacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInterpolacion.BackgroundImage")));
            this.btnInterpolacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInterpolacion.Location = new System.Drawing.Point(519, 384);
            this.btnInterpolacion.Name = "btnInterpolacion";
            this.btnInterpolacion.Size = new System.Drawing.Size(191, 168);
            this.btnInterpolacion.TabIndex = 84;
            this.btnInterpolacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInterpolacion.UseVisualStyleBackColor = true;
            this.btnInterpolacion.Click += new System.EventHandler(this.btnInterpolacion_Click);
            // 
            // bntBiseccion
            // 
            this.bntBiseccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntBiseccion.BackgroundImage")));
            this.bntBiseccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntBiseccion.Location = new System.Drawing.Point(83, 127);
            this.bntBiseccion.Name = "bntBiseccion";
            this.bntBiseccion.Size = new System.Drawing.Size(191, 168);
            this.bntBiseccion.TabIndex = 77;
            this.bntBiseccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntBiseccion.UseVisualStyleBackColor = true;
            this.bntBiseccion.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDiferenciasDivididas
            // 
            this.btnDiferenciasDivididas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiferenciasDivididas.BackgroundImage")));
            this.btnDiferenciasDivididas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiferenciasDivididas.Location = new System.Drawing.Point(91, 384);
            this.btnDiferenciasDivididas.Name = "btnDiferenciasDivididas";
            this.btnDiferenciasDivididas.Size = new System.Drawing.Size(191, 168);
            this.btnDiferenciasDivididas.TabIndex = 81;
            this.btnDiferenciasDivididas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDiferenciasDivididas.UseVisualStyleBackColor = true;
            this.btnDiferenciasDivididas.Click += new System.EventHandler(this.btnDiferenciasDivididas_Click);
            // 
            // btnReglaFalsa
            // 
            this.btnReglaFalsa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReglaFalsa.BackgroundImage")));
            this.btnReglaFalsa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReglaFalsa.Location = new System.Drawing.Point(519, 127);
            this.btnReglaFalsa.Name = "btnReglaFalsa";
            this.btnReglaFalsa.Size = new System.Drawing.Size(191, 168);
            this.btnReglaFalsa.TabIndex = 79;
            this.btnReglaFalsa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReglaFalsa.UseVisualStyleBackColor = true;
            this.btnReglaFalsa.Click += new System.EventHandler(this.btnReglaFalsa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 29);
            this.label8.TabIndex = 80;
            this.label8.Text = "Diferencias divididas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 29);
            this.label6.TabIndex = 76;
            this.label6.Text = "Metodo de biseccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(515, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 29);
            this.label7.TabIndex = 78;
            this.label7.Text = "Metodo de Regla Falsa";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelSalir
            // 
            this.labelSalir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSalir.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalir.Location = new System.Drawing.Point(46, 518);
            this.labelSalir.Name = "labelSalir";
            this.labelSalir.Size = new System.Drawing.Size(112, 29);
            this.labelSalir.TabIndex = 90;
            this.labelSalir.Text = "Salir";
            this.labelSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSalir.Click += new System.EventHandler(this.labelSalir_Click);
            // 
            // labelCreditos
            // 
            this.labelCreditos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCreditos.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreditos.Location = new System.Drawing.Point(41, 329);
            this.labelCreditos.Name = "labelCreditos";
            this.labelCreditos.Size = new System.Drawing.Size(112, 29);
            this.labelCreditos.TabIndex = 3;
            this.labelCreditos.Text = "Creditos";
            this.labelCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCreditos.Click += new System.EventHandler(this.labelCreditos_Click);
            // 
            // labelMetodos
            // 
            this.labelMetodos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMetodos.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetodos.Location = new System.Drawing.Point(36, 138);
            this.labelMetodos.Name = "labelMetodos";
            this.labelMetodos.Size = new System.Drawing.Size(112, 29);
            this.labelMetodos.TabIndex = 2;
            this.labelMetodos.Text = "Metodos";
            this.labelMetodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMetodos.Click += new System.EventHandler(this.labelMetodos_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.labelSalir);
            this.PanelMenu.Controls.Add(this.btnICreditos);
            this.PanelMenu.Controls.Add(this.labelCreditos);
            this.PanelMenu.Controls.Add(this.guna2ImageButton1);
            this.PanelMenu.Controls.Add(this.labelMetodos);
            this.PanelMenu.Controls.Add(this.btnIMetodos);
            this.PanelMenu.Location = new System.Drawing.Point(-2, 1);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(195, 566);
            this.PanelMenu.TabIndex = 89;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // btnICreditos
            // 
            this.btnICreditos.BackColor = System.Drawing.Color.Transparent;
            this.btnICreditos.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnICreditos.HoverState.ImageSize = new System.Drawing.Size(125, 125);
            this.btnICreditos.Image = global::Metodos_Numeros.Properties.Resources.persona1;
            this.btnICreditos.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnICreditos.ImageRotate = 0F;
            this.btnICreditos.ImageSize = new System.Drawing.Size(125, 125);
            this.btnICreditos.Location = new System.Drawing.Point(36, 229);
            this.btnICreditos.Name = "btnICreditos";
            this.btnICreditos.PressedState.ImageSize = new System.Drawing.Size(125, 125);
            this.btnICreditos.Size = new System.Drawing.Size(122, 97);
            this.btnICreditos.TabIndex = 89;
            this.btnICreditos.Click += new System.EventHandler(this.btnICreditos_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(125, 125);
            this.guna2ImageButton1.Image = global::Metodos_Numeros.Properties.Resources.power_off_icon_f;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(125, 125);
            this.guna2ImageButton1.Location = new System.Drawing.Point(36, 387);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(125, 125);
            this.guna2ImageButton1.Size = new System.Drawing.Size(127, 128);
            this.guna2ImageButton1.TabIndex = 86;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // btnIMetodos
            // 
            this.btnIMetodos.BackColor = System.Drawing.Color.Transparent;
            this.btnIMetodos.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnIMetodos.HoverState.ImageSize = new System.Drawing.Size(125, 125);
            this.btnIMetodos.Image = global::Metodos_Numeros.Properties.Resources.metodos;
            this.btnIMetodos.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnIMetodos.ImageRotate = 0F;
            this.btnIMetodos.ImageSize = new System.Drawing.Size(125, 125);
            this.btnIMetodos.Location = new System.Drawing.Point(14, 12);
            this.btnIMetodos.Name = "btnIMetodos";
            this.btnIMetodos.PressedState.ImageSize = new System.Drawing.Size(125, 125);
            this.btnIMetodos.Size = new System.Drawing.Size(149, 123);
            this.btnIMetodos.TabIndex = 88;
            this.btnIMetodos.Click += new System.EventHandler(this.btnIMetodos_Click);
            // 
            // ArrastrarMenu
            // 
            this.ArrastrarMenu.DockIndicatorTransparencyValue = 0.6D;
            this.ArrastrarMenu.TargetControl = this.tabPageMenu;
            this.ArrastrarMenu.TransparentWhileDrag = false;
            // 
            // ArrastraMetodos
            // 
            this.ArrastraMetodos.DockIndicatorTransparencyValue = 0.6D;
            this.ArrastraMetodos.TargetControl = this.PanelMetodos;
            this.ArrastraMetodos.TransparentWhileDrag = false;
            // 
            // ArrastraCreditos
            // 
            this.ArrastraCreditos.DockIndicatorTransparencyValue = 0.6D;
            this.ArrastraCreditos.TargetControl = this.PanelCreditos;
            this.ArrastraCreditos.TransparentWhileDrag = false;
            // 
            // ArrastraLateral
            // 
            this.ArrastraLateral.DockIndicatorTransparencyValue = 0.6D;
            this.ArrastraLateral.TargetControl = this.PanelMenu;
            this.ArrastraLateral.TransparentWhileDrag = false;
            // 
            // ArrastraBoton
            // 
            this.ArrastraBoton.DockIndicatorTransparencyValue = 1D;
            this.ArrastraBoton.DragStartTransparencyValue = 1D;
            this.ArrastraBoton.TargetControl = this.btnIMetodos;
            this.ArrastraBoton.TransparentWhileDrag = false;
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(947, 560);
            this.ControlBox = false;
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodos Numericos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMenu.ResumeLayout(false);
            this.tabPageCreditos.ResumeLayout(false);
            this.PanelCreditos.ResumeLayout(false);
            this.tabPageMetodos.ResumeLayout(false);
            this.PanelMetodos.ResumeLayout(false);
            this.PanelMetodos.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm GunaBorderless;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMetodos;
        private System.Windows.Forms.TabPage tabPageCreditos;
        private System.Windows.Forms.Button bntBiseccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReglaFalsa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDiferenciasDivididas;
        private Guna.UI2.WinForms.Guna2ImageButton btnIMetodos;
        private Guna.UI2.WinForms.Guna2ImageButton btnICreditos;
        private System.Windows.Forms.Label labelCreditos;
        private System.Windows.Forms.Label labelMetodos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInterpolacion;
        private System.Windows.Forms.Label labelSalir;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelMetodos;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelCreditos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelMenu;
        private Guna.UI2.WinForms.Guna2DragControl ArrastrarMenu;
        private Guna.UI2.WinForms.Guna2DragControl ArrastraMetodos;
        private Guna.UI2.WinForms.Guna2DragControl ArrastraCreditos;
        private Guna.UI2.WinForms.Guna2DragControl ArrastraLateral;
        private Guna.UI2.WinForms.Guna2DragControl ArrastraBoton;
        private System.Windows.Forms.TabPage tabPageMenu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
    }
}

