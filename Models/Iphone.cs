namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Dictionary<string, decimal> appsPreco = new Dictionary<string, decimal>
            {
                {"Instagram", 0.00M}, {"Facebook", 0.00M}, {"MS-Office-360", 52.99M}, {"XY-AI", 105.65M }
            };
            
            if(appsPreco.ContainsKey(nomeApp))
            {                
                if(appsPreco[nomeApp] > 0)
                {                    
                    Console.WriteLine($"O aplicativo {nomeApp} foi instalado com sucesso!\nCobrança: sim.\nValor: {appsPreco[nomeApp]}");
                }
                else
                {                    
                    Console.WriteLine($"O aplicativo {nomeApp} foi instalado com sucesso!\nCobrança: não.");
                }
            } 
            else
            {
                Console.WriteLine($"O aplicativo {nomeApp} não foi encontrado!");
            }
        }
        public override void ImprimirInformacoesTelefone()
        {
            Console.Write("Instalado: Iphone, ");
            base.ImprimirInformacoesTelefone();
            Console.WriteLine($"-------------------------------------------------");
        }
    }
}