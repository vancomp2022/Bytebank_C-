// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using _03_ByteBank;

namespace _02_Bytebank
{
    class Program
    {

        static void Main(string[] args)
        {
            ContaCorrente ContadaGabriela = new ContaCorrente();
            ContaCorrente ContadaGabrielaCosta = new ContaCorrente();

            ContadaGabriela.titular = "Gabriela";
            ContadaGabriela.agencia = 863;
            ContadaGabriela.numero = 8631521;

            ContadaGabrielaCosta.titular = "Gabriela";
            ContadaGabrielaCosta.agencia = 863;
            ContadaGabrielaCosta.numero = 8631521;

            Console.WriteLine(ContadaGabriela == ContadaGabrielaCosta);


                ContaCorrente minhaConta = new ContaCorrente();
                minhaConta.saldo = 500;

                ContaCorrente outraConta = minhaConta;
                outraConta.saldo += 1000;

            if (ContadaGabriela.saldo >= 100)
            {
                ContadaGabriela.saldo -= 100;
            }

                Console.WriteLine(minhaConta.saldo);
                Console.ReadLine();


        Console.ReadLine();

        }
    }
}