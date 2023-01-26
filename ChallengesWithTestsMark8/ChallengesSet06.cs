using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if(string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase == true)
            {
                word = word.ToLower(); 
                List<string> lc = words.Select(x => x.ToLower()).ToList();  
                containsWord = lc.Contains(word);
            }
            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 2 || num == 3 || num == 5 || num == 7)
            {
                return true;
            }
            else if ( num == 1 || num < 0)
            {
                return false;
            }
            else if (num % 2 != 0 && num % 3 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uIndex;
            for (int i =0; i < str.Length; i++)
            {
                uIndex = true;
                for(int j =0; j< str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uIndex = false;
                    }
                }

                if (uIndex == true)
                {
                    index = i;
                }
            }

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 0;
            for (int i = 0; i <numbers.Length; i++)
            {
                int currentCount = 1;

                for(int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();

            if(elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }

            for(var i = n-1; i < elements.Count; i+= n)
            {
                nthElement.Add(elements[i]);
            }

            return nthElement.ToArray();

        }
    }
}
