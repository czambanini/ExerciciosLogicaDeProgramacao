namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool ehPrimo = true;

            Console.WriteLine("CONSULTA DE NÚMERO PRIMO");

            Console.WriteLine("Digite um número inteiro:");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Digite um número inteiro:");
            }

            if (numero > 2)
            {
                for (int i = 2; i <= numero/2; i++)
                {
                    
                    if (numero % i == 0)
                    {
                        ehPrimo = false;
                    }
                }
            }

            if (ehPrimo == true) 
            {
                Console.Write($"O número {numero} é primo.");
            } else {
                Console.Write($"O número {numero} não é primo.");
            }
                 
        }

    }
}
