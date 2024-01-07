namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VALIDAÇÃO DE SENHA");

            bool senhaValida = true;
            do
            {
                Console.Write("Digite sua senha:");
                string senha = Console.ReadLine();

                senhaValida = true;
                if (QuantidadeCaracteres(senha) == false) senhaValida = false;
                if (ContemMaiuscula(senha) == false) senhaValida = false;
                if (ContemMinuscula(senha) == false) senhaValida = false;
                if (ContemNumero(senha) == false) senhaValida = false;

            } while (senhaValida == false);

            Console.WriteLine("Senha aprovada");

        }

        public static bool QuantidadeCaracteres(string senha)
        {
            if (senha.Length >= 8)
            {
            return true;
            }
            Console.WriteLine("Senha deve conter no mínimo 8 caracteres");
            return false;
        }

        public static bool ContemMaiuscula(string senha)
        {
            foreach (char c in senha)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            Console.WriteLine("Senha deve conter no mínimo 1 caracter maiúsculo");
            return false;
        }

        public static bool ContemMinuscula(string senha)
        {
            foreach (char c in senha)
            {
                if (char.IsLower(c))
                {
                    return true;
                }
            }
            Console.WriteLine("Senha deve conter no mínimo 1 caracter minúsculo");
            return false;
        }

        public static bool ContemNumero(string senha)
        {
            foreach (char c in senha)
            {
                if (char.IsNumber(c))
                {
                    return true;
                }
            }
            Console.WriteLine("Senha deve conter no mínimo 1 número");
            return false;
        }


    }
}
