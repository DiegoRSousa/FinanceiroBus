using FinanceiroBus.Controller.Report;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View.Report
{
    public partial class FormReportPagamento : Form
    {
        private PagamentoController pagamentoController = new PagamentoController();

        public FormReportPagamento()
        {
            InitializeComponent();
        }

        private void FormReportPagamento_Load(object sender, EventArgs e)
        {
            PagamentoBindingSource.DataSource = pagamentoController.Listar();
            this.reportViewer1.RefreshReport();
        }
    }
}
