using FinanceiroBus.Controller;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View.Report
{
    public partial class FormReportAluno : Form
    {
        private AlunoController alunosController = new AlunoController();
        public FormReportAluno()
        {
            InitializeComponent();
        }

        private void FormReportAluno_Load(object sender, EventArgs e)
        {
            AlunoBindingSource.DataSource = alunosController.Listar();
            this.reportViewer1.RefreshReport();
        }
    }
}
