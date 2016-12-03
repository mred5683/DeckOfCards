using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards {
  public class Program {
    public static void Main() {
      for (int i = 0; i < 3; i++) {
      Menu();
      }
      Console.ReadKey(true);
    }

    public static void Menu() {

      //Console.WriteLine("How many decks would you like to use?? \n must be greater than 0");
      //var numberOfDecks = int.Parse(Console.ReadLine());

      var deckKeyValue = new Dictionary<int,string> {
        { 1, "AS "  },     { 2, "2S "  },     { 3, "3S "  },     { 4, "4S "  },     { 5, "5S "  },    { 6, "6S "  },
        { 7, "7S "  },     { 8, "8S "  },     { 9, "9S "  },     { 10, "10S" },     { 11, "JS " },    { 12, "QS " },
        { 13, "KS " },     { 14, "AC " },     { 15, "2C " },     { 16, "3C " },     { 17, "4C " },    { 18, "5C " },
        { 19, "6C " },     { 20, "7C " },     { 21, "8C " },     { 22, "9C " },     { 23, "10C" },    { 24, "JC " },
        { 25, "QC " },     { 26, "KC " },     { 27, "AH " },     { 28, "2H " },     { 29, "3H " },    { 30, "4H " },
        { 31, "5H " },     { 32, "6H " },     { 33, "7H " },     { 34, "8H " },     { 35, "9H " },    { 36, "10H" },
        { 37, "JH " },     { 38, "QH " },     { 39, "KH " },     { 40, "AD " },     { 41, "2D " },    { 42, "3D " },
        { 43, "4D " },     { 44, "5D " },     { 45, "6D " },     { 46, "7D " },     { 47, "8D " },    { 48, "9D " },
        { 49, "10D" },     { 50, "JD " },     { 51, "QD " },     { 52, "KD " },     { 53, "Joker" },  { 54, "Joker" }
      };

      //var forIteration = deckKeyValue.Count;

      //for (int i = 1; i < numberOfDecks; i++) {
      //  for (int j = 1; j <= forIteration; j++) {
      //    deckKeyValue.Add(deckKeyValue.Count + 1, deckKeyValue[j]);
      //  }
      //}

      //Create instance of random class, and variables to hold and modify based on deckKeyValue.Key 
      //inside of forloop. 

      var drawRandomCard = new Random();
      var randomAssignment = int.MaxValue;

      while (deckKeyValue.Count > 0) {
        //randomly generates which card is next, based on 5 card draw method. 
        for (var i = 0; i < 5; i++) {
          
          if (randomAssignment < int.MaxValue)
            deckKeyValue.Remove(randomAssignment);
          do {
            if (!deckKeyValue.Count.Equals(0)) {
              randomAssignment = drawRandomCard.Next(1, 55);
            }
            else if (deckKeyValue.Count.Equals(0)) {
              break;
            }
          } while (!deckKeyValue.Keys.Contains(randomAssignment));

          //pulls the random key and writes its value to the console.  

          if (deckKeyValue.Count != 0) {
            foreach (var item in deckKeyValue) {
              if (randomAssignment != item.Key)
                continue;
              Console.Write(item.Value);
              Console.Write("  ");
            }
          }
        }
        Console.WriteLine();
      }
    }
  }
}



