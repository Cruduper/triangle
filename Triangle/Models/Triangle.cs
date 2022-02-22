
namespace Triangle 
{
  public class TriangleCheck
  {
    public bool IsTriangle(int a, int b, int c)
    {
      // logic will go here
      return false;
    }
  }
}





// sides a, b, c == and if (a = b) && (b = c) == equilateral (else if)
// if (a = b) or (b = c) or (c = a) (else if)
// if (a >= b + C) or (b >= a + c) or (c >= b + a) then it isn't a triangle
// else scalene
