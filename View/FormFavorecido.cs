using FinanceiroBus.Controller;
using FinanceiroBus.Model;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View
{
    public partial class FormFavorecido : Form
    {
        private FavorecidoController favorecidoController = new FavorecidoController();

        public FormFavorecido()
        {
            InitializeComponent();
        }

        private void FormFavorecido_Load(object sender, EventArgs e)
        {
            AtualizaDgv();
            InicializaCombobox();
            Limpar();
        }

        private void InicializaCombobox()
        {
            cbxTipoFavorecido.Items.Clear();
            cbxTipoFavorecido.Items.Add(Model.TipoFavorecido.MOTORISTA);
            cbxTipoFavorecido.Items.Add(Model.TipoFavorecido.POSTO);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (ValidarFavorecido())
            {
                var favorecido = new Favorecido
                {
                    Nome = txtNome.Text,
                    Telefone = txtTelefone.Text,
                    TipoFavorecido = (TipoFavorecido)cbxTipoFavorecido.SelectedItem
                };

                if (txtId.Text == string.Empty)
                {
                    favorecidoController.Salvar(favorecido);
                }
                else
                {
                    favorecido.Id = Convert.ToInt64(txtId.Text);
                    favorecidoController.Atualizar(favorecido);
                }

                AtualizaDgv();
                InicializaCombobox();
                Limpar();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dgvFavorecidos_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dgvFavorecidos.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvFavorecidos.CurrentRow.Cells[1].Value.ToString();
            txtTelefone.Text = dgvFavorecidos.CurrentRow.Cells[2].Value.ToString();
            cbxTipoFavorecido.Text = dgvFavorecidos.CurrentRow.Cells[3].Value.ToString();
        }

        private void Limpar()
        {
            dgvFavorecidos.ClearSelection();
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            cbxTipoFavorecido.SelectedIndex = -1;
            errorProvider.Clear();
            txtNome.Focus();
        }

        private void AtualizaDgv()
        {
            dgvFavorecidos.Rows.Clear();
            foreach(var favorecido in favorecidoController.Listar())
            {
                dgvFavorecidos.Rows.Add(favorecido.Id, favorecido.Nome, favorecido.Telefone, favorecido.TipoFavorecido);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione o Favorecido a ser excluído!");
            }
            else
            {
                if (MessageBox.Show("Deseja realmente excluir", "Excluir Favorecido", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.favorecidoController.Excluir(Convert.ToInt64(txtId.Text));
                    AtualizaDgv();
                    Limpar();
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvFavorecidos.Rows.Clear();
            var favorecidos = this.favorecidoController.PorNome(txtNomePesquisa.Text);
            foreach (var favorecido in favorecidos)
            {
                dgvFavorecidos.Rows.Add(favorecido.Id, favorecido.Nome, favorecido.Telefone, favorecido.TipoFavorecido);
            }
            Limpar();

            if (favorecidos.Count < 1)
                MessageBox.Show("Não foi possivel localixar nenhhum Favorecido que contenha o nome " + txtNomePesquisa.Text,
                    "Pesquisa de Favorecido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarFavorecido()
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                valido = false;
                errorProvider.SetError(txtNome, "O nome é obrigatório!");
                errorProvider.SetIconPadding(txtNome, 2);
            }

            if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                valido = false;
                errorProvider.SetError(txtTelefone, "O telefone é obrigátório!");
                errorProvider.SetIconPadding(txtTelefone, 2);
            }
            if(string.IsNullOrEmpty(cbxTipoFavorecido.Text))
            {
                valido = false;
                errorProvider.SetError(cbxTipoFavorecido, "O Tipo do Favorecido é obrigatório!");
                errorProvider.SetIconPadding(cbxTipoFavorecido, 2);
            }

            return valido;
        }

        private void FormFavorecido_KeyDown(object sender, KeyEventArgs e)
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
