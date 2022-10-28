namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        protected string Modelo;

        protected string Imei;

        protected int Memoria;

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero)
        {
            Numero = numero;
           

            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        protected Smartphone(string modelo, string imei, int memoria)
        {
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
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