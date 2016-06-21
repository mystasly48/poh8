using System;

public class Hello {
  public static void Main() {
    var price = int.Parse(Console.ReadLine());
    var point = price / 100;
    var result = point;
    if (price >= 1000) {
      result += 10;
    }
    Console.WriteLine(result);
  }
}