namespace Diamante_de_X.ConsoleApp;

class Diamante
{
    public const int limitedodiamante = 51;

    public static void DesenharDiamante()
    {
        for (int i = 0; i < Validadores.valorValido; i++)
        {
            if (i <= Validadores.valorValido / 2)
                Console.WriteLine(new string(' ', Validadores.valorValido / 2 - i) + new string('x', 2 * i + 1));

            else      
                Console.WriteLine(new string(' ', i - Validadores.valorValido / 2) + new string('x', 2 * (Validadores.valorValido - i) - 1));
        }
    }
}
