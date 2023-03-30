using bytebank.Contas;
using bytebank.Titular;


try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
}
catch (ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro: " + ex.ParamName); // mostra qual argumento está lançando a exceção
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.Message); // Mostra a mensagem do throw
}
