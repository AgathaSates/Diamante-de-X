namespace Diamante_de_X.ConsoleApp;

internal class Program
{
    const int limitedodiamante = 51;
    public static int valorValido;
    public static string valorDigitado;
    public static string opcaoContinuar;
    static void Main(string[] args)
    {
        do
        {
            ExibirTitulo();
            PedirEntrada();
            ExibirDiamante();

        } while (GerarDiamanteNovamente());

        static void ExibirTitulo()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("               Diamante de X");
            Console.WriteLine("---------------------------------------------------------");
        }

        static void PedirEntrada()
        {
            Console.Write("-> Digite um número ímpar entre 1 e 51: ");
            valorValido = EhValido();
        }

        static int EhValido()
        {
            EhUmINT();     //santa trindade
            EhImpar();
            EstanoLimite();

            return valorValido;
        }

        static void EstanoLimite()
        {
            while (valorValido < 0 || valorValido > limitedodiamante)
            {
                Console.Clear();
                Console.Write($"(X) {valorValido} não está entre 1 e 51, digite novamente: ");
                valorValido = EhValido();
            }
        }

        static void EhImpar()
        {
            while (valorValido % 2 == 0)
            {
                Console.Clear();
                Console.Write($"(X) {valorValido} não é ímpar, digite novamente: ");
                valorValido = EhValido();
            }
        }

        static int EhUmINT()
        {
            while (true)
            {
                valorDigitado = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(valorDigitado) || !int.TryParse(valorDigitado, out valorValido))
                {
                    Console.Write(" -> (X) Valor inválido! Digite novamente: ");
                }
                else
                    break;
            }
            return valorValido;
        }

        static void ExibirDiamante()
        {
            Console.Clear();
            Console.WriteLine("Gerando Diamante...");
            Thread.Sleep(1150);

            Console.WriteLine("---------------------------------------------------------");
            DesenharDiamante();
            Console.WriteLine("---------------------------------------------------------");
        }

        static void DesenharDiamante() 
        {
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
        }
        static bool GerarDiamanteNovamente()
        {
            Thread.Sleep(1000);
            Console.Write("Deseja montar outro diamante? (S/N): ");

            SimouNaoValido();

            if (opcaoContinuar == "N")
                return false;

            else
                return true;
        }

        static void SimouNaoValido()
        {
            opcaoContinuar = Console.ReadLine()!.ToUpper();
            while (string.IsNullOrWhiteSpace(opcaoContinuar) || opcaoContinuar.ToUpper() != "S" && opcaoContinuar.ToUpper() != "N")
            {
                Console.Write(" -> (X) Opção inválida! Digite novamente: ");
                opcaoContinuar = Console.ReadLine()!;
            }
        }
    }
}
