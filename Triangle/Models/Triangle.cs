
namespace Triangle.Model 
{
  public class TriangleCheck
  {
    public static string TriangleType(int a, int b, int c)
    {
      if ((a == b) && (b == c)){
        return "Equilateral";
      } else if ((a == b) || (b == c) || (c == a)){
        return "Isosceles";
      } else if ((a > b + c) || (b > c + a) || (c > a + b)) {
        return "Not a triangle.";
      } else if ((a != b) && (b != c) && (a != c)){
        return "Scalene";
      } else {
        return "YOU DONE MESSED UP SON";
      }
    }
  }
}





// sides a, b, c == and if (a = b) && (b = c) == equilateral (else if)
// if (a = b) or (b = c) or (c = a) (else if)
// if (a >= b + C) or (b >= a + c) or (c >= b + a) then it isn't a triangle
// else scalene
