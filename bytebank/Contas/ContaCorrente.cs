using System;
using bytebank.Titular

namespace bytebank.Contas
{

	public class ContaCorrente
	{
		public int numero_agencia;
        public string conta;      
        public double saldo=100;

		public Cliente titular;

        public void depositar(double valor)
		{
			this.saldo += valor;
		}

		public bool sacar(double valor)
		{
			if (valor <= this.saldo)
			{
				this.saldo -= valor;
				return true;
			}
			else
			{
				return false;
			}

		}

		public bool transferir(double valor, ContaCorrente destino)
		{
			if(this.saldo < valor)
			{
				return false;
			}
			else
			{
				this.sacar(valor);
				destino.depositar(valor);
				return true;
			}
		}

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular :" + titular);
            Console.WriteLine("Conta :" + conta);
            Console.WriteLine("Número Agência :" + numero_agencia);
            Console.WriteLine("Nome Agência :" + nome_agencia);
            Console.WriteLine("Saldo: " + saldo);
        }


    }
}