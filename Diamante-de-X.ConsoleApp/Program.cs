namespace Diamante_de_X.ConsoleApp;

internal class Program
{

    static void Main(string[] args)
    {
        const int limitedodiamante = 51;
        int valorValido;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("               Diamante de X");
            Console.WriteLine("---------------------------------------------------------");

            Console.Write("-> Digite um número ímpar entre 1 e 51: ");
            string valorDigitado = Console.ReadLine();

            while (true)
            {
               
                if (string.IsNullOrWhiteSpace(valorDigitado) || !int.TryParse(valorDigitado, out valorValido))
                {
                    Console.Write(" -> (X) Valor inválido! Digite novamente: ");
                    valorDigitado = Console.ReadLine();
                }
                else
                    break;
            }

            while (valorValido % 2 == 0)
            {
                Console.Clear();
                Console.Write($"(X) {valorValido} não é ímpar, digite novamente: ");
                valorValido = Convert.ToInt32(Console.ReadLine());
            }

            while (valorValido < 0 || valorValido > limitedodiamante)
            {
                Console.Clear();
                Console.Write($"(X) {valorValido} não está entre 1 e 51, digite novamente: ");
                valorValido = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Gerando Diamante...");
            Thread.Sleep(1150);

            Console.WriteLine("---------------------------------------------------------");
            for (int i = 0; i < valorValido; i++)
            {
                if (i <= valorValido / 2)
                {
                    Console.WriteLine(new string(' ', valorValido / 2 - i) + new string('x', 2 * i + 1));
                }

                else
                {
                    Console.WriteLine(new string(' ', i - valorValido / 2) + new string('x', 2 * (valorValido - i) - 1));
                }
            }
            Console.WriteLine("---------------------------------------------------------");

            Thread.Sleep(1000);
            Console.Write("Deseja efetuar outro calculo? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();
            while (string.IsNullOrWhiteSpace(opcaoContinuar) || opcaoContinuar.ToUpper() != "S" && opcaoContinuar.ToUpper() != "N")
            {
                Console.Write(" -> (X) Opção inválida! Digite novamente: ");
                opcaoContinuar = Console.ReadLine()!;
            }
            if (opcaoContinuar == "N")
               break;
        }
    }
}
