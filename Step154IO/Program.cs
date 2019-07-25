using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace Step154IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();
            File.WriteAllText(@"C:...", userInput);

            string readInput = File.ReadAllText(@"C:...");
            Console.WriteLine(readInput);
        }
    }
}
