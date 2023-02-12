using System;
using System.Linq;

namespace SafeArrayMethodManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] arrayToManipulate = Console.ReadLine().Split(' ').ToArray();

            bool isLoopOngoing = true;

            bool isArrayManipulationFinished = false;

            //while(isLoopOngoing)

            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();

                switch (commands[0])
                {
                    case "Distinct":
                        arrayToManipulate = arrayToManipulate.Distinct().ToArray();
                        break;
                    case "Reverse":
                        arrayToManipulate = arrayToManipulate.Reverse().ToArray();
                        break;
                    case "Replace":
                        int replacementIndex = int.Parse(commands[1]);
                        if (replacementIndex < 0 || replacementIndex >= arrayToManipulate.Length)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            string elementToReplace = commands[2];
                            arrayToManipulate[replacementIndex] = elementToReplace;
                        }
                        break;
                    case "END":
                        isArrayManipulationFinished = true;
                        //isLoopOngoing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

                if (isArrayManipulationFinished)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(", ", arrayToManipulate));
        }
    }
}
