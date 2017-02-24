using System;
using System.Linq;

public class Hello {
  public static void Main() {
    string[] WeakToStrong = { "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A", "2" };
    string[] cards = Console.ReadLine().Split(' ');
    int[] ranks = new int[cards.Length];
    int currentRankIndex = 0;
    string currentCard = "2";
    int currentRank = 1;
    for (int cardIndex = 0, currentRankIndex = 0, currentRank = 1, currentCard = "2"; currentRank < cards.Length; cardIndex) {
      if (currentCard == "2") {
        ranks[currentRankIndex] = currentRank;
        currentRank++;
        currentRankIndex++;
        currentCard = cards[cardIndex];
        cards[i] = "";
      } eles {

      }
    }
  }
}