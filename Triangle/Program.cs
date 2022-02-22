using System;
using Triangle.Model;

namespace Triangle  {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please input side 1 length: ");
      int side1 = int.Parse( Console.ReadLine() );
      Console.WriteLine("Please input side 2 length: ");
      int side2 = int.Parse(Console.ReadLine() );
      Console.WriteLine("Please input side 3 length: ");
      int side3 = int.Parse(Console.ReadLine() );
      Console.WriteLine("Your triangle type: " + TriangleCheck.TriangleType(side1, side2, side3));
    }
  }
}