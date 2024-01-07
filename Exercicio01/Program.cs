namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float tCelsius;
            float tFahrenheit;

            Console.WriteLine("CONVERSOR CELSIUS X FAHRENHEIT");

            Console.WriteLine("A a partir de qual temperatura você quer converter? \n1. Celcius \n2. Farenheit");

            int entradaSwitch;
            while (!int.TryParse(Console.ReadLine(), out entradaSwitch))
            {
                Console.Write("Digite o número correspondente ao usuário");
            }

            switch (entradaSwitch)
            {
                case 1:
                    Console.WriteLine("Digite a temperatura em Celcius");
                    while (!float.TryParse(Console.ReadLine(), out tCelsius))
                    {
                        Console.Write("Entrada inválida, tente novamente: ");
                    }
                    tFahrenheit = (tCelsius / 5 * 9) + 32;
                    Console.WriteLine($"{tCelsius}° C = {tFahrenheit:F2} F");
                    return;
                case 2:
                    Console.WriteLine("Digite a temperatura em Fahrenheit");
                    while (!float.TryParse(Console.ReadLine(), out tFahrenheit))
                    {
                        Console.Write("Entrada inválida, tente novamente: ");
                    }
                    tCelsius = (tFahrenheit - 32) / 9 * 5;
                    Console.WriteLine($"{tFahrenheit} F = {tCelsius:F2}° C");
                    return;
                default:

                    return;
            }

        }
    }
}
