using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int fatorial = 1;

            Console.WriteLine("CALCULAR FATORIAL");

            Console.WriteLine("Digite um número inteiro:");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Digite um número inteiro:");
            }

            for (int i = 2; i <= numero; i++)
            {
                fatorial = fatorial * i;
            }

            Console.Write($"{numero}! = {fatorial}");
        }
    }
}
