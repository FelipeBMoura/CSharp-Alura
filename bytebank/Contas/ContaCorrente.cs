using System;
using bytebank.Titular;

namespace bytebank.Contas
{

	public class ContaCorrente
	{
        private int numero_agencia;
		public int Numero_agencia
		{
			get { return this.numero_agencia; }
			set {
				if (value > 0)
					this.numero_agencia = value;
			}
		}
        // private string? conta;
		public string? Conta { get; set; } 

        public double saldo=100;

        public Cliente? Titular { get; set; };

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

		public void SetSaldo(double valor)
		{
			if(valor < 0)
			{
				return;
			}
			else
			{
				this.saldo = valor;
			}
		}

		public double GetSaldo()
		{
			return this.saldo;
		}
		
    }
}