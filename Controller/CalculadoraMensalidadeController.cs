using FinanceiroBus.Model;

namespace FinanceiroBus.Controller
{
    public class CalculadoraMensalidadeController
    {
        private CalculadoraMensalidade calculadoraMensalidade;
        public CalculadoraMensalidadeController(int dias, double valorDoCombustivel, double valorDoMotorista,
            int numeroDeAlunosIntegral, int numeroDeAlunosParcial)
        {
            calculadoraMensalidade = new CalculadoraMensalidade(dias, valorDoCombustivel, valorDoMotorista,
                numeroDeAlunosIntegral, numeroDeAlunosParcial);
        }

        public double CalcularValorIntegral()
        {
            return calculadoraMensalidade.CalcularValorIntegral();
        }

        public double CalcularValorParcial()
        {
            return calculadoraMensalidade.CalcularValorParcial();
        }
    }
}
