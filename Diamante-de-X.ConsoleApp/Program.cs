namespace Diamante_de_X.ConsoleApp;

internal class Program
{
    //O número de linhas e colunas deve ser igual ao número ímpar fornecido.
    //A linha central do diamante deve conter o número máximo de 'X's.

    static void Main(string[] args)
    {
        const int limitedodiamante = 100;

        Console.Write("Digite um número ímpar entre 1 e 99: ");
        int valorDigitado = Convert.ToInt32(Console.ReadLine());

        while (valorDigitado % 2 == 0 || valorDigitado >= limitedodiamante)
        {
            Console.Write("Este número não é ímpar ou menor que 99, digite novamente: ");
            valorDigitado = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < valorDigitado; i++)
        {
            if (i <= valorDigitado / 2)
            {
                Console.WriteLine(new string(' ', valorDigitado / 2 - i) + new string('x', 2 * i + 1));
            }

            else
            {
                Console.WriteLine(new string(' ', i - valorDigitado / 2) + new string('x', 2 * (valorDigitado - i) - 1));
            }


        }

    }
}
