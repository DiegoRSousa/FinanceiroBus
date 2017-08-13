using FinanceiroBus.Controller.Report;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View.Report
{
    public partial class FormReportContrato : Form
    {
        private ContratoController contratoController = new ContratoController();
        public FormReportContrato()
        {
            InitializeComponent();
        }

        private void FormReportContrato_Load(object sender, EventArgs e)
        {
            ContratoBindingSource.DataSource = contratoController.Listar();
            this.reportViewer1.RefreshReport();
        }
    }
}
