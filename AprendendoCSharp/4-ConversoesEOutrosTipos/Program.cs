using System;
using System.Security.Cryptography.X509Certificates;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e Outros Tipos");

        double salario;

        salario = 3000.15;

        Console.WriteLine(salario);

        int salarioInteiro;

        salarioInteiro = (int)salario; // Cast de double para inteiro

        Console.WriteLine(salarioInteiro);

        // int x;
        // x = 2000000000000; // Int guarda até 32 bits, logo número grandes não compilarão

        long x = 2000000000000000000;

        Console.WriteLine(x);

        // short y;

        // y = 15000;

        short y = 15000;

        Console.WriteLine(y);

        float altura;

        altura = 1.62f; // O f serve para avisar o compilador de que a variável deve ser float, e não double, já que o compilador avisa do problema da falta de precisão do float em relação ao double

        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
