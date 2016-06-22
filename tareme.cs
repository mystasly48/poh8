using System;
public class Hello {
  public static void Main() {
    var line = Console.ReadLine();
	var array = line.Split(' ');
	var vacant = int.Parse(array[0]);
	var people = int.Parse(array[1]);
	if (vacant - people >= 0) {
		Console.WriteLine("OK");
	} else {
		Console.WriteLine("NG");
	}
  }
}
