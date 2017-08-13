using FinanceiroBus.Controller;
using FinanceiroBus.Model;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View
{
    public partial class FormPagamento : Form
    {
        private FavorecidoController favorecidoController = new FavorecidoController();
        private ContaAPagarController contaAPagarController = new ContaAPagarController();
        private PagamentoController pagamentoController = new PagamentoController();
        
        public FormPagamento()
        {
            InitializeComponent();
        }

        private void FormPagamento_Load(object sender, System.EventArgs e)
        {
            AtualizaDgvPagamentos();
            InicializaCombobox();
            Limpar();
        }

        private void InicializaCombobox()
        {
            cbxFavorecido.Items.Clear();
            foreach (var favorecido in favorecidoController.Listar()) 
            {
                cbxFavorecido.Items.Add(favorecido);

            }
        }

        private void AtualizaDgvPagamentos()
        {
            dgvPagamentos.Rows.Clear();
            foreach (var pagamento in this.pagamentoController.Listar())
            {
                try
                {
                    dgvPagamentos.Rows.Add(pagamento.Id, pagamento.ContaAPagar.Favorecido, string.Format("{0:dd/MM/yyyy}",
                    pagamento.Data), pagamento.Valor.ToString("N2"), pagamento.Cancelado);
                }
                catch (Exception)
                {

                    
                }
                
            }
        }

        private void PopularDgvContasAPagar()
        {
            dgvContasAPagar.Rows.Clear();
            errorProvider.Clear();
            foreach (var contaAPagar in contaAPagarController.PorNomeFavorecidoNaoLiquidadaNaoCancelada(cbxFavorecido.SelectedItem.ToString()))
            {
                dgvContasAPagar.Rows.Add(contaAPagar.Id, String.Format("{0:dd/MM/yyyy}", contaAPagar.Competencia),
                     String.Format("{0:dd/MM/yyyy}", contaAPagar.Vencimento), contaAPagar.Valor.ToString("N2"));
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if(ValidarPagamento())
            {
                var pagamento = new Pagamento
                {
                    Data = dtpData.Value.Date,
                    Valor = Convert.ToDouble(lblTotal0.Text),
                    ContaAPagarId = Convert.ToInt32(dgvContasAPagar.CurrentRow.Cells[0].Value)
                };

                if (txtId.Text == string.Empty)
                {
                    
                    var contaAPagar = this.contaAPagarController.PorId(Convert.ToInt32(dgvContasAPagar.CurrentRow.Cells[0].Value));
                    this.pagamentoController.Salvar(pagamento);
                    this.contaAPagarController.AtualizarStatus(contaAPagar, Status.LIQUIDADO);
                }

                AtualizaDgvPagamentos();
                InicializaCombobox();
                Limpar();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                var contaAPagar = this.pagamentoController.PorId(Convert.ToInt32(txtId.Text)).ContaAPagar;

                if (MessageBox.Show("Deseja cancelar o Pagamento do Favorecido" + cbxFavorecido.Text + " no valor de "
                    + lblTotal0.Text, "Cancelar Pagamento", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.pagamentoController.Cancelar(Convert.ToInt32(txtId.Text));
                    this.contaAPagarController.AtualizarStatus(contaAPagar, Status.EM_ABERTO);
                    AtualizaDgvPagamentos();
                }
                Limpar();
            }
            else
            {
                MessageBox.Show("Selecione o Pagamento a ser Cancelado!", "Cancelar Pagamento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvPagamentos.Rows.Clear();
            var pagamentos = this.pagamentoController.PorNomeFavorecido(txtNomePesquisa.Text);
            foreach (var pagamento in pagamentos)
            {
                dgvPagamentos.Rows.Add(pagamento.Id, pagamento.ContaAPagar.Favorecido.Nome,
                    string.Format("{0:dd/MM/yyyy}", pagamento.Data), pagamento.Valor.ToString("N2"), 
                    pagamento.Cancelado);
            }

            Limpar();

            if (pagamentos.Count < 1)
                MessageBox.Show("Não foi possivel localixar nenhhum Pagamento de Favorecido com parte do nome " + txtNomePesquisa.Text,
                    "Pesquisa de Pagamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpar()
        {
            errorProvider.Clear();
            dgvPagamentos.ClearSelection();
            txtId.Text = string.Empty;
            cbxFavorecido.SelectedIndex = -1;
            dtpData.Value = DateTime.Now;
            dgvContasAPagar.Rows.Clear();
            lblTotal0.Text = "0";
            cbxFavorecido.Focus();
        }

        private void dgvPagamentos_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dgvPagamentos.CurrentRow.Cells[0].Value.ToString();
            cbxFavorecido.Text = dgvPagamentos.CurrentRow.Cells[1].Value.ToString();
            dtpData.Text = dgvPagamentos.CurrentRow.Cells[2].Value.ToString();
            lblTotal0.Text = dgvPagamentos.CurrentRow.Cells[3].Value.ToString();
        }

        private void cbxFavorecido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFavorecido.SelectedIndex != -1)
                PopularDgvContasAPagar();
        }

        private bool ValidarPagamento()
        {
            bool valido = true;

            if (cbxFavorecido.SelectedIndex == -1)
            {
                valido = false;
                errorProvider.SetError(cbxFavorecido, "O Favorecido é obrigátório!");
                errorProvider.SetIconPadding(cbxFavorecido, 2);
            }

            if (lblTotal0.Text.Equals("0"))
            {
                valido = false;
                errorProvider.SetError(lblTotal0, "O valor do recebimento deve ser maior que zero!");
                errorProvider.SetIconPadding(lblTotal0, 2);
            }

            return valido;
        }

        private void dgvContasAPagar_SelectionChanged(object sender, EventArgs e)
        {
            lblTotal0.Text = dgvContasAPagar.CurrentRow.Cells[3].Value.ToString();
        }

        private void FormPagamento_KeyDown(object sender, KeyEventArgs e)
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
