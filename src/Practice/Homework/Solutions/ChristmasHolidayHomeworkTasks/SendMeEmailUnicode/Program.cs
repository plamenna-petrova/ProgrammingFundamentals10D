using System;
using System.Linq;

namespace SendMeEmailUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailToCheck = Console.ReadLine();

            string[] emailParts = emailToCheck.Split('@').ToArray();

            string symbolsBeforeAtSign = emailParts[0];
            string symbolsAfterAtSign = emailParts[1];

            int symbolsBeforeAtSignSum = 0;

            foreach (var symbol in symbolsBeforeAtSign)
            {
                symbolsBeforeAtSignSum += (int) symbol;
            }

            int symbolsAfterAtSignSum = 0;

            foreach(var symbol in symbolsAfterAtSign)
            {
                symbolsAfterAtSignSum += (int) symbol;
            }

            if (symbolsBeforeAtSignSum - symbolsAfterAtSignSum >= 0)
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
