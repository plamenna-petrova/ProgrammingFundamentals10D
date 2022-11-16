using System;

namespace IndexOfALetter
{
    public class Program
    {
        static void Main(string[] args)
        {
            string wordInput = Console.ReadLine();

            char[] wordCharactersArray = wordInput.ToCharArray();

            string lettersString = "";

            //StringBuilder stringBuilder = new StringBuilder();

            for (char c = 'a'; c <= 'z'; c++)
            {
                //stringBuilder.Append(c);
                lettersString += c;
            }

            //string lettersString = stringBuilder.ToString();

            char[] lettersCharactersArray = new char[lettersString.Length];

            // Copy character by character into array 
            for (int i = 0; i < lettersString.Length; i++)
            {
                lettersCharactersArray[i] = lettersString[i];
            }

            // the longer way

            for (int i = 0; i < wordCharactersArray.Length; i++)
            {
                char wordCharacter = wordCharactersArray[i];

                for (int j = 0; j < lettersCharactersArray.Length; j++)
                {
                    if (wordCharacter == lettersCharactersArray[j])
                    {
                        Console.WriteLine($"{lettersCharactersArray[j]} -> {j}");
                    }
                }
            }

            // another representation

            char[] arrayOfAlphabetLetters = new char[26];

            for (int i = 0; i < arrayOfAlphabetLetters.Length; i++)
            {
                arrayOfAlphabetLetters[i] = (char)('a' + i);
            }

            for (int i = 0; i < wordCharactersArray.Length; i++)
            {
                char wordCharacter = wordCharactersArray[i];

                for (int j = 0; j < arrayOfAlphabetLetters.Length; j++)
                {
                    if (wordCharacter == arrayOfAlphabetLetters[j])
                    {
                        Console.WriteLine($"{arrayOfAlphabetLetters[j]} -> {j}");
                    }
                }
            }

            // a way more concise solutions

            string anotherWord = Console.ReadLine();

            for (int i = 0; i < anotherWord.Length; i++)
            {
                char character = anotherWord[i];
                int value = anotherWord[i] - 97;
                Console.WriteLine("{0} -> {1}", character, value);
            }

            foreach (char letter in anotherWord)
            {
                Console.WriteLine($"{letter} -> {letter - 'a'}");
            }
        }
    }
}
