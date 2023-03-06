using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadeando For");

        for (int contadorLinhas = 0; contadorLinhas <=9; contadorLinhas++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinhas; contadorColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
