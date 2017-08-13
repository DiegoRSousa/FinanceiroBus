using FinanceiroBus.Controller;
using FinanceiroBus.Model;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View
{
    public partial class FormContrato : Form
    {
        private ContratoController contratoController = new ContratoController();
        private AlunoController alunoController = new AlunoController();
        private InstituicaoEnsinoController instituicaoEnsinoController = new InstituicaoEnsinoController();

        public FormContrato()
        {
            InitializeComponent();
        }

        private void FormContrato_Load(object sender, EventArgs e)
        {
            AtualizaDgv();
            InicializaCombobox();
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (ValidarContrato())
            {
                var contrato = new Contrato
                {
                    DataInicial = dtpDataInicial.Value.Date,
                    DataFinal = dtpDataFinal.Value.Date,
                    PlanoPagamento = (PlanoPagamento)cbxPlanoPagamento.SelectedItem,
                    AlunoId = ((Aluno)cbxAluno.SelectedItem).Id,
                    InstituicaoEnsinoId = ((InstituicaoEnsino)cbxInstituicaoEnsino.SelectedItem).Id,
                    Ativado = true
                };

                if (txtId.Text == string.Empty)
                {
                    if (this.contratoController.Salvar(contrato))
                    {
                        var aluno = alunoController.PorId(contrato.AlunoId);

                        string mensagem = "Olá " + cbxAluno.Text + " seja bem vindo a comunidade do ônibus! \n" +
                            "Seu contrato inicia em: " + dtpDataInicial.Text + " e finaliza em: " + dtpDataFinal.Text + "\n" +
                            "Você está no plano de pagamento: " + cbxPlanoPagamento.Text + "\n" +
                            "Você está matriculado na instituição de ensino: " + cbxInstituicaoEnsino.Text;

                        if (EmailController.EnviarEmail(aluno.Email, "Comprovante de contrato", mensagem, new ConfiguracaoController().Configuracao()))
                        {
                            MessageBox.Show("Contrato cadastrado com sucesso!\n" +
                                "Enviado para o aluno: " + aluno.Nome +
                                "\nEmail: " + aluno.Email);
                        }
                        else
                        {
                            MessageBox.Show("Contrato cadastrado com sucesso!\n" +
                                "Mas não foi possível enviar o email, verifique se os dados estão corretos e sua conexão con a internet!");
                        }
                    }

                    else
                        MessageBox.Show("Já existe contrato ativo para este aluno!", "Salvar contrato");
                }
                else
                {
                    contrato.Id = Convert.ToInt64(txtId.Text);
                    contratoController.Atualizar(contrato);
                }

                AtualizaDgv();
                Limpar();
                InicializaCombobox();
            }
        }

        private void Limpar()
        {
            errorProvider.Clear();
            dgvContratos.ClearSelection();
            txtId.Text = string.Empty;
            dtpDataInicial.Value = DateTime.Now;
            dtpDataFinal.Value = DateTime.Now.AddYears(1);
            cbxAluno.SelectedIndex = -1;
            cbxInstituicaoEnsino.SelectedIndex = -1;
            cbxPlanoPagamento.SelectedIndex = -1;
            lblSituacao.Text = "EM_DIA";
            dtpDataInicial.Focus();
            AtivarCampos();

        }

        public void InicializaCombobox()
        {
            cbxAluno.Items.Clear();
            foreach (Aluno aluno in this.alunoController.Listar())
            {
                cbxAluno.Items.Add(aluno);
            }

            cbxInstituicaoEnsino.Items.Clear();
            foreach (InstituicaoEnsino instituicaoEnsino in this.instituicaoEnsinoController.Listar())
            {
                cbxInstituicaoEnsino.Items.Add(instituicaoEnsino);
            }

            cbxPlanoPagamento.Items.Clear();
            cbxPlanoPagamento.Items.Add(Model.PlanoPagamento.INTEGRAL);
            cbxPlanoPagamento.Items.Add(Model.PlanoPagamento.PARCIAL);
        }

        private void AtualizaDgv()
        {
            dgvContratos.Rows.Clear();
            foreach (var contrato in this.contratoController.Listar())
            {
                dgvContratos.Rows.Add(contrato.Id, String.Format("{0:dd/MM/yyyy}", contrato.DataInicial),
                    String.Format("{0:dd/MM/yyyy}", contrato.DataFinal), contrato.PlanoPagamento,
                    contrato.SituacaoFinanceira, contrato.Aluno.ToString(), contrato.InstituicaoEnsino.ToString(),
                    contrato.Ativado);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                if (MessageBox.Show("Deseja desativar o contrato n°: " + txtId.Text + " do aluno(a): " + cbxAluno.SelectedItem.ToString()
                , "Desativar contrato", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    contratoController.Desativar(Convert.ToInt64(txtId.Text));
                    AtualizaDgv();
                }
                Limpar();
            }

            else
            {
                MessageBox.Show("Selecione o contrato a ser desativado!", "Desativar contrato");

            }
        }

        private void dgvContratos_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dgvContratos.CurrentRow.Cells[0].Value.ToString();
            dtpDataInicial.Text = dgvContratos.CurrentRow.Cells[1].Value.ToString();
            dtpDataFinal.Text = dgvContratos.CurrentRow.Cells[2].Value.ToString();
            cbxAluno.Text = dgvContratos.CurrentRow.Cells[5].Value.ToString();
            cbxInstituicaoEnsino.Text = dgvContratos.CurrentRow.Cells[6].Value.ToString();
            cbxPlanoPagamento.Text = dgvContratos.CurrentRow.Cells[3].Value.ToString();
            lblSituacao.Text = dgvContratos.CurrentRow.Cells[4].Value.ToString();
            lblAtivado.Text = dgvContratos.CurrentRow.Cells[7].Value.ToString() == "True" ? "ATIVADO" : "DESATIVADO";
            DesativarCampos();
        }

        private void DesativarCampos()
        {
            cbxAluno.Enabled = false;
            cbxInstituicaoEnsino.Enabled = false;
            cbxPlanoPagamento.Enabled = false;
        }

        private void AtivarCampos()
        {
            cbxAluno.Enabled = true;
            cbxInstituicaoEnsino.Enabled = true;
            cbxPlanoPagamento.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvContratos.Rows.Clear();

            foreach (var contrato in this.contratoController.PorNomeAluno(txtNomePesquisa.Text))
            {
                dgvContratos.Rows.Add(contrato.Id, String.Format("{0:dd/MM/yyyy}", contrato.DataInicial),
                    String.Format("{0:dd/MM/yyyy}", contrato.DataFinal), contrato.PlanoPagamento,
                    contrato.SituacaoFinanceira, contrato.Aluno.ToString(), contrato.InstituicaoEnsino.ToString(),
                    contrato.Ativado);
            }
            Limpar();

            if (this.contratoController.PorNomeAluno(txtNomePesquisa.Text).Count < 1)
                MessageBox.Show("Não foi possivel localixar nenhhum contrato de aluno com parte do nome " + txtNomePesquisa.Text,
                    "Pesquisa de contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarContrato()
        {
            bool valido = true;

            if (cbxAluno.SelectedIndex < 0)
            {
                valido = false;
                errorProvider.SetError(cbxAluno, "O aluno é obrigátório!");
                errorProvider.SetIconPadding(cbxAluno, 2);
            }

            if (cbxInstituicaoEnsino.SelectedIndex < 0)
            {
                valido = false;
                errorProvider.SetError(cbxInstituicaoEnsino, "A Instituição de Ensino é obrigátório!");
                errorProvider.SetIconPadding(cbxInstituicaoEnsino, 2);
            }

            if (cbxPlanoPagamento.SelectedIndex < 0)
            {
                valido = false;
                errorProvider.SetError(cbxPlanoPagamento, "O plano de pagamento é obrigátório!");
                errorProvider.SetIconPadding(cbxPlanoPagamento, 2);
            }

            return valido;
        }

        private void FormContrato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                btnSalvar.PerformClick();
            if (e.KeyCode == Keys.F8)
                btnLimpar.PerformClick();
            if (e.KeyCode == Keys.F12)
                btnPesquisar.PerformClick();
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
