using FinanceiroBus.Controller.Report;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View.Report
{
    public partial class FormReportRecebimento : Form
    {
        private RecebimentoController recebimentoController = new RecebimentoController();

        public FormReportRecebimento()
        {
            InitializeComponent();
        }

        private void FormReportRecebimento_Load(object sender, EventArgs e)
        {
            RecebimentoBindingSource.DataSource = recebimentoController.Listar();
            this.reportViewer1.RefreshReport();
        }
    }
}
