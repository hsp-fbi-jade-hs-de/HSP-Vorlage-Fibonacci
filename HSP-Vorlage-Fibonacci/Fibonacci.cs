using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSP_Vorlage_Fibonacci
{
    public class Program
    {
        public string FibonacciNumbers(int input)
        {

            // FibonacciCode hier
            throw new NotImplementedException();

            return fibonacciNumbers;
        }

        static void Main(string[] args)
        {
            Program prg = new Program();

            Console.WriteLine("Bitte geben sie den Wert ein wie weit die Fibonacci-Folge ausgegeben werden soll.");
            int input = Convert.ToInt32(Console.ReadLine());
            string fibonacciNumbers = prg.FibonacciNumbers(input);
            Console.WriteLine(fibonacciNumbers);

            Console.ReadKey();

        }
    }
}
