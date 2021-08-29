using System;

namespace ProgramaCebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oi, me chamo Cebolinha!");
            Console.WriteLine("  \\|/");
            Console.WriteLine("(^ - ^)");

            Console.WriteLine();

            Console.Write("Digite seu texto para eu ler: ");
            string textoTrocado = Console.ReadLine();
            
            Console.WriteLine();

            Console.Write("OK, vou ler aqui: ");
            Console.WriteLine(textoTrocado.Replace("r" , "l" ).Replace("R" , "L") + ", celto?");
        }
    }
}
