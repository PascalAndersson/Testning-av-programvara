using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck_TDD
{
class CardList
    {
        public static List<Rank> rank = new List<Rank>()
        {
            new Rank {CompareInput = "a", Card = "ace" },
            new Rank {CompareInput = "2", Card = "two" },
            new Rank {CompareInput = "3", Card = "three" },
            new Rank {CompareInput = "4", Card = "four" },
            new Rank {CompareInput = "5", Card = "five" },
            new Rank {CompareInput = "6", Card = "six" },
            new Rank {CompareInput = "7", Card = "seven" },
            new Rank {CompareInput = "8", Card = "eight" },
            new Rank {CompareInput = "9", Card = "nine" },
            new Rank {CompareInput = "10", Card = "ten" },
            new Rank {CompareInput = "j", Card = "jack" },
            new Rank {CompareInput = "q", Card = "queen" },
            new Rank {CompareInput = "k", Card = "king" },
        };

        public static List<Color> color = new List<Color>()
        {
            new Color {Input = "h", Card = "hearts" },
            new Color {Input = "c", Card = "clubs" },
            new Color {Input = "d", Card = "diamonds" },
            new Color {Input = "s", Card = "spades" }
        };
    }

    internal class Color
    {
        public string Input { get; set; }
        public string Card { get; set; }
    }

    internal class Rank
    {
        public string CompareInput { get; set; }
        public string Card { get; set; }
    }
}
