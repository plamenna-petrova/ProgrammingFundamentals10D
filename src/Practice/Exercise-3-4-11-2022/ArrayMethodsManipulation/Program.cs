using System;
using System.Linq;

namespace ArrayMethodsManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] arrayToManipulate = Console.ReadLine().Split(' ').ToArray();

            int countOfCommands = int.Parse(Console.ReadLine());

            while (countOfCommands > 0)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();

                switch (commands[0])
                {
                    case "Distinct":
                        arrayToManipulate = arrayToManipulate.Distinct().ToArray();
                        break;
                    case "Reverse":
                        // arrayToManipulate = arrayToManipulate.Reverse();
                        Array.Reverse(arrayToManipulate);
                        break;
                    case "Replace":
                        int replacementIndex = int.Parse(commands[1]);
                        string elementToReplace = commands[2];
                        arrayToManipulate[replacementIndex] = elementToReplace;
                        break;
                }

                countOfCommands--;
            }

            Console.WriteLine(string.Join(", ", arrayToManipulate));
        }
    }
}
