using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class BowlingScoreCalculator
    {
        public BowlingScoreCalculator()
        {

        }
        public int Calculate_total(string inputString)
        {
            int sum = 0;
            int iterartor = 0;
            bool checkSpare = false;
            bool checkStrike = false;
            bool continousStrike = false;
            Char spareValue = '/';
            Char strikeValue = 'X';

            //Replacing the miss '-' with '0'
            inputString = inputString.Replace('-', '0');
           
            //Splitting the frames using ' '
            string[] frames = inputString.Split(' ');

            foreach (var tries in frames)
            {
                iterartor++;

                if (tries.Contains(spareValue))
                {
                    //If tries contains spare, Sum should be added by 10
                    
                    sum += 10;
                    
                    if (checkSpare == true)
                    {
                        char temp = tries[0];
                        int number = temp-'0';
                        sum += number;
                    }
                    //Making checkSpare to true to add the score of next try
                   checkSpare = true;

                } else if (tries.Contains(strikeValue)) {
                    //Tries has strike
                    sum += 10;

                    if (checkStrike == true)
                    {
                        if (continousStrike == true && iterartor < 10)
                        {
                            // If all are strike, no need to add the sum by 20 in the last frame
                            sum += 20;
                        }
                        else
                        {
                            sum += 10;
                            continousStrike = true;
                        }
                    }
                    if (iterartor < 10)
                    {
                        checkStrike = true;
                    }
                    
                } else {
                    int number = Int32.Parse(tries);
                    
                    while (number > 0)
                    {
                        if (checkStrike == true)
                        {
                            if(continousStrike == true)
                            {
                                sum += number / 10;
                                continousStrike = false;
                            }
                            sum += number / 10;
                            sum += number % 10;
                            checkStrike = false;
                            
                        }
                        //If no spare or no strike, simply add the two numbers of the try
                        sum += number % 10;
                        number /= 10;
                        

                        // Indicates Previous spare, adding the score of next try
                        if (checkSpare == true)
                        {
                            sum += number;
                            checkSpare = false;
                            
                        }
                    }
                } 
             }
            return sum;
        }
    }
}
