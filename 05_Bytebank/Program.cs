// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using _05_Bytebank;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente gabriela = new cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();

          //  conta.titular = new cliente();

            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "434.562.878 - 20";
            conta.titular.profissao = "Desenvolvedora C#";

            conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;


            conta.titular.nome = "Gabriela Costa";

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();


        }
    }
}

