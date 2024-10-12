using DesafioPOO.Models;
namespace DesafioPOO

{
    public class Program
    {
        static void RetornaDadosSmartphone(Smartphone smartphone)
        {
            Console.WriteLine($"Seu novo celular: {smartphone.Modelo}\nMemoria: {smartphone.Memoria}\nImei: {smartphone.Imei}\nNumero: {smartphone.Numero}");
        }

        static void ProcessaSmartphone(Smartphone smartphone)
        {
            RetornaDadosSmartphone(smartphone);

            Console.WriteLine("Digite o aplicativo que deseja instalar => Ex:(Candy Crush)");
            string nomeApp = Console.ReadLine();
            smartphone.InstalarAplicativo(nomeApp);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Informe o Smartphone desejado:\n* 1 - NOKIA.\n* 2 - IPHONE.");
            int tipoSmartphone = int.Parse(Console.ReadLine());
            string modelo = "";
            string imei = "1230205SBASDD1233ASBFC123";
            string numero = "31 99999-1010";
            int memoria = 128;

            if (tipoSmartphone == 1)
            {
                Console.WriteLine($"Digite o modelo...\nEx:(Nokia 1100)");
                modelo = Console.ReadLine().ToUpper();
                Nokia nokia = new Nokia(modelo: modelo, memoria: memoria, numero: numero, imei: imei);
                ProcessaSmartphone(nokia);
            }
            else
            {
                Console.WriteLine($"Digite o modelo...\nEx:(Iphone SE))");
                modelo = Console.ReadLine().ToUpper();
                Iphone iphone = new Iphone(modelo: modelo, memoria: memoria, numero: numero, imei: imei);

                ProcessaSmartphone(iphone);
            }
        }
    }
}