namespace Metodos_Numeros
{
    partial class Animacion
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
            this.plotViewAnimacion = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // plotViewAnimacion
            // 
            this.plotViewAnimacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotViewAnimacion.Location = new System.Drawing.Point(0, 0);
            this.plotViewAnimacion.Name = "plotViewAnimacion";
            this.plotViewAnimacion.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewAnimacion.Size = new System.Drawing.Size(762, 449);
            this.plotViewAnimacion.TabIndex = 0;
            this.plotViewAnimacion.Text = "plotView1";
            this.plotViewAnimacion.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewAnimacion.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewAnimacion.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Animacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 449);
            this.Controls.Add(this.plotViewAnimacion);
            this.Name = "Animacion";
            this.Text = "Animacion";
            this.Load += new System.EventHandler(this.Animacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotViewAnimacion;
    }
}