using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return (vals == null) ? false : vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            
            var sumOfOdds = numbers.Where(x => x % 2 != 0).Sum();

            return sumOfOdds % 2 != 0;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(x => char.IsUpper(x)) && password.Any(x => char.IsLower(x)) && password.Any(x => char.IsDigit(x));
        }

        public char GetFirstLetterOfString(string val)
        {
            char firstLetter = val[0];
            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            char lastLetter = val[val.Length - 1];
            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0) ? 0 : dividend/divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1, 50).Select(x => x * 2 - 1).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
