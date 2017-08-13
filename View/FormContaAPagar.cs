using FinanceiroBus.Controller;
using FinanceiroBus.Model;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View
{
    public partial class FormContaAPagar : Form
    {
        private ContaAPagarController contaAPagarController = new ContaAPagarController();
        private FavorecidoController favorecidoController = new FavorecidoController();

        public FormContaAPagar()
        {
            InitializeComponent();
        }

        private void FormContaAPagar_Load(object sender, EventArgs e)
        {
            AtualizaDgv();
            InicializaCombobox();
            Limpar();
        }

        private void InicializaCombobox()
        {
            cbxFavorecidos.Items.Clear();
            foreach (var favorecido in favorecidoController.Listar())
            {
                cbxFavorecidos.Items.Add(favorecido);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (ValidarContaAPagar())
            {
                var contaAPagar = new ContaAPagar()
                {
                    FavorecidoId = (this.favorecidoController.PorId(((Favorecido)cbxFavorecidos.SelectedItem).Id).Id),
                    Referencia = txtReferencia.Text,
                    Competencia = dtpCompetencia.Value.Date,
                    Vencimento = dtpVencimento.Value.Date,
                    Valor = Convert.ToDouble(txtValor.Text),
                    Status = Model.Status.EM_ABERTO,
                    Cancelada = false
                };

                if (txtId.Text == string.Empty)
                {
                    this.contaAPagarController.Salvar(contaAPagar);

                    if (MessageBox.Show("Conta a pagar cadastrada com sucesso! \nDeseja realizar o pagamento agora?"
                    , "Conta a pagar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Close();
                        new FormPagamento().ShowDialog();
                    }
                }
                else
                {
                    contaAPagar.Id = Convert.ToInt64(txtId.Text);
                    contaAPagarController.Atualizar(contaAPagar);
                }

                AtualizaDgv();
                Limpar();
                InicializaCombobox();
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
            cbxFavorecidos.SelectedIndex = -1;
            txtReferencia.Text = string.Empty;
            dtpCompetencia.Value = DateTime.Now;
            dtpVencimento.Value = DateTime.Now;
            txtValor.Text = string.Empty;
            lblValorStatus.Text = "EM_ABERTO";
            lblCancelada.Text = "";
            cbxFavorecidos.Focus();
            AtivarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                if (MessageBox.Show("Deseja cancelar a conta a pagar do Favorecido: " + cbxFavorecidos.SelectedItem.ToString(),
                    "Cancelar Conta a Pagar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (contaAPagarController.Cancelar(Convert.ToInt64(txtId.Text)))
                    {
                        MessageBox.Show("Conta a Pagar cancelada com sucesso!", "Cancelar Conta a Pagar");
                        AtualizaDgv();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cancelar a Conta a Pagar!" +
                            "\nPara cancelar uma Conta a Pagar seu status deve ser EM_ABERTO");
                    }

                }
            }
            else
            {
                MessageBox.Show("Selecione a Conta a Pagar a ser cancelada!", "Cancelar Conta a Pagar");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvContas.Rows.Clear();
            var contasAPagar = this.contaAPagarController.PorNomeFavorecido(txtNomePesquisa.Text);
            foreach (var contaAPagar in contasAPagar)
            {
                PreencherDgv(contaAPagar);
            }

            Limpar();

            if (contasAPagar.Count < 1)
                MessageBox.Show("Não foi possivel localixar nenhhuma do aluno " + txtNomePesquisa.Text,
                    "Pesquisa de Contas a Receber", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AtualizaDgv()
        {
            dgvContas.Rows.Clear();
            foreach (var contaAPagar in this.contaAPagarController.Listar())
            {
                PreencherDgv(contaAPagar);
            }
        }

        private void dgvContas_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dgvContas.CurrentRow.Cells[0].Value.ToString();
            cbxFavorecidos.Text = dgvContas.CurrentRow.Cells[1].Value.ToString();
            txtReferencia.Text = dgvContas.CurrentRow.Cells[2].Value.ToString();
            dtpCompetencia.Text = dgvContas.CurrentRow.Cells[3].Value.ToString();
            dtpVencimento.Text = dgvContas.CurrentRow.Cells[4].Value.ToString();
            txtValor.Text = dgvContas.CurrentRow.Cells[5].Value.ToString();
            lblValorStatus.Text = dgvContas.CurrentRow.Cells[6].Value.ToString();
            lblCancelada.Text = dgvContas.CurrentRow.Cells[7].Value.ToString() == "True" ? "CANCELADA" : "";

            DesativarCampos();
        }

        private void PreencherDgv(ContaAPagar contaAPagar)
        {
            try
            {
                dgvContas.Rows.Add(contaAPagar.Id, contaAPagar.Favorecido.Nome, contaAPagar.Referencia, string.Format("{0:dd/MM/yyyy}",
                   contaAPagar.Competencia), string.Format("{0:dd/MM/yyyy}", contaAPagar.Vencimento),
                   contaAPagar.Valor.ToString("N2"), contaAPagar.Status, contaAPagar.Cancelada);
            }
            catch (Exception ex)
            {
                
            }   
        }

        private void DesativarCampos()
        {
            cbxFavorecidos.Enabled = false;
            txtValor.Enabled = false;
        }

        private void AtivarCampos()
        {
            cbxFavorecidos.Enabled = true;
            txtValor.Enabled = true;
        }
        private bool ValidarContaAPagar()
        {
            bool valido = true;

            if (cbxFavorecidos.SelectedIndex < 0)
            {
                valido = false;
                errorProvider.SetError(cbxFavorecidos, "O favorecido é obrigátório!");
                errorProvider.SetIconPadding(cbxFavorecidos, 2);
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

        private void FormContaAPagar_KeyDown(object sender, KeyEventArgs e)
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
