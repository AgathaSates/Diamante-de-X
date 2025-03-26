namespace Diamante_de_X.ConsoleApp;

class EscrevaTexto
{
    public static void ExibirTitulo()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("               Diamante de X");
        Console.WriteLine("---------------------------------------------------------");
    }

    public static void ExibirDiamante()
    {
        Console.Clear();
        ExibirTitulo();
        Console.Write("-> Gerando Diamante");
        EscreverLento("...");
        Thread.Sleep(1150);

        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------");
        Diamante.DesenharDiamante();
        Console.WriteLine("---------------------------------------------------------");
    }

    public static void EscreverLento(string mensagem)
    {
        foreach (char c in mensagem)
        {
            Console.Write(c);
            Thread.Sleep(250);
        }
    }
}
