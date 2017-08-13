using FinanceiroBus.Controller.Report;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View.Report
{
    public partial class FormReportTransacao : Form
    {
        private TransacaoController transacaoController = new TransacaoController();

        public FormReportTransacao()
        {
            InitializeComponent();
        }

        private void FormReportTransacao_Load(object sender, EventArgs e)
        {
            TransacaoBindingSource.DataSource = transacaoController.Listar();
            this.reportViewer1.RefreshReport();
        }
    }
}
