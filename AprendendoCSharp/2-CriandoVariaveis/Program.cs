using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade;

        idade = 27;

        Console.WriteLine("Minha idade agora é " + idade);

        idade = idade - 5;

        Console.WriteLine(idade);

        idade = 5 * 2 - 6;

        Console.WriteLine(idade);

        idade = (5 - 2) * 3;

        Console.Write(idade); // O método Write não quebra linha.

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}
