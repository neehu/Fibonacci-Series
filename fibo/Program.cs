using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {

        int fibonacci(int number)
        {
            int sum;
            if (number <= 1)
            {
                return 1;
            }
            else
                sum = (fibonacci(number - 1) + fibonacci(number - 2));
            return sum;
        }
        static void Main(string[] args)
        {
            int finalNumber = 100, sum;
            Program execute = new Program();

            sum = execute.fibonacci(finalNumber);
            Console.WriteLine(Convert.ToString(sum));
            Console.ReadKey();
        }
    }
}
