using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new formLogin();
             formLogin.ShowDialog();
        }

        private void entradaSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formContainers = new formContainers();
            formContainers.MdiParent = this;
            formContainers.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();

        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void entradaSalidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formEntradas = new formEntradas();
            formEntradas.MdiParent = this;
            formEntradas.Show();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSalidas = new formSalidas();
            formSalidas.MdiParent = this;
            formSalidas.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void reportesDeSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteContainer = new FormReporteContainer();
            formReporteContainer.MdiParent = this;
            formReporteContainer.Show();
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportefacturas = new FormReportefacturas();
            formReportefacturas.MdiParent = this;
            formReportefacturas.Show();

        }

        private void reportesDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
