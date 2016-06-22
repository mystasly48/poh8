using System;
public class Hello {
  public static void Main() {
    var line1 = Console.ReadLine();
    var line2 = Console.ReadLine();
    var array1 = line1.Split(' ');
    var array2 = line2.Split(' ');

    var fans = int.Parse(array1[0]);
    var paperCost = int.Parse(array1[1]);
    var penCapacity = int.Parse(array2[0]);
    var penCost = int.Parse(array2[1]);

    var temp1 = paperCost * fans;
    var temp2 = fans / penCapacity;
    if (fans % penCapacity != 0) {
      temp2 += 1;
    }
    var temp3 = penCost * temp2;

    var cost = temp1 + temp3;

    Console.WriteLine(cost);
  }
}
