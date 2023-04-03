using bytebank;
using bytebank.Contas;
using bytebank.Titular;


try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
    /*
    conta1.sacar(50);
    Console.WriteLine(conta1.GetSaldo());
    conta1.sacar(150);
    Console.WriteLine(conta1.GetSaldo());
    */
}
catch (ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro: " + ex.ParamName); // mostra qual argumento está lançando a exceção
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message); // Mostra a mensagem do throw
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada! Saldo insuficiente!");
    Console.WriteLine(ex.Message);
}
