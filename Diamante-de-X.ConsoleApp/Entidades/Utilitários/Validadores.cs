namespace Diamante_de_X.ConsoleApp.Entidades.Utilitários;

class Validadores
{
    public static int valorValido;
    public static string valorDigitado = "";
    public static string opcaoContinuar = "";

    public static int EhValido()
    {
        EhUmINT();          //Santa Trindade
        EhImpar();
        EstanoLimite();

        return valorValido;
    }

    public static void EstanoLimite()
    {
        while (valorValido < 3 || valorValido > Diamante.limitedodiamante)
        {
            EscrevaErros.NaoEstaNoIntervalo();
            valorValido = EhValido();
        }
    }

    public static void EhImpar()
    {
        while (valorValido % 2 == 0)
        {
            EscrevaErros.NaoehImpar();
            valorValido = EhValido();
        }
    }

    public static int EhUmINT()
    {
        while (true)
        {
            valorDigitado = Console.ReadLine()!;

            if (string.IsNullOrWhiteSpace(valorDigitado) || !int.TryParse(valorDigitado, out valorValido))
                EscrevaErros.NaoehINT();
            
            else
                break;
        }
        return valorValido;
    }

    public static void SimouNaoValido()
    {
        opcaoContinuar = Console.ReadLine()!.ToUpper();
        while (string.IsNullOrWhiteSpace(opcaoContinuar) || opcaoContinuar.ToUpper() != "S" && opcaoContinuar.ToUpper() != "N")
        {
            EscrevaErros.NaoehSimouNao();
            opcaoContinuar = Console.ReadLine()!;
        }
    }
}
