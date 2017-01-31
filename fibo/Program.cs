using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {

        int fibonacci(int input)
        {
            int fibonacciterm;
            if (input==0)
            {
                return 0;
            }
            if (input == 1)
            {
                return 1;
            }
            else
                fibonacciterm = (fibonacci(input - 1) + fibonacci(input - 2));
            return fibonacciterm;
        }
        static void Main(string[] args)
        {
            int userinput = 10, fibonaciterm;
            Program execute = new Program();
            fibonaciterm = execute.fibonacci(userinput);
            Console.WriteLine(Convert.ToString(fibonaciterm));
            Console.ReadKey();
        }
    }
}
