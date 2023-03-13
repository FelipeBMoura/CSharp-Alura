using System;

namespace bytebank
{

	public class ContaCorrente
	{
		public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;

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

	}
}