using System;
public class Hello {
  public static void Main() {
    var line = int.Parse(Console.ReadLine());
	if (line % 7 == 0) {
		Console.WriteLine("lucky");
	} else {
		Console.WriteLine("unlucky");
	}
  }
}
