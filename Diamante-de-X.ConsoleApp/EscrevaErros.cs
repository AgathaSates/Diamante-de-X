namespace Diamante_de_X.ConsoleApp;

class EscrevaErros
{
    public static void NaoEstaNoIntervalo()
    {
        Console.Clear();
        Console.Write($"(X) {Validadores.valorValido} não está entre 3 e 51, digite novamente: ");
    }

    public static void NaoehImpar() 
    {
        Console.Clear();
        Console.Write($"(X) {Validadores.valorValido} não é ímpar, digite novamente: ");
    }

    public static void NaoehINT() 
    {
        Console.Write($"(X) {Validadores.valorDigitado} não é um número inteiro, Digite novamente: ");
    }

    public static void NaoehSimouNao() 
    {
        Console.Write("(X) Opção inválida! Digite novamente S ou N: ");
    }
}
