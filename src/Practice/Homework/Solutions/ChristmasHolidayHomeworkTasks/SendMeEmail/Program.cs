using System;
using System.Linq;

namespace SendMeEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailToCheck = Console.ReadLine();

            string[] emailParts = emailToCheck.Split('@').ToArray();

            int symbolsBeforeAtSignLength = emailParts[0].Length;
            int symbolsAfterAtSignLength = emailParts[1].Length;

            if (symbolsBeforeAtSignLength - symbolsAfterAtSignLength >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
