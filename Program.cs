using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome, Sobrenome;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Escreva o seu nome: ");
            Console.ResetColor();
            Nome = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Escreva o seu sobrenome: ");
            Console.ResetColor();
            Sobrenome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Nome completo: ");
            Console.ResetColor();
            Console.Write(Nome);
            Console.Write(" ");
            Console.WriteLine(Sobrenome);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Nome Catalogo: ");
            Console.ResetColor();
            Sobrenome = Sobrenome.ToUpper();
            Console.Write(Sobrenome);
            Console.Write(", ");
            Console.WriteLine(Nome);
            Console.WriteLine();

        }
    }
}
