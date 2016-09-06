using System;
public class Hello {
 public static void Main() {
  var count = 24;
  var eventCount = int.Parse(Console.ReadLine());
  var arrayTime = new int[count];
  var arrayEvent = new string[count];
  for (int i = 0; i < eventCount; i++) {
   var s = Console.ReadLine();
   var l = s.Split(' ');
   var pos = int.Parse(l[0]);
   arrayTime[pos] = pos;
   arrayEvent[pos] = l[1];
  }
  var temperature = 0;
  var cost = 0;
  for (int i = 0; i < count; i++) {
   if (arrayTime[i] == i) {
    if (arrayEvent[i] == "out") {
     temperature += 3;
    } else if (arrayEvent[i] == "in") {
     temperature += 5;
    }
   }
   if (temperature != 0) {
    temperature--;
    cost += 2;
   } else {
    cost++;
   }
  }
  Console.WriteLine(cost);
 }
}
