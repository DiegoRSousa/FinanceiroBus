using FinanceiroBus.Controller;
using FinanceiroBus.Model;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View
{
    public partial class FormAluno : Form
    {
        private AlunoController alunoController = new AlunoController();

        public FormAluno()
        {
            InitializeComponent();
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
            AtualizaDgv();
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            var aluno = new Aluno
            {
                Nome = txtNome.Text,
                Matricula = txtMatricula.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text
            };

            if (ValidarAluno())
            {
                if (txtId.Text == string.Empty)
                {
                    alunoController.Salvar(aluno);
                }
                else
                {
                    aluno.Id = Convert.ToInt64(txtId.Text);
                    alunoController.Atualizar(aluno);
                }

                AtualizaDgv();
                Limpar();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dgvAlunos_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvAlunos.CurrentRow.Cells[1].Value.ToString();
            txtMatricula.Text = dgvAlunos.CurrentRow.Cells[2].Value.ToString();
            txtTelefone.Text = dgvAlunos.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvAlunos.CurrentRow.Cells[4].Value.ToString();
        }

        private void Limpar()
        {
            dgvAlunos.ClearSelection();
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtMatricula.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            errorProvider.Clear();
            txtNome.Focus();
        }

        private void AtualizaDgv()
        {
            dgvAlunos.Rows.Clear();
            foreach (var aluno in this.alunoController.Listar())
            {
                dgvAlunos.Rows.Add(aluno.Id, aluno.Nome, aluno.Matricula, aluno.Telefone, aluno.Email);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione o aluno a ser excluído!");
            }
            else
            {
                if (MessageBox.Show("Deseja realmente excluir", "Excluir Aluno", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.alunoController.Excluir(Convert.ToInt64(txtId.Text));
                    AtualizaDgv();
                    Limpar();
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.Clear();
            var alunos = this.alunoController.PorNome(txtNomePesquisa.Text);
            foreach (var aluno in alunos)
            {
                dgvAlunos.Rows.Add(aluno.Id, aluno.Nome, aluno.Matricula, aluno.Telefone, aluno.Email);
            }
            Limpar();

            if (alunos.Count < 1)
                MessageBox.Show("Não foi possivel localixar nenhhum aluno que contenha o nome " + txtNomePesquisa.Text,
                    "Pesquisa de aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarAluno()
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

            return valido;
        }

        private void FormAluno_KeyDown(object sender, KeyEventArgs e)
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
