using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.WriteLine("Dimmi il tuo nome: ");
            nome= Console.ReadLine();
            Console.WriteLine($"Ciao {nome}");
        }
    }
}
