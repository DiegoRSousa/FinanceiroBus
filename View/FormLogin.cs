using System;
using System.Windows.Forms;

namespace FinanceiroBus.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (VerificaLogin())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário/Senha inválido", "Erro Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificaLogin()
        {
            if (txtUsuario.Text.Equals("admin") && txtSenha.Text.Equals("123"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
