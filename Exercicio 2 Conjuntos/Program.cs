using System;
using System.Collections.Generic;
using Exercicio_2_Conjuntos.Entities;

namespace Exercicio_2_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Students> set = new HashSet<Students>();

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("How many students for course " + i + "? ");
                int n = int.Parse(Console.ReadLine());
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("Student " + j + ": ");
                    string name = Console.ReadLine();
                    set.Add(new Students { Name = name });
                }
            }
            Console.WriteLine("Total students: " + set.Count);
        }
    }
}
