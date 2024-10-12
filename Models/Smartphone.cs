namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone ()
        {

        }
        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero;
            Imei = imei;
            Modelo = modelo;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        public string Imei { get; }
        public string Modelo { get; }
        public int Memoria { get; }


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