using System;
public class Hello {
  public static void Main() {
    var perDay = int.Parse(Console.ReadLine());
    var total = int.Parse(Console.ReadLine());
    var week = perDay * 2;
    var result = total / week;
    if (total % week != 0) {
      result++;
    }
    Console.WriteLine(result);
  }
}