namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
           CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);

        }
    }
}