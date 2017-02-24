using System;
using System.Linq;
public class Hello {
  public static void Main() {
    double[] input = Console.ReadLine().Split(' ').Concat(Console.ReadLine().Split(' ')).Select(double.Parse).ToArray();
    Console.WriteLine(input[0] * input[1] + input[3] * (Math.Ceiling(input[0] / input[2])));
  }
}
