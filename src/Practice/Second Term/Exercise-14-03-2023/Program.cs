using System;
using System.Collections.Generic;

namespace Exercise_14_03_2023
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            phonebook["John Smith"] = "+1-555-8976";
            phonebook["Lisa Smith"] = "+1-555-1234";
            phonebook["Sam Doe"] = "+1-555-5030";
            phonebook["Ivan"] = "+359-899-555-592";
            phonebook["Ivan"] = "+359-2-981-9819";

            phonebook.Remove("John Smith");

            foreach (KeyValuePair<string, string> phonebookEntry in phonebook)
            {
                Console.WriteLine($"{phonebookEntry.Key} --> {phonebookEntry.Value}");
            }

            foreach (string key in phonebook.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (string value in phonebook.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(string.Join(" | ", phonebook.Keys));
            Console.WriteLine(string.Join(" | ", phonebook.Values));

            string[] words = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> wordsOccurrences = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordsOccurrences.ContainsKey(word))
                {
                    wordsOccurrences[word]++;
                }
                else
                {
                    wordsOccurrences[word] = 1;
                }
            }

            List<string> oddWordOccurrencesResults = new List<string>();

            foreach (KeyValuePair<string, int> wordOccurrencesPair in wordsOccurrences)
            {
                if (wordOccurrencesPair.Value % 2 != 0)
                {
                    oddWordOccurrencesResults.Add(wordOccurrencesPair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddWordOccurrencesResults));
        }
    }
}
