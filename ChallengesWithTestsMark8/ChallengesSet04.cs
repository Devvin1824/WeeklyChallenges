using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int count = 0;
            
            foreach(int number in numbers)
            {
                if (number % 2 == 0)
                {
                    count += number;
                }
                else
                {
                    count -= number;
                }
            }
            return count;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> list = new List<string> { str1, str2, str3, str4 };
            string shortestString = list.OrderBy(x => x.Length).First();
            return shortestString.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int> { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool IsStringANumber(string input)
        {
            double result;
            bool confirmed = double.TryParse(input, out result);
            if(confirmed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int objCount = 0;
            for(int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullCount++;
                }
                else
                {
                    objCount++;
                }
            }
            if(nullCount > objCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            double numTotal = 0;
            double numCount = 0;
            if(numbers == null)
            {
                return 0;
            }
            foreach(double num in numbers)
            {
                if (num % 2 == 0)
                {
                    numTotal += num;
                    numCount++;

                }
            }
            double avg = numTotal / numCount;
            if(numCount == 0)
            {
                avg = 0;
            }
            return avg;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "number can not be negative");
            }
            int result = 1;
            while(number != 0)
            {
                result *= number;
                number--;
            }
            
            return result;
        }
    }
}
