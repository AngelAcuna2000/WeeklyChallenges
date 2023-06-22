using MathNet.Numerics;
using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Sum(x => x % 2 == 0 ? x : -x);
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new string[] { str1, str2, str3, str4 };
            return strings.Min(s => s.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new int[] { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int a, int b, int c)
        {
            int min = Math.Min(a, Math.Min(b, c));
            int max = Math.Max(a, Math.Max(b, c));
            int mid = a + b + c - min - max;
            return min + mid > max;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }
         
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Length > 0 && objs.Count(x => x == null) / (double)objs.Length > 0.5;
        }

        public double AverageEvens(int[] numbers)
        {
            // evens stores either null if numbers is null or an array of the even nums in numbers. 
            var evens = numbers?.Where(x => x % 2 == 0).ToArray();
            // If evens is null or the array is empty because there are no even numbers, 0 will be returned. Otherwise,
            // it will find the average of the even numbers.
            return evens?.Length > 0 ? evens.Average() : 0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }
            
            return (int)SpecialFunctions.Factorial(number);
        }
    }
}
