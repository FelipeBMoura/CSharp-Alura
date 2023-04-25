namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador
            .ParaEmpresa("Caelum Ensino e Inovacao")
            .ComCnpj("23.456.789/0001-12")
            .ComItem(new ItemDaNota("item 1", 100.0))
            .ComItem(new ItemDaNota("item 2", 200.0))
            .NaDataAtual()
            .ComObservacoes("uma obs qualquer");

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new NotaFiscalDao());
            criador.AdicionaAcao(new EnviadorDeSms());

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos) ;

            Console.ReadKey();
        }
    }
}