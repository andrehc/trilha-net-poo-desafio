namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone()
        {

        }
        public Iphone(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Deseja instalar {nomeApp}?\n* 1: SIM\n* 2: NÃO");
            int confirmacao = int.Parse(Console.ReadLine());
            if (confirmacao == 1)
            {
                Console.WriteLine($"Aplicativo {nomeApp}.ipa instalado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Instalação cancelada ou opção inválida.");
            }
        }
    }
}