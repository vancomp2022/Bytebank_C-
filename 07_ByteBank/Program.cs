// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.numero = 8745896;
            conta.Agencia = 867;
            conta.agencia = -10;

            ContaCorrente.TotalDeContasCriadas++;

            ContaCorrente contadaGabriela = new ContaCorrente(867, 86745820);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.numero);

            Console.ReadLine();
        }
    }
}
