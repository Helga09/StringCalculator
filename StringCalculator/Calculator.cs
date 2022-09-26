using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    class Calculator
    {
        private int[] Split(string numbers)
        {
            string delimiter = numbers.Substring(2, 1);
            numbers = numbers.Substring(numbers.IndexOf("\n"));
            int[] arrayNumbers = numbers.Split(delimiter.ToCharArray()).Select(x => int.Parse(x)).ToArray();
            return arrayNumbers;
        }
        private int CalculateSum(string numbers)
        {
            int[] arrayNumbers;
            if (numbers.Contains("//"))
            {
                arrayNumbers = Split(numbers);
            }
            else
            {
                arrayNumbers = numbers.Split(',', '.', '\n').Select(x => int.Parse(x)).ToArray();
            }
            int sum = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                sum += arrayNumbers[i];
            }
            return sum;
        }

        public int Add(string numbers)
        {
             if(numbers=="" || numbers == null)
             {
                 return 0;
             }
             else
             {
                return CalculateSum(numbers);
            }
        }
    }
}
