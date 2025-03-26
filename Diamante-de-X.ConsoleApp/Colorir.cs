namespace Diamante_de_X.ConsoleApp;

class Colorir
{
    public static void EscreverEmVermelho(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(mensagem);
        Console.ResetColor();
    }

    public static void EscreverEmAmarelo(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(mensagem);
        Console.ResetColor();
    }

    public static void EscreverCharEmAmarelo(char c)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(c);
        Console.ResetColor();
    }

    public static void EscreverEmAzulEscuro(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }

    public static void EscreverEmCiano(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(mensagem);
        Console.ResetColor();
    }
}
