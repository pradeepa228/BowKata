using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class BowlingScoreCalculator
    {
        public BowlingScoreCalculator()
        {

        }
        public int calculate_total(string inputString)
        {
            int sum = 0;
            string[] frames = inputString.Split(' ');
            foreach(var word in frames)
            {
                sum += word.Sum(c => c - '0');
                Console.WriteLine(word + " " + sum);
            }
            return sum;
        }
    }
}
