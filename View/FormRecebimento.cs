using FinanceiroBus.Controller;
using FinanceiroBus.Model;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View
{
    public partial class FormRecebimento : Form
    {
        private RecebimentoController recebimentoController = new RecebimentoController();
        private ContratoController contratoController = new ContratoController();
        private ContaAReceberController contaAReceberController = new ContaAReceberController();

        public FormRecebimento()
        {
            InitializeComponent();
        }

        private void FormRecebimento_Load(object sender, EventArgs e)
        {
            AtualizaDgvRecebimentos();
            InicializaCombobox();
            Limpar();
        }

        private void InicializaCombobox()
        {
            cbxAluno.Items.Clear();
            foreach (var contrato in this.contratoController.ListarAtivos())
            {
                cbxAluno.Items.Add(contrato.Aluno);
            }
        }

        private void PopularDgvContasAReceber()
        {
            dgvContasAReceber.Rows.Clear();
            errorProvider.Clear();
            foreach (var contaAReceber in contaAReceberController.PorNomeAlunoNaoLiquidadaNaoCancelada(cbxAluno.SelectedItem.ToString()))
            {
                dgvContasAReceber.Rows.Add(contaAReceber.Id, String.Format("{0:dd/MM/yyyy}", contaAReceber.Competencia),
                    String.Format("{0:dd/MM/yyyy}", contaAReceber.Vencimento), contaAReceber.Valor.ToString("N2"));
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (ValidarRecebimento())
            {
                var recebimento = new Recebimento
                {
                    Data = dtpData.Value.Date,
                    Valor = Convert.ToDouble(lblTotal0.Text),
                    ContaAReceberId = Convert.ToInt32(dgvContasAReceber.CurrentRow.Cells[0].Value)
                };

                if (txtId.Text == string.Empty)
                {
                    var contaAReceber = this.contaAReceberController.PorId(Convert.ToInt32(dgvContasAReceber.CurrentRow.Cells[0].Value));
                    var aluno = contaAReceber.Contrato.Aluno;

                    this.recebimentoController.Salvar(recebimento);
                    this.contaAReceberController.AtualizarStatus(contaAReceber, Status.LIQUIDADO);

                    string mensagem = "Olá " + cbxAluno.Text + " o recebimento da sua parcela foi realizado com sucesso! \n" +
                        "Vencimento: " + dgvContasAReceber.CurrentRow.Cells[2].Value.ToString() + "\n" +
                        " Valor: " + dgvContasAReceber.CurrentRow.Cells[3].Value.ToString();

                    if (EmailController.EnviarEmail(aluno.Email, "Comprovante de recebimento", mensagem, new ConfiguracaoController().Configuracao()))
                    {
                        MessageBox.Show("Recebimento realizado com sucesso!\n" +
                            "Enviado para o aluno: " + aluno.Nome +
                            "\nEmail: " + aluno.Email);
                    }
                    else
                    {
                        MessageBox.Show("Recebimento realizado com sucesso!\n" +
                            "Mas não foi possível enviar o email, verifique se os dados estão corretos e sua conexão con a internet!");
                    }
                }
                AtualizaDgvRecebimentos();
                InicializaCombobox();
                Limpar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (txtId.Text != string.Empty)
            {
                var contaAReceber = this.recebimentoController.PorId(Convert.ToInt32(txtId.Text)).ContaAReceber;

                if (MessageBox.Show("Deseja cancelar o recebimento do aluno " + cbxAluno.Text + " no valor de "
                    + lblTotal0.Text, "Cancelar recebimento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.recebimentoController.Cancelar(Convert.ToInt32(txtId.Text));
                    this.contaAReceberController.AtualizarStatus(contaAReceber, Status.EM_ABERTO);
                    AtualizaDgvRecebimentos();
                }
                Limpar();
            }
            else
            {
                MessageBox.Show("Selecione o recebimento a ser cancelado!", "Cancelar recebimento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvRecebimentos.Rows.Clear();
            foreach (var recebimento in this.recebimentoController.PorNomeAluno(txtNomePesquisa.Text))
            {
                var linhaTabela = new DataGridViewRow();
                linhaTabela.Cells.Add(new DataGridViewTextBoxCell { Value = recebimento.Id });
                linhaTabela.Cells.Add(new DataGridViewTextBoxCell { Value = recebimento.ContaAReceber.Contrato.Aluno });
                linhaTabela.Cells.Add(new DataGridViewTextBoxCell { Value = string.Format("{0:dd/MM/yyyy}", recebimento.Data) });
                linhaTabela.Cells.Add(new DataGridViewTextBoxCell { Value = recebimento.Valor.ToString("N2") });
                linhaTabela.Cells.Add(new DataGridViewCheckBoxCell { Value = recebimento.Cancelado });
                dgvRecebimentos.Rows.Add(linhaTabela);
            }

            Limpar();

            if (this.recebimentoController.PorNomeAluno(txtNomePesquisa.Text).Count < 1)
                MessageBox.Show("Não foi possivel localixar nenhhum recebimento de aluno com parte do nome " + txtNomePesquisa.Text,
                    "Pesquisa de recebimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpar()
        {
            errorProvider.Clear();
            dgvRecebimentos.ClearSelection();
            txtId.Text = string.Empty;
            cbxAluno.SelectedIndex = -1;
            dtpData.Value = DateTime.Now;
            dgvContasAReceber.Rows.Clear();
            lblTotal0.Text = "0";
            cbxAluno.Focus();
        }

        private void AtualizaDgvRecebimentos()
        {
            dgvRecebimentos.Rows.Clear();
            foreach (var recebimento in this.recebimentoController.Listar())
            {
                try
                {
                    dgvRecebimentos.Rows.Add(recebimento.Id, recebimento.ContaAReceber.Contrato.Aluno,
                        string.Format("{0:dd/MM/yyyy}", recebimento.Data), recebimento.Valor.ToString("N2"), recebimento.Cancelado);
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void dgvRecebimentos_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dgvRecebimentos.CurrentRow.Cells[0].Value.ToString();
            cbxAluno.Text = dgvRecebimentos.CurrentRow.Cells[1].Value.ToString();
            dtpData.Text = dgvRecebimentos.CurrentRow.Cells[2].Value.ToString();
            lblTotal0.Text = dgvRecebimentos.CurrentRow.Cells[3].Value.ToString();
        }

        private void cbxAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAluno.SelectedIndex != -1)
                PopularDgvContasAReceber();
        }

        private bool ValidarRecebimento()
        {
            bool valido = true;

            if (cbxAluno.SelectedIndex == -1)
            {
                valido = false;
                errorProvider.SetError(cbxAluno, "O aluno é obrigátório!");
                errorProvider.SetIconPadding(cbxAluno, 2);
            }

            if (lblTotal0.Text.Equals("0"))
            {
                valido = false;
                errorProvider.SetError(lblTotal0, "O valor do recebimento deve ser maior que zero!");
                errorProvider.SetIconPadding(lblTotal0, 2);
            }

            return valido;
        }

        private void dgvContasAReceber_SelectionChanged(object sender, EventArgs e)
        {
            lblTotal0.Text = dgvContasAReceber.CurrentRow.Cells[3].Value.ToString();
        }

        private void FormRecebimento_KeyDown(object sender, KeyEventArgs e)
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
