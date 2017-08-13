using FinanceiroBus.Controller.Report;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View.Report
{
    public partial class FormReportContaAReceber : Form
    {
        ContaAReceberController contaAReceberController = new ContaAReceberController();
        public FormReportContaAReceber()
        {
            InitializeComponent();
        }

        private void FormContaAReceber_Load(object sender, EventArgs e)
        {
            ContaAReceberBindingSource.DataSource = contaAReceberController.Listar();
            this.reportViewer1.RefreshReport();
        }
    }
}
