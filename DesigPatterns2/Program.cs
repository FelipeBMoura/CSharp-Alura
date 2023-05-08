using DesigPatterns2;
using DesigPatterns2.Cap1;
using DesigPatterns2.Cap2;
using DesigPatterns2.Cap3;
using DesigPatterns2.Cap4;
using DesigPatterns2.Cap5;
using DesigPatterns2.Cap6;
using DesigPatterns2.Cap7;
using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Mauricio", 100.0);
            Pedido pedido2 = new Pedido("Marcelo", 200.0);
            
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
        }
    }
}
