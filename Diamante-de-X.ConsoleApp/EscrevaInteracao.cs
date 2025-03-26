namespace Diamante_de_X.ConsoleApp;

class EscrevaInteracao
{
    public static bool GerarDiamanteNovamente()
    {
        Thread.Sleep(1000);
        Console.Write("Deseja montar outro diamante? (S/N): ");

        Validadores.SimouNaoValido();

        if (Validadores.opcaoContinuar == "N")
            return false;

        else
            return true;
    }

    public static void PedirEntrada()
    {
        Console.Write("-> Digite um número ímpar entre 3 e 51: ");
        Validadores.valorValido = Validadores.EhValido();
    }
}
