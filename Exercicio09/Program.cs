using System.Xml.Serialization;

namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VALIDAÇÃO DE CPF");
            Console.Write("Digite o CPF:");
            string? cpf = Console.ReadLine();
            while (string.IsNullOrEmpty(cpf))
            {
                Console.WriteLine("Entrada vazia, digite novamente:");
                cpf = Console.ReadLine();
            }

            if (ValidarCPF(cpf) == true) Console.WriteLine("CPF válido!");
            else Console.WriteLine("CPF inválido!");
        }

        public static bool ValidarCPF(string cpf)
        {
            // remover possiveis pontos e traços
            
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verificar se o CPF tem 11 dígitos
            if (cpf.Length != 11)
            {
                Console.WriteLine("CPF Invalido: Quantidade de dígitos incorreta.");
                return false;
            }

            //Verificação do primeiro digito:
            int soma = 0;
            for (int i = 0; i <9; i++)
            {
                soma = soma + (10 - i) * int.Parse(cpf[i].ToString());
            }
            int resto = soma % 11;
            int primeiroDigito;
            if (resto < 2) primeiroDigito = 0;
            else primeiroDigito = 11 - resto;

            if (primeiroDigito != int.Parse(cpf[9].ToString()))
            {
                return false;
            }

            //Verificação do primeiro digito:
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma = soma + (11 - i) * int.Parse(cpf[i].ToString());
            }
            resto = soma % 11;
            int segundoDigito;
            if (resto < 2) segundoDigito = 0;
            else segundoDigito = 11 - resto;

            if (segundoDigito != int.Parse(cpf[10].ToString()))
            {
                return false;
            }

            return true;
        }
    }
}
