using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();

contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

// contaDoAndre.depositar(100);

// Console.WriteLine("Saldo da conta do André pós depósito = " + contaDoAndre.saldo);

// if (contaDoAndre.sacar(300) == true)
// {

// Console.WriteLine("Saldo da conta do André pós saque = " + contaDoAndre.saldo);

//}
//else
//{
// Console.WriteLine("Saldo insuficiente para saque.");
//}

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;


Console.WriteLine("Salda da conta da Maria = " + contaDaMaria.saldo);

contaDoAndre.transferir(50, contaDaMaria);

Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);

Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

ContaCorrente contaDoPedro = new ContaCorrente();
Console.WriteLine(contaDoPedro.titular);
Console.WriteLine(contaDoPedro.saldo);
Console.WriteLine(contaDoPedro.numero_agencia);
Console.WriteLine(contaDoPedro.conta);




Console.ReadLine();
