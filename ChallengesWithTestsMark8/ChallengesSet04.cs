using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = numbers.Sum(x => x % 2 == 0 ? x : -x);
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new List<string>{str1, str2, str3, str4};
            return strings.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new List<int>{number1, number2, number3, number4};
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var lengths = new List<int>{sideLength1, sideLength2, sideLength3};
            var orderedlengths = lengths.OrderBy(x => x).ToList();
            return (orderedlengths[2] - orderedlengths[1] - orderedlengths[0] > 0);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Count(o => o == null) > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            return numbers.Where(n=> n % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Factorial does not exist for negative numbers");
            int result = 1;
            while (number > 0)
            {
                result *= number;
                number--;
            }

            return result;
        }
    }
}
