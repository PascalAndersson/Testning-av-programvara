using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzlib
    {
        public string ConvertThreeToFizz(int threeToFizz)
        {
            //string fizz = threeToFizz.ToString();

            //Refactored
            string fizz = "Fizz";
            for (threeToFizz = 1; threeToFizz <= 100; threeToFizz++)
            {
                if (threeToFizz % 3 == 0)
                    Console.WriteLine(fizz);
                else
                    Console.WriteLine(threeToFizz);
            }
            return fizz;
        }

        public string ConvertFiveToBuzz(int fiveToBuzz)
        {
            //string buzz = fiveToBuzz.ToString();
            string buzz = "Buzz";
            for (fiveToBuzz = 1; fiveToBuzz <= 100; fiveToBuzz++)
            {
                if (fiveToBuzz % 5 == 0)
                    Console.WriteLine(buzz);
                else
                    Console.WriteLine(fiveToBuzz);
            }
            return buzz;
        }

        public string ConvertThreeAndFiveToFizzBuzz(int threeToFizz, int fiveToBuzz)
        {
            //string fizz = threeToFizz.ToString();
            //string buzz = fiveToBuzz.ToString();

            string fizz = "Fizz";
            string buzz = "Buzz";
            string fizzBuzz = fizz + buzz;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(fizzBuzz);
                else
                    Console.WriteLine(i);
            }
            return fizzBuzz;
        }

        public void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
