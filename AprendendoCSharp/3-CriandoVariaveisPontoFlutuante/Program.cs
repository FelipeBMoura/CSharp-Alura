using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");

        double salario;

        salario = 3000.10;

        salario = 3000; // Variável do tipo double aceitam número inteiro

        // int idade;
        // idade = 27.8; // Variável int não aceita double

        double idade;

        // idade = 7 / 5; // Apesar de ser float, o C# devolve a resposta 1, já que o numerador e o denominador são inteiros

        idade = 7.0 / 5;

        double peso = 4.0;

        int quantidade = 10;

        Console.WriteLine(peso * quantidade);

        Console.WriteLine(idade);

        Console.WriteLine(salario);
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

    }
}
