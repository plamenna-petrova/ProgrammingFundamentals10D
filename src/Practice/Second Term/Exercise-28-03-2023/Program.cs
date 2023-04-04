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
            int miningCounter = 0;

            Dictionary<string, int> mineralDeposits = new Dictionary<string, int>();

            string key = string.Empty;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }

                miningCounter++;

                if (miningCounter % 2 == 0)
                {
                    mineralDeposits[key] += int.Parse(command);
                }
                else
                {
                    key = command;

                    if (!mineralDeposits.ContainsKey(key))
                    {
                        mineralDeposits.Add(key, 0);
                    }
                }

                // Gold - 1
                // 155 - 2
                // Silver - 3
                // 10 - 4
                // Copper - 5
                // 17 - 6

                // Gold - 155 - 0
                // Silver - 10 - 1
                // Copper - 17 - 2
            }

            foreach (KeyValuePair<string, int> mineralDepositEntry in mineralDeposits)
            {
                Console.WriteLine($"{mineralDepositEntry.Key} -> {mineralDepositEntry.Value}");
            }
        }
    }
}
