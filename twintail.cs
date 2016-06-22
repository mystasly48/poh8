using System;
public class Hello{
  public static void Main(){
    var length = int.Parse(Console.ReadLine());
    var position = int.Parse(Console.ReadLine());
    var result = "";
    for (int i = 0; i < length; i++) {
      if (i == position - 1) {
        result += "+";
        continue;
      }
      result += "-";
    }
    Console.WriteLine(result);
  }
}
