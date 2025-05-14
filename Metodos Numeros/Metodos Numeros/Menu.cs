using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Metodos_Numeros
{
    public partial class Menu: Form
    {
        private Dictionary<TabPage, Guna2GradientPanel> tabPagePanelMap;
        bool ratonPulsado = false;
        Point ultimaPosicion;
        public Menu()
        {
            InitializeComponent();
            tabPagePanelMap = new Dictionary<TabPage, Guna2GradientPanel>()
            {
                { tabPageCreditos, PanelCreditos } ,
                { tabPageMetodos, PanelMetodos } 
            };
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
           PreguntarSalir();
        }

        private void tabPageMenu_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Metodo_De_Biseccion nuevaVentana = new Metodo_De_Biseccion();
            nuevaVentana.Show();
            this.Hide();
            
        }

        private void btnReglaFalsa_Click(object sender, EventArgs e)
        {
            Metodo_De_Regla_Falsa nuevaVentana = new Metodo_De_Regla_Falsa();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnDiferenciasDivididas_Click(object sender, EventArgs e)
        {
            DiferenciaDividida diferenciaDividida = new DiferenciaDividida();
            diferenciaDividida.Show();
            this.Hide();
        }

        private void btnIMetodos_Click(object sender, EventArgs e)
        {
            DesplegarTabPage(tabPageMetodos);
        }

        private void btnICreditos_Click(object sender, EventArgs e)
        {
            DesplegarTabPage(tabPageCreditos);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void labelMetodos_Click(object sender, EventArgs e)
        {
            DesplegarTabPage(tabPageMetodos);
        }

        private void labelCreditos_Click(object sender, EventArgs e)
        {
            DesplegarTabPage(tabPageCreditos);
        }

        private void labelSalir_Click(object sender, EventArgs e)
        {
            PreguntarSalir();
        }

        #region metodosAuxiliares
        public void PreguntarSalir()
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       
        public void DesplegarTabPage(TabPage tabPage)
        {
            tabControl1.SelectedTab = tabPage;
            CambiarColorPanelRandom(tabPagePanelMap[tabPage]);

        }
        public void CambiarColorPanelRandom(Guna2GradientPanel panel)
        {

            Random rand = new Random();
            Color color1 = Color.FromArgb(255, rand.Next(150, 256), rand.Next(150, 256), rand.Next(150, 256));
            Color color2 = Color.FromArgb(255, rand.Next(150, 256), rand.Next(150, 256), rand.Next(150, 256));

            panel.FillColor = color1;
            panel.FillColor2 = color2;
            PanelMenu.FillColor = color1;
            PanelMenu.FillColor2 = color2;
        }
        #endregion

        private void panelBorde_MouseDown(object sender, MouseEventArgs e)
        {
            ratonPulsado = true;
            ultimaPosicion = e.Location;
        }

        private void panelBorde_MouseMove(object sender, MouseEventArgs e)
        {
            if(ratonPulsado)
            {
                Location = new Point(Location.X - ultimaPosicion.X + e.X, Location.Y - ultimaPosicion.Y + e.Y);
                Update();
            }
        }

        private void panelBorde_MouseUp(object sender, MouseEventArgs e)
        {
            ratonPulsado = false;
        }
    }
}
