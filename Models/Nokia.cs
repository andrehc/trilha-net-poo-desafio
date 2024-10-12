namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia()
        {

        }
        public Nokia(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp}.jar foi instalado com sucesso.");
        }
    }
}