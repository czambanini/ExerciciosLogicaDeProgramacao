using System.Runtime.Serialization;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("REPETIÇÃO DE PALAVRAS");
            Console.WriteLine("Escreva uma frase: ");
            string frase = Console.ReadLine();
            frase = frase.ToLower();
            string[] palavras = frase.Split(' ');
            string[] palavrasSemRepeticao = palavras.Distinct().ToArray();

            for (int i = 0; i < palavrasSemRepeticao.Length; i++)
            {
                int soma = 0;
                foreach (var palavra in palavras)
                {
                    if (palavrasSemRepeticao[i].ToLower() == palavra.ToLower()) soma++;
                }
                Console.WriteLine($"{palavrasSemRepeticao[i]} = {soma} vezes");
            }

        }
    }
}
