using System;
using System.Linq;

namespace Warehouse
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
                string command = Console.ReadLine();

                if (command == "done")
                {
                    break;
                }

                int productNameIndex = Array.IndexOf(productNames, command);

                long productQuantity = productQuantities[productNameIndex];

                decimal productPrice = productPrices[productNameIndex];

                string productName = command;

                Console.WriteLine($"{productName} costs: {productPrice}; Avaialable quantity: {productQuantity}");
            }
        }
    }
}
