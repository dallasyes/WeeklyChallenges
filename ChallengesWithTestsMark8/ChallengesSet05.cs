using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber += 1;
            while (startNumber % n != 0)
            {
                startNumber++;
            }

            return startNumber;

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            if (numbers.Length == 0)
            {
                return false;
            }
            
            for (int i = 0; i < numbers.Length-1; i++)
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
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && i != numbers.Length - 1)
                {
                    sum += numbers[i + 1];
                }
                    
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return string.Empty;
            }
            var cleanWords = new List<string>();
            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    cleanWords.Add(word.Trim());
                }
            }

            if (cleanWords.Count == 0)
            {
                return string.Empty;
            }

            return string.Join(" ", cleanWords) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return Array.Empty<double>();
            }
            var res = new List<double>();
            for (var i = 3; i < elements.Count; i += 4)
            {
                    res.Add(elements[i]);
                
            }

            return res.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            var set = new HashSet<int>();
            foreach (var number in nums)
            {
                var diff = targetNumber - number;
                if (set.Contains(diff))
                {
                    return true;
                }

                set.Add(number);
            }

            return false;
        }
    }
}
