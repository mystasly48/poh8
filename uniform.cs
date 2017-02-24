using System;
using System.Linq;

public class Program {
  public static void Main() {
    string[] WeakToStrong = "3,4,5,6,7,8,9,10,J,Q,K,A,2".Split(',');
    string[] cards = Console.ReadLine().Split(' ');
    int[] ranks = new int[cards.Length];
    int cardIndex = 0;
    string currentCard = "2";
    int currentRank = 1;
    int lastLeftIndex = -1;
    while (currentRank <= cards.Length) {
      if (lastLeftIndex == cardIndex || currentCard == "2" || Array.IndexOf(WeakToStrong, currentCard) < Array.IndexOf(WeakToStrong, cards[cardIndex])) {
        if (cards[cardIndex] == "") {
          int i = cardIndex;
          while (cards[i] == "") {
            if (i + 1 >= cards.Length) {
              i = 0;
            } else {
              i++;
            }
          }
          cardIndex = i;
        }
        lastLeftIndex = cardIndex;
        ranks[lastLeftIndex] = currentRank;
        currentRank++;
        currentCard = cards[cardIndex];
        cards[cardIndex] = "";
      }

      if (cardIndex+1 >= cards.Length) {
        cardIndex = 0;
      } else {
        cardIndex++;
      }
    }

    foreach (var i in ranks) {
      Console.WriteLine(i);
    }
  }
}
