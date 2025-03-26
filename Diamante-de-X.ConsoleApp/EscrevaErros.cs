namespace Diamante_de_X.ConsoleApp;

class EscrevaErros
{
    public static void NaoEstaNoIntervalo()
    { 
        Colorir.EscreverEmVermelho($"(X) {Validadores.valorValido} não está entre 3 e 51, digite novamente: ");
    }

    public static void NaoehImpar()
    { 
        Colorir.EscreverEmVermelho($"(X) {Validadores.valorValido} não é ímpar, digite novamente: ");
    }

    public static void NaoehINT() 
    {
        Colorir.EscreverEmVermelho($"(X) {Validadores.valorDigitado} não é um número inteiro, Digite novamente: ");
    }

    public static void NaoehSimouNao() 
    {
        Colorir.EscreverEmVermelho("(X) Opção inválida! Digite novamente S ou N: ");
    }
}
