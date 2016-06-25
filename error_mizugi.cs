using System;
public class Hello {
  public static void Main() {
    var ignore = Console.ReadLine();
    var beforeStr = Console.ReadLine();
    var afterStr = Console.ReadLine();

    var beforeArray = new string[beforeStr.Length];
    for (int i = 0; i < beforeArray.Length; i++) {
      beforeArray[i] = beforeStr.Substring(i, 1);
    }

    var afterArray = new string[afterStr.Length];
    for (int i = 0; i < afterArray.Length; i++) {
      afterArray[i] = afterStr.Substring(i, 1);
    }

    for (int i = 0; i < beforeArray.Length; i++) {
      var del = beforeArray[i];
      for (int j = 0; j < afterArray.Length; j++) {
        if (del == afterArray[j]) {
          afterArray[j] = "";
          break;
        }
      }
    }

    var count = 0;
    for (int i = 0; i < afterArray.Length; i++) {
      if (afterArray[i] == "") {
        continue;
      }
      count++;
    }
    Console.WriteLine(count);
  }
}
