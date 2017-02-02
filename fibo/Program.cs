using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaciSeries
{
    class Fibonacci
    {
        int fibonacci(int input)
        {
            int Lastterm;
            if (input == 0)
            {
                return 0;
            }
            if (input == 1)
            {
                return 1;
            }
            else
                Lastterm = (fibonacci(input - 1) + fibonacci(input - 2));
            return Lastterm;
        }
        static void Main(string[] args)
        {
            int userinput = 10, Lastterm;
            Fibonacci execute = new Fibonacci();
            Lastterm = execute.fibonacci(userinput);
            Console.WriteLine(Convert.ToString(Lastterm));
            Console.ReadKey();
        }
    }
}
