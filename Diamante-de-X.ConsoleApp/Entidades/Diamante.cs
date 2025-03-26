using Diamante_de_X.ConsoleApp.Entidades.Utilitários;

namespace Diamante_de_X.ConsoleApp.Entidades;

class Diamante
{
    public const int limitedodiamante = 51;

    public static void DesenharDiamante()
    {
        for (int i = 0; i < Validadores.valorValido; i++)
        {
            if (i <= Validadores.valorValido / 2)
                Colorir.EscreverEmCiano(new string(' ', Validadores.valorValido / 2 - i) + new string('x', 2 * i + 1));

            else      
                Colorir.EscreverEmCiano(new string(' ', i - Validadores.valorValido / 2) + new string('x', 2 * (Validadores.valorValido - i) - 1));
        }
    }
}
