using FinanceiroBus.Controller.Report;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View.Report
{
    public partial class FormReportContaAPagar : Form
    {
        private ContaAPagarController contaAPagarContoller = new ContaAPagarController();

        public FormReportContaAPagar()
        {
            InitializeComponent();
        }

        private void FormReportContaAPagar_Load(object sender, EventArgs e)
        {
            ContaAPagarBindingSource.DataSource = contaAPagarContoller.Listar();
            this.reportViewer1.RefreshReport();
        }
    }
}
