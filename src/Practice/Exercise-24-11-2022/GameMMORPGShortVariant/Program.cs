using System;
using System.Linq;

namespace GameMMORPGShortVariant
{
    public class Program
    {
        static void Main(string[] args)
        {
            // enter the number of heroes 
            int numberOfHeroes = int.Parse(Console.ReadLine());

            // declare the scope of the heroesNames array - how many
            // names it will contain
            string[] heroesNames = new string[numberOfHeroes];

            int[] heroesHP = new int[numberOfHeroes];

            int[] heroesMana = new int[numberOfHeroes];

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroCommands = Console.ReadLine().Split().ToArray();
                heroesNames[i] = heroCommands[0];
                heroesHP[i] = int.Parse(heroCommands[1]);
                heroesMana[i] = int.Parse(heroCommands[2]);
            }

            Console.WriteLine("Heroes names: ");
            foreach (string name in heroesNames)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();
            Console.WriteLine("Heroes HP: ");
            foreach (int hp in heroesHP)
            {
                Console.Write($"{hp} ");
            }
            Console.WriteLine();
            Console.WriteLine("Heroes MP: ");
            foreach (int mp in heroesMana)
            {
                Console.Write($"{mp} ");
            }
            Console.WriteLine();
        }
    }
}
