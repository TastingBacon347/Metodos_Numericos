﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc.Domain;
using System.Windows.Forms.Integration;
using OxyPlot.WindowsForms;

namespace Metodos_Numeros
{
    public partial class Form5 : Form
    {

        public Form5(PlotView plotView)
        {
            InitializeComponent();
            this.Controls.Add(plotView);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
