using FinanceiroBus.Controller;
using FinanceiroBus.Model;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View
{
    public partial class FormInstituicaoEnsino : Form
    {
        private InstituicaoEnsinoController instituicaoEnsinoController = new InstituicaoEnsinoController();

        public FormInstituicaoEnsino()
        {
            InitializeComponent();
        }

        private void FormInstituicaoEnsino_Load(object sender, EventArgs e)
        {
            AtualizaDgv();
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (ValidarInstituicaoEnsino())
            {
                var instituicaoEnsino = new InstituicaoEnsino
                {
                    Acronimo = txtAcronimo.Text,
                    Nome = txtNome.Text
                };
                if (txtId.Text == string.Empty)
                {
                    instituicaoEnsinoController.Salvar(instituicaoEnsino);
                }
                else
                {
                    instituicaoEnsino.Id = Convert.ToInt64(txtId.Text);
                    instituicaoEnsinoController.Atualizar(instituicaoEnsino);
                }
                AtualizaDgv();
                Limpar();
            }

        }

        private void AtualizaDgv()
        {
            dgvInstituicoesEnsino.Rows.Clear();
            foreach (var instituicaoEnsino in this.instituicaoEnsinoController.Listar())
            {
                dgvInstituicoesEnsino.Rows.Add(instituicaoEnsino.Id, instituicaoEnsino.Acronimo, instituicaoEnsino.Nome);
            }
        }

        private void Limpar()
        {
            dgvInstituicoesEnsino.ClearSelection();
            txtId.Text = string.Empty;
            txtAcronimo.Text = string.Empty;
            txtNome.Text = string.Empty;
            errorProvider.Clear();
            txtAcronimo.Focus();
        }

        private bool ValidarInstituicaoEnsino()
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtAcronimo.Text))
            {
                valido = false;
                errorProvider.SetError(txtAcronimo, "O acronimo é obrigatório!");
                errorProvider.SetIconPadding(txtAcronimo, 2);
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                valido = false;
                errorProvider.SetError(txtNome, "O nome é obrigatório!");
                errorProvider.SetIconPadding(txtNome, 2);
            }
            return valido;
        }

        private void dgvInstituicoesEnsino_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dgvInstituicoesEnsino.CurrentRow.Cells[0].Value.ToString();
            txtAcronimo.Text = dgvInstituicoesEnsino.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = dgvInstituicoesEnsino.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione a instituição de ensino a ser excluída!");
            }
            else
            {
                if (MessageBox.Show("Deseja realmente excluir", "Excluir Instituição de Ensino", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.instituicaoEnsinoController.Excluir(Convert.ToInt64(txtId.Text));
                    AtualizaDgv();
                    Limpar();
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvInstituicoesEnsino.Rows.Clear();
            foreach (var instituicaoEnsino in this.instituicaoEnsinoController.PorAcronimo(txtAcronimoPesquisa.Text))
            {
                dgvInstituicoesEnsino.Rows.Add(instituicaoEnsino.Id, instituicaoEnsino.Acronimo, instituicaoEnsino.Nome);
            }

            if (this.instituicaoEnsinoController.PorAcronimo(txtAcronimoPesquisa.Text).Count < 1)
                MessageBox.Show("Não foi possivel localixar nenhhuma instituição com parte do acronimo " + txtAcronimo.Text,
                    "Pesquisa de instiuição de ensino", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpar();
        }

        private void FormInstituicaoEnsino_KeyDown(object sender, KeyEventArgs e)
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
