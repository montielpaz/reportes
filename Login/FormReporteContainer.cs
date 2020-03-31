using BL.Containers;
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
    public partial class FormReporteContainer : Form
    {
        public FormReporteContainer()
        {
            InitializeComponent();


            var _containerBL = new ContainersBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _containerBL.ObtenerContainers();

            var reporte = new ReporteContainer();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
