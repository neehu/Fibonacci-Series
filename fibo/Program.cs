using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaciSeries
{
class FibonacciSeries
{
    int fibonacci(int input)
    {
        int calculatedLastterm;
        if (input==0)
        {
            return 0;
        }
        if (input == 1)
        {
            return 1;
        }
        else
            calculatedLastterm = (fibonacci(input - 1) + fibonacci(input - 2));
        return calculatedLastterm;
       }
       static void Main(string[] args)
       {
        int userinput = 10, calculatedLastterm;
        FibonacciSeries execute = new FibonacciSeries();
        calculatedLastterm = execute.fibonacci(userinput);
        Console.WriteLine(Convert.ToString(calculatedLastterm));
        Console.ReadKey();
       }
    }
}
