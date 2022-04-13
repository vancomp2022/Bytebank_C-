// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //static void Main(string[] args) {
            //    string titular = "Gabriela";
            //    int numeroAgencia = 863;
            //    int numeroConta = 863146;
            //    double saldo = 100;

            //    string titular2 = "Bruno";
            //    int numeroAgencia2 = 863;
            //    int numero2 = 864;
            //    double saldo2 = 50;

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 864;
            contaDaGabriela.saldo = 50.00;

            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;

            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

        }
    }
}