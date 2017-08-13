using FinanceiroBus.Controller;
using FinanceiroBus.Model;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View
{
    public partial class FormContaAReceber : Form
    {
        private ContaAReceberController contaAReceberController = new ContaAReceberController();
        private ContratoController contratoController = new ContratoController();

        public FormContaAReceber()
        {
            InitializeComponent();
        }

        private void FormContaAReceber_Load(object sender, EventArgs e)
        {
            AtualizaDgv();
            InicializaCombobox();
            Limpar();
        }

        private void InicializaCombobox()
        {
            cbxAluno.Items.Clear();
            foreach (var contrato in contratoController.ListarAtivos())
            {
                cbxAluno.Items.Add(contrato.Aluno);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (ValidarContaAReceber())
            {
                var contaAReceber = new ContaAReceber()
                {
                    ContratoId = (this.contratoController.PorIdAluno(((Aluno)cbxAluno.SelectedItem).Id)).Id,
                    Referencia = txtReferencia.Text,
                    Competencia = dtpCompetencia.Value.Date,
                    Vencimento = dtpVencimento.Value.Date,
                    Valor = Convert.ToDouble(txtValor.Text),
                    Status = Model.Status.EM_ABERTO,
                    Cancelada = false
                };

                if (txtId.Text == string.Empty)
                {
                    this.contaAReceberController.Salvar(contaAReceber);

                    if (MessageBox.Show("Conta a receber cadastrada com sucesso! \nDeseja realizar o recebiento agora?"
                    , "Conta a receber", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Close();
                        new FormRecebimento().ShowDialog();
                    }
                }
                else
                {
                    contaAReceber.Id = Convert.ToInt64(txtId.Text);
                    contaAReceberController.Atualizar(contaAReceber);
                }

                AtualizaDgv();
                Limpar();
                InicializaCombobox();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                if (MessageBox.Show("Deseja cancelar a conta a receber do aluno: " + cbxAluno.SelectedItem.ToString(),
                    "Cancelar conta a receber", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (contaAReceberController.Cancelar(Convert.ToInt64(txtId.Text)))
                    {
                        MessageBox.Show("Conta a receber cancelada com sucesso!", "Cancelar conta a receber");
                        AtualizaDgv();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cancelar a conta a receber!\nPara cancelar uma conta a receber seu status deve ser EM_ABERTO");
                    }

                }
            }
            else
            {
                MessageBox.Show("Selecione a conta a receber a ser cancelada!", "Cancelar conta a receber");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            errorProvider.Clear();
            dgvContas.ClearSelection();
            txtId.Text = string.Empty;
            cbxAluno.SelectedIndex = -1;
            txtReferencia.Text = string.Empty;
            dtpCompetencia.Value = DateTime.Now;
            dtpVencimento.Value = DateTime.Now;
            txtValor.Text = string.Empty;
            lblValorStatus.Text = "EM_ABERTO";
            lblCancelada.Text = "";
            cbxAluno.Focus();
            AtivarCampos();
        }

        private void AtualizaDgv()
        {
            dgvContas.Rows.Clear();
            foreach (var contaAReceber in this.contaAReceberController.Listar())
            {
                PreencherDgv(contaAReceber);
            }
        }

        private void dgvContas_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dgvContas.CurrentRow.Cells[0].Value.ToString();
            cbxAluno.Text = dgvContas.CurrentRow.Cells[1].Value.ToString();
            txtReferencia.Text = dgvContas.CurrentRow.Cells[2].Value.ToString();
            dtpCompetencia.Text = dgvContas.CurrentRow.Cells[3].Value.ToString();
            dtpVencimento.Text = dgvContas.CurrentRow.Cells[4].Value.ToString();
            txtValor.Text = dgvContas.CurrentRow.Cells[5].Value.ToString();
            lblValorStatus.Text = dgvContas.CurrentRow.Cells[6].Value.ToString();
            lblCancelada.Text = dgvContas.CurrentRow.Cells[7].Value.ToString() == "True" ? "CANCELADA" : "";

            DesativarCampos();
        }

        private void DesativarCampos()
        {
            cbxAluno.Enabled = false;
            txtValor.Enabled = false;
        }

        private void AtivarCampos()
        {
            cbxAluno.Enabled = true;
            txtValor.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvContas.Rows.Clear();
            var contasAReceber = this.contaAReceberController.PorNomeAluno(txtNomePesquisa.Text);
            foreach (var contaAReceber in contasAReceber)
            {
                PreencherDgv(contaAReceber);
            }

            Limpar();

            if (contasAReceber.Count < 1)
                MessageBox.Show("Não foi possivel localixar nenhhuma do aluno " + txtNomePesquisa.Text,
                    "Pesquisa de Contas a Receber", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarContaAReceber()
        {
            bool valido = true;

            if (cbxAluno.SelectedIndex < 0)
            {
                valido = false;
                errorProvider.SetError(cbxAluno, "O aluno é obrigátório!");
                errorProvider.SetIconPadding(cbxAluno, 2);
            }

            if (txtReferencia.Text == string.Empty)
            {
                valido = false;
                errorProvider.SetError(txtReferencia, "A referência é obrigatória!");
                errorProvider.SetIconPadding(txtReferencia, 2);
            }

            if (txtValor.Text == string.Empty || txtValor.Text == "0")
            {
                valido = false;
                errorProvider.SetError(txtValor, "O valor deve ser maior que 0");
                errorProvider.SetIconPadding(txtValor, 2);
            }

            return valido;
        }

        private void FormContaAReceber_KeyDown(object sender, KeyEventArgs e)
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

        private void PreencherDgv(ContaAReceber contaAReceber)
        {
            try
            {
                dgvContas.Rows.Add(contaAReceber.Id, contaAReceber.Contrato.Aluno, contaAReceber.Referencia,
                    string.Format("{0:dd/MM/yyyy}", contaAReceber.Competencia), string.Format("{0:dd/MM/yyyy}",
                    contaAReceber.Vencimento), contaAReceber.Valor.ToString("N2"), contaAReceber.Status, contaAReceber.Cancelada);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
