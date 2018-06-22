using System;

namespace Task_2
{
  public class AreaCalculator
  {
    public int Width { get; set; }
    public int Length { get; set; }

    public AreaCalculator(int width, int length)
    {
      Width = width;
      Length = length;
    }

    public int Calculate(int width, int length)
    {
      int area;
      area = width * length;
      return area;
    }
  }
}
