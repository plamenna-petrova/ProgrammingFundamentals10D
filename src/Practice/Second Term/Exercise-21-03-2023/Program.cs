using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Dictionaries
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isCommandsSendingActive = true;

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (isCommandsSendingActive)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                switch (commands[0])
                {
                    case "A":
                        string nameToAdd = commands[1];
                        string phoneNumberToAdd = commands[2];
                        if (phonebook.ContainsKey(nameToAdd))
                        {
                            phonebook[nameToAdd] = phoneNumberToAdd;
                        }
                        else
                        {
                            phonebook.Add(nameToAdd, phoneNumberToAdd);
                        }
                        break;
                    case "S":
                        string searchedName = commands[1];
                        if (phonebook.ContainsKey(searchedName))
                        {
                            Console.WriteLine($"{searchedName} -> {phonebook[searchedName]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {searchedName} does not exist.");
                        }
                        break;
                    case "END":
                        isCommandsSendingActive = false;
                        break;
                }
            }
        }
    }
}
