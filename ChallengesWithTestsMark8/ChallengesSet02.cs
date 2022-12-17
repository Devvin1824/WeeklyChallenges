using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool isTrue = false;
            List<string> list = new List<string> {"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"};
            List<char> charList = list.SelectMany(str => str.ToCharArray()).ToList();
            
            foreach (char letter in charList)

            {
                if (c == letter)
                {
                    isTrue = true;
                    
                }
                /*
                else if (Char.ToUpper(c) == Char.ToUpper(letter)) // code for if the List 'list' was only lowercase a-z 
                {
                    isTrue = true;
                }
                */
            }
            return isTrue;
            
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int count = 0;
            foreach (string element in vals)
            {
                count++;
            }
            if (count % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
        
            double min = double.MaxValue;
            double max = double.MinValue;
            foreach (double number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
            
            
            return max + min;
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            char[] array1 = str1.ToCharArray();
            char[] array2 = str2.ToCharArray();
            int sum1 = 0;
            int sum2 = 0;
            foreach (char item in array1)
            {
                sum1++;
            }
            foreach(char item in array2)
            {
                sum2++;
            }
            if (sum1 < sum2)
            {
                return sum1;
            }
            else
            {
                return sum2;
            }

        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            
            return sum;

        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            
            
            int sum = 0;
            foreach (int item in numbers)
            {
                if (item % 2 != 0)
                {
                    sum += item;
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        
        public long CountOfPositiveOddsBelowNumber(long number)
        {

            if (number < 0)
            {
                return 0;
            }

            long newNum = 0;

            if (number % 2 == 0)
            {
              number --;
              while (number >= 1)
              {
                    number = number - 2;
                    newNum++;
              }
              return newNum;
            }
            else
            {
              number -= 2;
              while (number >= 1)
              {
                    number = number - 2;
                    newNum++;
              }
              return newNum;
            }
        }
    }
}
