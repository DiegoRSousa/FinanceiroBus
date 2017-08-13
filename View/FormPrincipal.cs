using FinanceiroBus.Controller;
using FinanceiroBus.View.Report;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            new FormLogin().ShowDialog();
            if (new ConfiguracaoController().Configuracao() == null)
            {
                new FormConfiguracaoEmail().ShowDialog();
            }
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAluno().Show();
        }

        private void instituiçõesEnsinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormInstituicaoEnsino().Show();
        }

        private void favorecidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFavorecido().Show();
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormConfiguracaoEmail().Show();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormContrato().Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormContaAReceber().Show();
        }

        private void recebimentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormRecebimento().Show();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormContaAPagar().Show();
        }

        private void pagaemtpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPagamento().Show();
        }

        private void alunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormReportAluno().Show();
        }

        private void contratosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormReportContrato().Show();
        }

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormReportContaAReceber().Show();
        }

        private void recebimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormReportRecebimento().Show();
        }

        private void contasAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormReportContaAPagar().Show();
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormReportPagamento().Show();
        }

        private void transaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormReportTransacao().Show();
        }

        private void calcularMensalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCalculadoraMensalidade().Show();
        }
    }
}
