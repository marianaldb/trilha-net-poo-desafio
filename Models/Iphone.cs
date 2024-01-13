namespace DesafioPOO.Models
{
   // TODO: Herdar da classe "Smartphone"
    public class Apple : Smartphone
    {
        public Apple(string numero, string imei,string marca, string modelo, int memoria, int armazenamento) : base(numero, imei,marca, modelo, memoria, armazenamento)
        {}
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            if(string.IsNullOrWhiteSpace(nomeApp))
                throw new ArgumentNullException("O nome do aplicativo deve ser informado.");
            else
            {
                Console.WriteLine($"Instalando {nomeApp}...");
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"{i}...");
                    Thread.Sleep(1000);
                }
                Console.WriteLine($"{nomeApp} instalado com sucesso!");
            }
            
        }
    }
}
