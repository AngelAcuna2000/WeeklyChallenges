using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            Collection<string> collection = new Collection<string>(words.ToList());
            StringComparison comparison = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;

            foreach (string element in collection)
            {
                if (element != null && element.Contains(word, comparison))
                {
                    return true;
                }
            }

            return false;
        }



        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (charCount.ContainsKey(str[i]))
                {
                    charCount[str[i]]++;
                }
                else
                {
                    charCount.Add(str[i], 1);
                }
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (charCount[str[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }


        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int maxCount = 1;
            int currentCount = 1;
            int currentNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == currentNumber)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }

                    currentNumber = numbers[i];
                    currentCount = 1;
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }

            return maxCount;
        }


        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n <= 0 || n > elements.Count)
            {
                return new double[0];
            }

            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

    }
}
