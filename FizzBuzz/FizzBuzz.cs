using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_FizzBuzz
{
    public class FizzBuzz
    {
        public string DetermineFizzBuzz(int number)
        {
            if (number != 0 && number % 5 == 0 && number % 3 == 0)
            {
                return "FizzBuzz";
            }
            if (number != 0 && number % 3 == 0)
            {
                return "Fizz";
            }
            if (number != 0 && number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}
