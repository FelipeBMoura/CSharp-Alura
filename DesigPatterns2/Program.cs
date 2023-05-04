using DesigPatterns2;
using DesigPatterns2.Cap1;
using DesigPatterns2.Cap2;
using DesigPatterns2.Cap3;
using DesigPatterns2.Cap4;
using DesigPatterns2.Cap5;
using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);            

            Console.WriteLine(soma.Avalia());

            ImpressoraVisitor impressora = new ImpressoraVisitor();
            soma.Aceita(impressora);

        }
    }
}
