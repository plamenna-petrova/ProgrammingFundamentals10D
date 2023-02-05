using System;
using System.Linq;
using System.Text;

namespace StringBuilderTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            string[] commands = Console.ReadLine().Split().ToArray();

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(inputString);

            switch (commands[0])
            {
                case "Append":
                    string stringToAppend = commands[1];
                    stringBuilder.Append(stringToAppend);
                    break;
                case "Remove":
                    int removalPosition = int.Parse(commands[1]);
                    int charactersForRemovalCount = int.Parse(commands[2]);
                    stringBuilder.Remove(removalPosition, charactersForRemovalCount);
                    break;
                case "Insert":
                    int insertionPosition = int.Parse(commands[1]);
                    string stringToInsert = commands[2];
                    stringBuilder.Insert(insertionPosition, $" {stringToInsert}");
                    break;
                case "Replace":
                    string existingSubstring = commands[1];
                    string substringToReplace = commands[2];
                    stringBuilder.Replace(existingSubstring, substringToReplace);
                    break;
            }

            string endResult = stringBuilder.ToString();

            Console.WriteLine(endResult);
        }
    }
}
