using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck_TDD
{
    class Menu
    {
        public void StartMenu()
        {
            var run = new Runtime();
            var test = new ModuleTesting();

            bool startMenuLoop = false;
            while (!startMenuLoop)
            {
                try
                { 
                Console.Clear();
                Console.WriteLine("(1) - Start input program");
                Console.WriteLine("(2) - Start tests");
                Console.WriteLine("(3) - Exit");
                Console.Write("\nChoice: ");
                int input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Input: ");
                            string cardInput = Console.ReadLine().ToLower();
                            Console.WriteLine(run.ConvertInputToCard(cardInput));
                            Console.ReadKey();
                            break;
                        case 2:
                            test.StartTest();
                            break;
                        case 3: startMenuLoop = true; break;
                        default: throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                    Console.ReadKey();
                }
            }
        }
    }
}
