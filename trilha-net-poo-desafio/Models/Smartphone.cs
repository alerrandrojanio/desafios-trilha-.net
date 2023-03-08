namespace DesafioPOO.Models
{
    public abstract class Smartphone {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;



        public Smartphone(string numero, string modelo, string imei, int memoria) {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar() {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao() {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void Imprimir() {
            Console.WriteLine($"Número: {Numero}, Modelo: {Modelo}, IMEI: {IMEI}, Memória {Memoria} GB");
            
        }
    }
}