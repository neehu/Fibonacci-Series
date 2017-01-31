using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaciSeries
{
    class Program
    {

        int fibonacci(int input)
        {
            int lastterm;
            if (input==0)
            {
                return 0;
            }
            if (input == 1)
            {
                return 1;
            }
            else
                lastterm = (fibonacci(input - 1) + fibonacci(input - 2));
            return lastterm;
        }
        static void Main(string[] args)
        {
            int userinput = 10, lastterm;
            Program execute = new Program();
            lastterm = execute.fibonacci(userinput);
            Console.WriteLine(Convert.ToString(lastterm));
            Console.ReadKey();
        }
    }
}
