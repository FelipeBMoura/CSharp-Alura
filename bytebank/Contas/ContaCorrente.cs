using System;
using bytebank.Titular;

namespace bytebank.Contas
{

	public class ContaCorrente
	{
        public static int TotalDeContasCriadas { get; private set; }

		public static float TaxaOperacao { get; private set; }



        private int numero_agencia;

		public int Numero_agencia
		{
			get { return numero_agencia; }
			private set {
				if (value > 0)
					numero_agencia = value;
			}
		}
        // private string? conta;
		public string? Conta { get; set; } 

        public double saldo=100;

        public Cliente? Titular { get; set; }

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
				throw new SaldoInsuficienteException("Saldo insuficiente para a operação.");
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

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
			Numero_agencia = numero_agencia;
			Conta = numero_conta;
			if(numero_agencia <= 0)
			{
				throw new ArgumentException("Número de agência menor ou igual a zero!", nameof(numero_agencia));
			}

			/*
			try
			{
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }
			catch(DivideByZeroException) 
			{
                Console.WriteLine("Ocorreu um erro! Não é possível fazer uma divisão por zero!");
            }
			*/
			
			TotalDeContasCriadas++;
        }
    }
}