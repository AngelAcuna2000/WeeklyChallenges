using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return startNumber + (n - (startNumber % n));        
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            var i = 0;
            bool inAscendingOrder = true;
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            
            while (i < numbers.Length - 1 && inAscendingOrder)
            {
                inAscendingOrder = numbers[i] <= numbers[i + 1] ? true : false;
                i++;
            }
            return inAscendingOrder;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var numsAfterEvens = new int[] { };
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Array.Resize(ref numsAfterEvens, numsAfterEvens.Length + 1);
                    numsAfterEvens[numsAfterEvens.Length - 1] = numbers[i + 1];
                }
            }
            return numsAfterEvens.Sum();
        }

            public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            var sentence = string.Join(" ", words.SelectMany(w => w.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));

            return sentence == "" ? "" : sentence + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var fourthElements = new double[] { };
            if (elements == null || elements.Count == 0)
            {
                return new double[] { };
            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % 4 == 0)
                {
                    Array.Resize(ref fourthElements, fourthElements.Length + 1);
                    fourthElements[fourthElements.Length - 1] = elements[i];
                }
            }
            return fourthElements;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum = nums[i] + nums[j];
                    if (sum == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
