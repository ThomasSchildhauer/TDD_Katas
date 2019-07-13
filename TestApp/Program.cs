using Kata_FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Console.WriteLine("Input a number");

            var number = Console.ReadLine();

            int.TryParse(number, out int inputNumber);

            var actual = fizzBuzz.DetermineFizzBuzz(inputNumber);

            Console.WriteLine($"The Result is: {actual}");

            Console.ReadKey();
        }
    }
}
