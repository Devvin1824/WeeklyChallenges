using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            bool stopLoop = true;
            int magicNumber = 0;
            while (stopLoop)
            {
                startNumber++;
                if (startNumber % n == 0)
                {
                    magicNumber = startNumber;
                    stopLoop = false;
                }
            }
            return magicNumber;    
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(var bus in businesses)
            {
                if(bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if(numbers == null || numbers.Any() == false)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if ( words == null)
            {
                return "";
            }
            string sentence = "";
            foreach(string item in words)
            {
                if(item.Trim().Length > 0) 
                {
                    sentence += item.Trim() + " ";
                }
            }

            if (sentence.Length == 0)
            {
                return "";
            }
            return sentence.Trim() + ".";
            
          

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return new double[] { };
            }
            var newList = new List<double>();
            for(int i = 3; i < elements.Count; i+=4)
            {
                newList.Add(elements[i]);
            }
            return newList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
