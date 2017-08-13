using FinanceiroBus.Controller;
using System;
using System.Windows.Forms;

namespace FinanceiroBus.View
{
    public partial class FormCalculadoraMensalidade : Form
    {
        private CalculadoraMensalidadeController calculadoraMensalidadeController;
        public FormCalculadoraMensalidade()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (ValidarDados())
            {
                calculadoraMensalidadeController = new CalculadoraMensalidadeController(Convert.ToInt16(txtDias.Text),
                Convert.ToDouble(txtValorCombustivel.Text), Convert.ToDouble(txtValorMotorista.Text),
                Convert.ToInt16(txtNumeroDeAlunosIntegral.Text), Convert.ToInt16(txtNumeroDeAlunosParcial.Text));

                lblTotaIntegral.Text = Convert.ToString(calculadoraMensalidadeController.CalcularValorIntegral().ToString("N2"));
                lblTotalParcial.Text = Convert.ToString(calculadoraMensalidadeController.CalcularValorParcial().ToString("N2"));
            }
        }

        private bool ValidarDados()
        {
            bool valido = true;

            if (string.IsNullOrEmpty(txtDias.Text))
            {
                valido = false;
                errorProvider.SetError(txtDias, "O campo dias é obrigatório!");
                errorProvider.SetIconPadding(txtDias, 2);
            }
            if (string.IsNullOrEmpty(txtValorCombustivel.Text))
            {
                valido = false;
                errorProvider.SetError(txtValorCombustivel, "O campo valor do combustível é obrigatório!");
                errorProvider.SetIconPadding(txtValorCombustivel, 2);
            }
            if (string.IsNullOrEmpty(txtValorMotorista.Text))
            {
                valido = false;
                errorProvider.SetError(txtValorMotorista, "O campo valor do motorista é obrigatório");
                errorProvider.SetIconPadding(txtValorMotorista, 2);
            }
            if (string.IsNullOrEmpty(txtNumeroDeAlunosIntegral.Text))
            {
                valido = false;
                errorProvider.SetError(txtNumeroDeAlunosIntegral, "O campo número de alunos integral é obrigatório");
                errorProvider.SetIconPadding(txtNumeroDeAlunosIntegral, 2);
            }
            if (string.IsNullOrEmpty(txtNumeroDeAlunosParcial.Text))
            {
                valido = false;
                errorProvider.SetError(txtNumeroDeAlunosParcial, "O campo número de alunos parcial é obrigatório");
                errorProvider.SetIconPadding(txtNumeroDeAlunosParcial, 2);
            }
            return valido;
        }
    }
}
