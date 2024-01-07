namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONVERSÃO REAIS PARA DOLARES");
            Console.WriteLine("Reais:");
            decimal reais;
            while (!decimal.TryParse(Console.ReadLine(), out reais))
            {
                Console.Write("Erro. Digite um valor:");
            }

            Console.WriteLine("Cotação do dolar:");
            decimal cotacao;
            while (!decimal.TryParse(Console.ReadLine(), out cotacao))
            {
                Console.Write("Erro. Digite um número inteiro:");
            }

            decimal dolares = reais / cotacao;
            Console.WriteLine($"R$ {reais:F2} -> {dolares:F2} USD");


        }
    }
}
