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
        public int calculate_total(string inputString)
        {
            int sum = 0;
            int iterartor = 0;
            inputString = inputString.Replace('-', '0');
            bool checkSpare = false;
            bool checkStrike = false;
            bool contiStrike = false;
            

            string[] frames = inputString.Split(' ');
            foreach (var tries in frames)
            {
                iterartor++;
                Char spareValue = '/';
                Char strikeValue = 'X';


                if (tries.Contains(spareValue))
                {
                    //Console.WriteLine("Contains Spare");
                    sum = sum + 10;
                    checkSpare = true;
                } else if (tries.Contains(strikeValue)) {
                    Console.WriteLine(iterartor + "iterartor");
                    sum = sum + 10;
                    if (checkStrike == true)
                    {
                        if (contiStrike == true && iterartor < 10)
                        {
                            sum = sum + 20;
                        }
                        else
                        {
                            sum = sum + 10;
                            contiStrike = true;
                        }
                    }
                    if (iterartor < 10)
                    {
                        checkStrike = true;
                    }
                    
                } else {
                    int number = Int32.Parse(tries);
                    //Console.WriteLine("converted number:" + number);
                    while (number > 0)
                    {
                        if (checkStrike == true)
                        {
                            // Console.WriteLine("Strike" + checkStrike); 
                            if(contiStrike == true)
                            {
                                sum += number / 10;
                                contiStrike = false;
                            }
                            sum += number / 10;
                            sum += number % 10;
                            checkStrike = false;
                            
                        }

                        sum += number % 10;
                        number /= 10;

                        if (checkSpare == true)
                        {
                            Console.WriteLine("Spare" + checkSpare); 
                            sum = sum + number;
                            checkSpare = false;
                            
                        }
                    }
                    
                } 
                Console.WriteLine(tries + " " + sum);
            }
            return sum;
        }
    }
}
