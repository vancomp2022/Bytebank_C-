using _02_ByteBank;

namespace _02_Bytebank
{ 
    class Program
    {

        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabriela";

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.agencia);

            Console.ReadLine();
        }
    }
   
}