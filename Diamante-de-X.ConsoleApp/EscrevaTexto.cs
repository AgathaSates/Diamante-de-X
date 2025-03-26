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
        Console.WriteLine("Gerando Diamante...");
        Thread.Sleep(1150);

        Console.WriteLine("---------------------------------------------------------");
        Diamante.DesenharDiamante();
        Console.WriteLine("---------------------------------------------------------");
    }

}
