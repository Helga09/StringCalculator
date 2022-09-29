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
        private int Sum(int[] arrayNumbers)
        {
            int sum = 0;
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                try
                {
                    if (arrayNumbers[i] < 0)
                    {
                        throw new InvalidOperationException("Negatives not allowed: " + arrayNumbers[i]);
                    }
                    else
                    {
                        sum += arrayNumbers[i];
                    }
                }
                catch (InvalidOperationException ex)
                {
                    _ = ex.Message;
                }
            }
            return sum;
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
            
            return Sum(arrayNumbers);
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
