using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Isaac_Items
{
    public partial class AplicacionObjetos : Form
    {
        private Inicio forminicio;
        public AplicacionObjetos(Inicio inicio)
        {
            InitializeComponent();
            this.forminicio = inicio;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            forminicio.Show();
        }
    }
}
