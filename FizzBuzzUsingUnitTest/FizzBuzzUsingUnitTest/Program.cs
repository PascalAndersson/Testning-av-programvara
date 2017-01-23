using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzUsingUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var fB = new FizzBuzzlib();
            int threeToFizz = 3;
            int fiveToBuzz = 5;

            //fB.ConvertThreeToFizz(threeToFizz);
            //fB.ConvertFiveToBuzz(fiveToBuzz);
            //fB.ConvertThreeAndFiveToFizzBuzz(threeToFizz, fiveToBuzz);
            fB.FizzBuzz();
        }
    }
}
