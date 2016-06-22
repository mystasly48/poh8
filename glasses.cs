using System;
public class Hello {
  public static void Main() {
    var count = int.Parse(Console.ReadLine());
	var line = Console.ReadLine();
	var strArray = line.Split(' ');
	var intArray = new int[count];
	for (int i = 0; i < count; i++) {
		intArray[i] = int.Parse(strArray[i]);
	}
	Array.Sort(intArray);
	Array.Reverse(intArray);
	var position = (count + 1) / 2;
	var result = intArray[position - 1];
	Console.WriteLine(result);
  }
}
