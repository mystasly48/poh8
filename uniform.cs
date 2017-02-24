using System;
using System.Linq;

public class Program {
  public static void Main() {
    string[] WeakToStrong = { "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A", "2" };
    string[] cards = Console.ReadLine().Split(' ');
    int[] ranks = new int[cards.Length];
    int cardIndex = 0;
    int currentRankIndex = 0;
    string currentCard = "2";
    int currentRank = 1;
    while (currentRank < cards.Length) {
      if (currentCard == "2" || Array.IndexOf(WeakToStrong, currentCard) < Array.IndexOf(WeakToStrong, cards[cardIndex])) {
        ranks[currentRankIndex] = currentRank;
        currentRank++;
        currentRankIndex++;
        currentCard = cards[cardIndex];
        cards[cardIndex] = "";
      }

      if (cardIndex >= cards.Length) {
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
