using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CardDeck_TDD
{
    class Runtime
    {
        public string ConvertInputToCard(string cardInput)
        {
            #region 1
            //bool typeLoop = false;

            //while (!typeLoop)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Hearts - (h)");
            //    Console.WriteLine("Diamonds - (d)");
            //    Console.WriteLine("Clubs - (c)");
            //    Console.WriteLine("Spades - (s)");
            //    Console.Write("\nEnter the type of card (h)/(d)/(c)/(s): ");
            //    string typeOfCard = Console.ReadLine().ToUpper();

            //    if (typeOfCard.Contains("0") || typeOfCard.Contains("1") || typeOfCard.Contains("2") || typeOfCard.Contains("3") ||
            //    typeOfCard.Contains("4") || typeOfCard.Contains("5") || typeOfCard.Contains("6") ||
            //    typeOfCard.Contains("7") || typeOfCard.Contains("8") || typeOfCard.Contains("9"))
            //    {
            //        Console.WriteLine("Type cannot contain numbers...");
            //        Console.ReadLine();
            //    }
            //    else typeLoop = true;
            //}

            //bool cardNumber = false;

            //while(!cardNumber)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Ace - (a)");
            //    Console.WriteLine("King - (k)");
            //    Console.WriteLine("Queen - (q)");
            //    Console.WriteLine("Jack - (j)");
            //    Console.WriteLine("Number 2-10");
            //    Console.Write("Enter the number of the card:");
            //}
            #endregion

            try
            {
                char[] charArray = cardInput.ToLower().ToCharArray();

                string rank = charArray[0].ToString();
                string color = charArray[1].ToString();

                if (charArray.Length > 2 && !cardInput.Contains("10h") && !cardInput.Contains("10s") && !cardInput.Contains("10d") && !cardInput.Contains("10c"))
                    throw new Exception("\nInvalid input.");

                if (cardInput.Length > 2 && cardInput.Length < 4)
                {
                    rank += charArray[1].ToString();
                    color = charArray[2].ToString();
                }            

                foreach (var card in CardList.rank)
                {
                    if (rank == card.CompareInput)
                    {
                        rank = card.Card;
                        break;
                    }
                }
                foreach (var card in CardList.color)
                {
                    if (color == card.Input)
                    {
                        color = card.Card;
                        break;
                    }
                }

                if (rank == charArray[0].ToString() || color == charArray[1].ToString())
                    throw new Exception("\nInvalid input.");
                else
                    return rank + " of " + color;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return cardInput;
        }

        #region CreateTextFile
        public string CreateTextFile(string searchPath)
        {
            //searchPath = @"C:\Users\ander\Documents\Testning av programvara\Labbar\CardDeck_TDD\testlogg.txt";
            if (!File.Exists(searchPath))
                File.Create(searchPath);
            return searchPath;
        }
        #endregion
    }
}