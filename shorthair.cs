using System;
public class Hello {
  public static void Main() {
    var line1 = int.Parse(Console.ReadLine());
	var line2 = Console.ReadLine();
	for (int i = 0; i < line1; i++) {
		Console.WriteLine(line2);
	}
  }
}
