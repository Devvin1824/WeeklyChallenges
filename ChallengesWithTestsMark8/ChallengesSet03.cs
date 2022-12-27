using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool value in vals)
            {
                if (value == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            
            int answer = 0;
            foreach (int value in numbers)
            {
                if (value % 2 != 0)
                {
                    answer += value;
                }
            }
            if (answer % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //bool upper = false;
            //bool lower = false;
            //bool number = false;
            //for (int i = 0; i < password.Length; i++)
            //{
            //    if (char.IsNumber(password[i]))
            //    {
            //        number = true;
            //    }
            //    else if (char.IsUpper(password[i]))
            //    {
            //        upper = true;
            //    }
            //    else if (char.IsLower(password[i]))
            //    {
            //        lower = true;
            //    }
            //}
            //if (number == true && upper == true && lower == true)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //return password.Contains(password.ToUpper().ToLower().) ? true : false;
            bool hasNumber = password.Any(x => char.IsDigit(x));
            bool hasLower = password.Any(x => char.IsLower(x));
            bool hasUpper = password.Any(x => char.IsUpper(x));
            if (hasNumber == true && hasLower == true && hasUpper == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }
        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int index = 0;
            int[] oddsArray = new int[50];
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddsArray[index] = i;
                    index++;
                }
            }
            return oddsArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null)
            {
                return;
            }
            
            
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
