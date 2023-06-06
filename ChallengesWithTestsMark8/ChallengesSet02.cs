using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return !(num % 2 == 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();


        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length > str2.Length) ? str2.Length : str1.Length;

        }
        public int Sum(int[] numbers)
        {
            return numbers == null? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            return numbers?.Where(x => x % 2 == 0).Sum()??0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            //return numbers == null ? false : numbers.Sum() % 2 != 0; 
            if (numbers == null)
            {
                return false;
            }
            return numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number <= 0? 0 : number/2;
        }
    }
}
