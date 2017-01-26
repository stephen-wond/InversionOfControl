using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintingService printer = new PrintingService(new DontPrintWords());
            Console.WriteLine(printer.Alphabet() + "\n");
            Console.WriteLine(printer.RandomText(3) + "\n");
            Console.WriteLine(printer.RandomText(2) + "\n");
            Console.WriteLine(printer.Repeater("hello!") + "\n\n");

            printer = new PrintingService(new DoPrintWords());
            Console.WriteLine(printer.Alphabet() + "\n");
            Console.WriteLine(printer.RandomText(3) + "\n");
            Console.WriteLine(printer.RandomText(2) + "\n");
            Console.WriteLine(printer.Repeater("hello!") + "\n");

            Console.ReadKey();
        }
    }
}
