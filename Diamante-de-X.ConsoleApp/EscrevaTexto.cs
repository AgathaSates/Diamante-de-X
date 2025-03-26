namespace Diamante_de_X.ConsoleApp;

class EscrevaTexto
{
    public static void ExibirTitulo()
    {
        Console.Clear();
        Colorir.EscreverEmAzulEscuro("---------------------------------------------------------");
        Colorir.EscreverEmAzulEscuro("                   Diamante de X");
        Colorir.EscreverEmAzulEscuro("---------------------------------------------------------");
    }

    public static void ExibirDiamante()
    {
        Console.Clear();
        ExibirTitulo();
        Colorir.EscreverEmAmarelo("-> Gerando Diamante");
        EscreverLento("...");
        Thread.Sleep(1150);

        Console.WriteLine();
        Colorir.EscreverEmAzulEscuro("---------------------------------------------------------");
        Diamante.DesenharDiamante();
        Colorir.EscreverEmAzulEscuro("---------------------------------------------------------");
    }

    public static void EscreverLento(string mensagem)
    {
        foreach (char c in mensagem)
        {
            Colorir.EscreverCharEmAmarelo(c);
            Thread.Sleep(250);
        }
    }
}
