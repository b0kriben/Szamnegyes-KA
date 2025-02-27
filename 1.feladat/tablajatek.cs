namespace myjinxin
{
  using System;
  public class Kata
  {
    public int[] TableGame(int[][] table){
      int a = table[0][0];
      int b = table[0][2];
      int c = table[2][0];
      int d = table[2][2];
      if (a < 0 || b < 0 || c < 0 || d < 0 || 
          a + b != table[0][1] || a + c != table[1][0] || 
          b + d != table[1][2] || c + d != table[2][1] || 
          a + b + c + d != table[1][1])
      {
      return new int[] { -1 };
      }

      return new int[] { a, b, c, d };
    }
  }
}