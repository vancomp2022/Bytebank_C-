using _07_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public _07_ByteBank.cliente titular;
        public string titularCPF;
        public string titularProfissao;
        public int agencia;
        public int numero;
        public double saldo = 100;
        private int _agencia;
        public static int TotalDeContasCriadas { get; set; }

        public cliente Titular { get; set; }

       
        public int Agencia { get { return _agencia; } 
            
            set
            {
                if (value <= 0)
                { return; }
                    
                _agencia = value; } 
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            numero = numero;

            this.TotalDeContasCriadas++;
        }

        public ContaCorrente()
        {
        }

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}