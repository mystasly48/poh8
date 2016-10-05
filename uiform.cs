using System;

public class Hello {
  var WeakToStrong = new string[] { "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A", "2" };
  var CardsCount = 52;
  public static void Main() {
    var cards = Console.ReadLine().Split(' ');
    var cardsRank = new int[CardsCount];
    var currentRank = 0;
    var currentCard = "";

    cardsRank[0] = currentRank;
    currentCard = cards[0];

    while (currentRank != 52) {
      if (currentCard == "2") currentCard = "";
      if (currentCard == "") {
        var index = GetIndex(cards, 
        

      for (int i = 0; i < CardsCount; i++) {
        
      }
    }
  }
  
  public static int GetIndex(string[] array, string word) {
    var index = Array.IndexOf(array, word);
    return index;
  }
}