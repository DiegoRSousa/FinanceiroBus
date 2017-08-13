using FinanceiroBus.Controller;
using FinanceiroBus.Model;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View
{
    public partial class FormConfiguracaoEmail : Form
    {
        private ConfiguracaoController configuracaoController = new ConfiguracaoController();

        public FormConfiguracaoEmail()
        {
            InitializeComponent();
        }

        private void FormConfiguracaoEmail_Load(object sender, EventArgs e)
        {
            var configuracao = this.configuracaoController.Configuracao();
            if (configuracao != null)
            {
                txtId.Text = Convert.ToString(configuracao.Id);
                txtEmail.Text = configuracao.Email;
                txtSenha.Text = configuracao.Senha;
                txtSMTP.Text = configuracao.SMTP;
                txtPorta.Text = Convert.ToString(configuracao.Porta);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (ValidarConfiguracao())
            {
                Configuracao.GetInstance().Id = 1;
                Configuracao.GetInstance().Email = txtEmail.Text;
                Configuracao.GetInstance().Senha = txtSenha.Text;
                Configuracao.GetInstance().SMTP = txtSMTP.Text;
                Configuracao.GetInstance().Porta = Convert.ToInt16(txtPorta.Text);

                if (txtId.Text == string.Empty)
                {
                    this.configuracaoController.Salvar(Configuracao.GetInstance());
                    MessageBox.Show("Configurações gravadas com sucesso!", "Aviso configuração", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    Configuracao.GetInstance().Id = Convert.ToInt64(txtId.Text);
                    this.configuracaoController.Atualizar(Configuracao.GetInstance());
                    MessageBox.Show("Configurações atualizadas com sucesso!", "Aviso configuração", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidarConfiguracao()
        {
            bool valido = true;

            if (txtEmail.Text == string.Empty)
            {
                valido = false;
                errorProvider.SetError(txtEmail, "O email é obrigátório!");
                errorProvider.SetIconPadding(txtEmail, 2);
            }

            if (txtSenha.Text == string.Empty)
            {
                valido = false;
                errorProvider.SetError(txtSenha, "A senha é obrigátória!");
                errorProvider.SetIconPadding(txtSenha, 2);
            }

            if (txtSMTP.Text == string.Empty)
            {
                valido = false;
                errorProvider.SetError(txtSMTP, "O SMTP é obrigátória!");
                errorProvider.SetIconPadding(txtSMTP, 2);
            }

            if (txtPorta.Text == string.Empty)
            {
                valido = false;
                errorProvider.SetError(txtPorta, "A porta SMTP é obrigátória!");
                errorProvider.SetIconPadding(txtPorta, 2);
            }

            return valido;
        }

        private void FormConfiguracaoEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                btnSalvar.PerformClick();
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
