using System;

namespace EmptyCashReceipt
{
    // Methods Exercises Task #1
    public class Program
    {
        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 20));
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to" + new string('_', 10));
            Console.WriteLine("Received by" + new string('_', 9));
        }

        static void PrintReceiptFooter()
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine($"\u00a9 BG");
        }

        static void PrintCashReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }
 
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            PrintCashReceipt();
        }
    }
}
