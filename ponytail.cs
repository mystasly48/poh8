using System;
public class Hello {
  public static void Main() {
    var line1 = Console.ReadLine();
    var line2 = Console.ReadLine();
    var line3 = Console.ReadLine();
    var line4 = Console.ReadLine();
    var line5 = Console.ReadLine();
    var array1 = line1.Split(' ');
    var array2 = line2.Split(' ');
    var array3 = line3.Split(' ');
    var array4 = line4.Split(' ');
    var array5 = line5.Split(' ');
    var correct = array1[0] + array2[0] + array3[0] + array4[0] + array5[0];
    var answer = array1[1] + array2[1] + array3[1] + array4[1] + array5[1];
    var success = 0;
    for (int i = 0; i < 5; i++) {
      if (correct[i] == answer[i]) {
        success++;
      }
    }
    if (success >= 3) {
      Console.WriteLine("OK");
    } else {
      Console.WriteLine("NG");
    }
  }
}
