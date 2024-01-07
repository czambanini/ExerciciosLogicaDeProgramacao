namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RAIZ QUADRADA");
            Console.WriteLine("Digite um número positivo:");
            double numero;
            while (!double.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.Write("Erro. Digite um número positivo:");
            }

            double estimativa = 1.0;

            for (int i = 0; i < 10; i++)
                estimativa = 0.5 * (estimativa + numero / estimativa);

            Console.Write($"Resultado estimado: {estimativa:F0}");
        }
    }
}
