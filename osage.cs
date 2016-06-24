using System;
public class Hello {
  public static void Main() {
    var maxSec = int.Parse(Console.ReadLine()) * 60;
    var count = int.Parse(Console.ReadLine());
    var songsLengthArray = new int[count];
    for (int i = 0; i < count; i++) {
      songsLengthArray[i] = int.Parse(Console.ReadLine());
    }
    var songsLength = 0;
    for (int i = 0; i < count; i++) {
      if (songsLength + songsLengthArray[i] > maxSec) {
        Console.WriteLine(i);
        return;
      }
      songsLength += songsLengthArray[i];
    }
    Console.WriteLine("OK");
  }
}