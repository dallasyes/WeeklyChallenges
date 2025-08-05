using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null)
            {
                return false;
            }
            if (ignoreCase)
            {
                foreach (var w in words)
                {
                    if (string.Equals(w, word, StringComparison.OrdinalIgnoreCase))
                        return true;
                }

                return false;
            }
            return words.Contains(word);
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            if (num == 2)
            {
                return true;
            }

            if (num % 2 == 0)
            {
                return false;
            }

            for (var i = 3; (i * i) < num; i += 2)
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
            if (str == null)
            {
                return -1;
            }
            var charCount = new Dictionary<char, int>();
            foreach (var c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            for (var i = str.Length - 1; i >= 0; i--)
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
            var counts = new List<int>();
            var count = 1;
            for (var i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count ++;
                    counts.Add(count);
                }
                else
                {
                    count = 1;
                }

            }

            return counts.Max();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return Array.Empty<double>();
            }
            var result = new List<double>();
            for (var i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
