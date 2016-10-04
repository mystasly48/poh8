using System;
using System.Linq;
using System.Collections;

public class Program {
  public static void Main() {
    var _____ = Console.ReadLine();
    var beforeArray = Console.ReadLine().ToArray();
    var afterArray = Console.ReadLine().ToArray();
    var beforeHash = new Hashtable();
    var afterHash = new Hashtable();
    var resultHash = new Hashtable();
    var result = 0;

    foreach (var c in beforeArray.Distinct())
      beforeHash[c] = beforeArray.Count(_ => _ == c);
  
    foreach (var c in afterArray.Distinct())
      afterHash[c] = afterArray.Count(_ => _ == c);

    foreach (var key in afterHash.Keys)
      if (beforeHash.ContainsKey(key))
        resultHash[key] = afterHash[key].GetHashCode() - beforeHash[key].GetHashCode();
      else
        result += (int)afterHash[key];

    foreach (var key in resultHash.Keys)
      if ((int)resultHash[key] > 0)
        result += (int)resultHash[key];

    Console.WriteLine(result);
  }
}