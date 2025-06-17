using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null || vals.Length == 0)
            {
                return false;
            }

            return vals.Any(v => v == false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return false;
            }

            int sumOfOdds = numbers.Where(n => n % 2 != 0).Sum();
            return sumOfOdds % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);

            return hasUpper && hasLower && hasDigit;
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val)) throw new ArgumentException("String cannot be null or empty", nameof(val));
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val)) throw new ArgumentException("String cannot be null or empty", nameof(val));
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length < 2) return 0;
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();
            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null) return;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    words[i] = words[i].ToUpper();
                }
            }
        }
    }
}
