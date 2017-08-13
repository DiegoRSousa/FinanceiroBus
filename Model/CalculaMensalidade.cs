namespace FinanceiroBus.Model
{
    public class CalculaMensalidade
    {
        public int Dias { get; set; }
        public double ValorDoCombustivel { get; set; }
        public double ValorDoMotorista { get; set; }
        public int NumeroDeAlunosIntegral { get; set; }
        public int NumeroDeAlunosParcial { get; set; }


        public CalculaMensalidade(int dias, double valorDoCombustivel, double valorDoMotorista, int numeroDeAlunosIntegral,
            int numeroDeAlunosParcial)
        {
            this.Dias = dias;
            this.ValorDoCombustivel = valorDoCombustivel;
            this.ValorDoMotorista = valorDoMotorista;
            this.NumeroDeAlunosIntegral = numeroDeAlunosIntegral;
            this.NumeroDeAlunosParcial = numeroDeAlunosParcial;
        }

        public double CalcularValorIntegral()
        {

            double despesaTotal = Dias * ValorDoCombustivel + ValorDoMotorista;
            return despesaTotal / (NumeroDeAlunosIntegral + (NumeroDeAlunosParcial / 2));
        }

        public double CalcularValorParcial()
        {
            return CalcularValorIntegral() / 2;
        }
    }
}
