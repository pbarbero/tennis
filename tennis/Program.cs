using System;
using System.Threading;
using System.Collections.Generic;

namespace tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get names
            Console.Write("Nombre jugador 1: ");
            string name1 = Console.ReadLine();
            Console.Write("Nombre jugador 2: ");
            string name2 = Console.ReadLine();

            //Get number of sets
            Console.Write("Partido a 3 ó 5 sets?: ");
            int numberSets = 0;
            while(numberSets != 3 && numberSets != 5)
            {
                bool result = Int32.TryParse(Console.ReadLine(), out numberSets);
                if(!result)
                {
                    Console.WriteLine("Por favor introduzca un número.");
                    continue;
                }
            }

            Match match = new Match(name1, name2, numberSets);
            match.PlayMatch();
        }
    }
}
