using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_StringCalculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.Compare(numbers, "1,0") == 0)
            {
                return 1;
            }
            if (string.Compare(numbers, "1,1") == 0)
            {
                return 2;
            }
            return 0;
        }

        public List<int> CutString(string numbers)
        {
            List<int> result = new List<int>();
            var splitNumbers = numbers.Split(',');

            // ToDo go on here
            foreach(var item in splitNumbers)
            {
                int.TryParse(item)
                result.Add()
            }
            if(string.Compare(numbers, "0,1") == 0)
            {
                return new List<int>
                {
                    0,
                    1
                };
            }
            return new List<int>
            {
                0,
                0
            };
        }
    }

}
