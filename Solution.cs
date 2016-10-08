using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringsAndNumbers
{
    class Solution
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            char[] inputArray = input.ToCharArray();
            

            var mostPopular = inputArray
                .GroupBy(x => x)
                .OrderByDescending(g => g.Count())
                .Distinct()
                .ToArray();
            

            List<char> ls = new List<char>();

            foreach (var item in mostPopular)
            {
                ls.Add( item.Key);
            }


            
            string newStr = new string(input.Select(r => (r == ls[0] ? '9' : r))
                                            .Select(r => (r == ls[1] ? '8' : r))
                                            .Select(r => (r == ls[2] ? '7' : r))
                                            .Select(r => (r == ls[3] ? '6' : r))
                                            .Select(r => (r == ls[4] ? '5' : r))
                                            .Select(r => (r == ls[5] ? '4' : r))
                                            .Select(r => (r == ls[6] ? '3' : r))
                                            .Select(r => (r == ls[7] ? '2' : r))
                                            .Select(r => (r == ls[8] ? '1' : r))
                                            .Select(r => (r == ls[9] ? '0' : r))
                                            .ToArray());

            string digitsOnly = Regex.Replace(newStr, "[^0-9]", " ");

            digitsOnly = Regex.Replace(digitsOnly, @"\s+", " ");
            

            var numbers = digitsOnly.Split(' ').ToList();
            

            BigInteger sum = 0;

            foreach (var item in numbers)
            {
                BigInteger a = BigInteger.Parse(item);
                sum += a;
            }

            Console.WriteLine(sum);
            

        }
    }
}
