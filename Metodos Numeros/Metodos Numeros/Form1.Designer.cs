namespace Metodos_Numeros
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalir3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReglaFalsa = new System.Windows.Forms.Button();
            this.lblb = new System.Windows.Forms.Label();
            this.btnBiseccion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir3
            // 
            this.btnSalir3.Location = new System.Drawing.Point(709, 414);
            this.btnSalir3.Name = "btnSalir3";
            this.btnSalir3.Size = new System.Drawing.Size(79, 24);
            this.btnSalir3.TabIndex = 72;
            this.btnSalir3.Text = "Salir";
            this.btnSalir3.UseVisualStyleBackColor = true;
            this.btnSalir3.Click += new System.EventHandler(this.btnSalir3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "Metodo de Regla Falsa";
            // 
            // btnReglaFalsa
            // 
            this.btnReglaFalsa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReglaFalsa.BackgroundImage")));
            this.btnReglaFalsa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReglaFalsa.Location = new System.Drawing.Point(481, 180);
            this.btnReglaFalsa.Name = "btnReglaFalsa";
            this.btnReglaFalsa.Size = new System.Drawing.Size(266, 218);
            this.btnReglaFalsa.TabIndex = 70;
            this.btnReglaFalsa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReglaFalsa.UseVisualStyleBackColor = true;
            this.btnReglaFalsa.Click += new System.EventHandler(this.btnReglaFalsa_Click_1);
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(134, 153);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(187, 24);
            this.lblb.TabIndex = 69;
            this.lblb.Text = "Metodo de biseccion";
            // 
            // btnBiseccion
            // 
            this.btnBiseccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBiseccion.BackgroundImage")));
            this.btnBiseccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBiseccion.Location = new System.Drawing.Point(99, 180);
            this.btnBiseccion.Name = "btnBiseccion";
            this.btnBiseccion.Size = new System.Drawing.Size(266, 218);
            this.btnBiseccion.TabIndex = 68;
            this.btnBiseccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBiseccion.UseVisualStyleBackColor = true;
            this.btnBiseccion.Click += new System.EventHandler(this.btnBiseccion_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 25);
            this.label4.TabIndex = 67;
            this.label4.Text = "Seleccione que metodo desea utilizar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(203, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(400, 50);
            this.label10.TabIndex = 66;
            this.label10.Text = "Bienvenido al programa para aplicar \r\nel metodo de biseccion y regla falsa";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReglaFalsa);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.btnBiseccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodo de Biseccion y Regla Falsa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReglaFalsa;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Button btnBiseccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
    }
}

