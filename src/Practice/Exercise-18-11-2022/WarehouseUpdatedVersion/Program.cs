using System;
using System.Linq;

namespace WarehouseUpdatedVersion
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = Console.ReadLine().Split().ToArray(); 

            long[] productQuantities = Console.ReadLine().Split().Select(long.Parse).ToArray();

            decimal[] productPrices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "done")
                {
                    break;
                }

                int productIndex = Array.IndexOf(productNames, commands[0]);

                string productNameCommand = commands[0];
                long productQuantityCommand = long.Parse(commands[1]);

                long productQuantity = 0;

                if (productIndex <= productQuantities.Length - 1)
                {
                    productQuantity = productQuantities[productIndex];
                }

                decimal productPrice = productPrices[productIndex];

                if (productQuantityCommand <= productQuantity)
                {
                    Console.WriteLine($"{productNameCommand} x {productQuantityCommand} " +
                        $"costs {Math.Round(productQuantityCommand * productPrice, 2):F2}");
                    productQuantities[productIndex] -= productQuantityCommand;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {productNameCommand}");
                }
            }
        }
    }
}
