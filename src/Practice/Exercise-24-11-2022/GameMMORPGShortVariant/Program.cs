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

            // declare the scope of the heroesHP array - how many
            // hit points it will contain
            int[] heroesHP = new int[numberOfHeroes];

            // declare the scope of the heroesHP array - how many
            // magic points it will contain
            int[] heroesMP = new int[numberOfHeroes];

            for (int i = 0; i < numberOfHeroes; i++)
            {
                // commands of type: Saber 66 99
                string[] heroCommands = Console.ReadLine().Split().ToArray();
                // the consequtive population of the three declared arrays
                heroesNames[i] = heroCommands[0];
                heroesHP[i] = int.Parse(heroCommands[1]);
                heroesMP[i] = int.Parse(heroCommands[2]);
            }

            Console.WriteLine();

            // Reversing the arrays 
            heroesNames = heroesNames.Reverse().ToArray();
            heroesHP = heroesHP.Reverse().ToArray();
            heroesMP = heroesMP.Reverse().ToArray();

            // Displaying information
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
            foreach (int mp in heroesMP)
            {
                Console.Write($"{mp} ");
            }
            Console.WriteLine();
        }
    }
}
