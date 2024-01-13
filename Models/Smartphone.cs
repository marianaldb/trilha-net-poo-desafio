namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
         public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string IMEI { get; set; }
        protected string Marca { get; set; }
        protected string Modelo { get; set; }
        protected int Memoria { get; set; }
        protected int Armazenamento { get; set; }

        public Smartphone(string numero, string imei,string marca, string modelo, int memoria, int armazenamento)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            IMEI = imei;
            Marca = marca;
            Modelo = modelo;
            Memoria = memoria;
            Armazenamento = armazenamento;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
