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
    public partial class FormReporteFcatura : Form
    {
        public FormReporteFcatura()
        {
            InitializeComponent();

            var _facturasBL = new facturasBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _facturasBL.Obtenerfacturas();

            var reporte = new ReporteFactura();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
