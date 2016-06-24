using System;
public class Hello {
  public static void Main() {
    var line = Console.ReadLine();
    var array = line.Split(' ');
    var people = int.Parse(array[0]);
    var candy = int.Parse(array[1]);
    if (candy % people == 0) {
      Console.WriteLine("ok");
    } else {
      Console.WriteLine("ng");
    }
  }
}
