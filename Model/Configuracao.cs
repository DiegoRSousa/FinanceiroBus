namespace FinanceiroBus.Model
{
    public class Configuracao
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string SMTP { get; set; }
        public int Porta { get; set; }

        private static Configuracao Instance;

        private Configuracao() { }

        public static Configuracao GetInstance()
        {
            return (Instance == null) ? Instance = new Configuracao() : Instance;
        }
    }
}
