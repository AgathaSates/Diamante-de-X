using Diamante_de_X.ConsoleApp.Entidades.Utilitários;

namespace Diamante_de_X.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            EscrevaTexto.ExibirTitulo();
            EscrevaInteracao.PedirEntrada();
            EscrevaTexto.ExibirDiamante();

        } while (EscrevaInteracao.GerarDiamanteNovamente());
    }
}
