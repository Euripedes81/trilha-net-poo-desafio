namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
           string[] appDisponiveis = new string[] {"Jogo de corrida", "Calculadora", "Google Sheets"};
           
           if (Array.IndexOf(appDisponiveis, nomeApp) >= 0)
           {             
              Console.WriteLine($"O aplicativo {nomeApp} foi instalado com sucesso!");
           }
           else
           {
              Console.WriteLine($"O aplicativo {nomeApp} não foi encontrado!");
           }
        }

        public override void ImprimirInformacoesTelefone()
        {
            Console.Write("Instalado em: Nokia, ");
            base.ImprimirInformacoesTelefone();
             Console.WriteLine($"-------------------------------------------------");
        }
    }
}