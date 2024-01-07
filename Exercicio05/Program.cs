namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A PALAVRA É UM PALÍNDROMO?");

            Console.Write("Escreva uma palavra: ");
            string? palavra = Console.ReadLine();
            while (string.IsNullOrEmpty(palavra))
            {
                Console.WriteLine("Entrada vazia, digite novamente:");
                palavra = Console.ReadLine();
            }

            int tamanho = palavra.Length;
            string reverso = "";

            //escrever a palavra de trás para frente
            for (int i = 0; i < tamanho; i++)
            {
                string letra = palavra.Substring(tamanho - i - 1, 1);
                reverso = reverso + letra;
            }

            if (palavra == reverso)
            {
                Console.WriteLine("Essa palavra é um palíndromo");
            }
            else
            {
                Console.WriteLine("Não é um palíndromo");
            };
        }
    }
}
