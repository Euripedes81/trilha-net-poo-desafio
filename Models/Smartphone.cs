namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private readonly string _modelo;
        private readonly string _imei;
        private readonly int _memoria;
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public virtual void ImprimirInformacoesTelefone()
        {
            Console.WriteLine($"Modelo: {_modelo}, IMEI: {_imei}, Memória: {_memoria}, Número cadastrado: {Numero}\n");
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}