using System.Collections.Immutable;

namespace Exercicio04
{
    internal class Program
    {
        //ponto de melhora: fazer letras não serem convertidas para 0
        static void Main(string[] args)
        {
            Console.WriteLine("ORDENAR ARRAY: CRESCENTE");

            Console.WriteLine("Digite os números separados por espaços:");
            string? entrada = Console.ReadLine();
            while (string.IsNullOrEmpty(entrada))
            {
                Console.WriteLine("Entrada vazia, digite novamente:");
                entrada = Console.ReadLine();
            }

            string[] entradaNumeros = entrada.Split(' ');

            // Passa os números da array de string para o array de int
            int[] numeros = new int[entradaNumeros.Length];
            for (int i = 0; i < entradaNumeros.Length; i++)
            {
                if (int.TryParse(entradaNumeros[i], out int num))
                {
                    numeros[i] = num;
                }
            }
            Array.Sort(numeros);

            Console.WriteLine("Array ordenado:");
            Array.ForEach(numeros, e => Console.Write($"{e} "));
        }
    }
}
