namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando {Modelo}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void VinculandoNumero()
        {
            Console.WriteLine($"Instalando Whatsapp no numero: {Numero}");
        }
        public void InformandoMemoria()
        {
            Console.WriteLine($"Memória disponível: {Memoria} GB");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}