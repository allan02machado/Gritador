using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite algo: ");
            string texto = Console.ReadLine();
            Console.Write(texto.ToUpper());
            Console.WriteLine("!!!");
        }
    }
}
