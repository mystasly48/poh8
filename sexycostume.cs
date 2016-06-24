using System;
public class Hello {
  public static void Main() {
    var line = Console.ReadLine();
    var array = line.Split(' ');
    var forward = int.Parse(array[0]);
    var backward = int.Parse(array[1]);
    var result = forward - backward;
    if (result < 0) {
      Console.WriteLine(0);
    } else {
      Console.WriteLine(result);
    }
  }
}
