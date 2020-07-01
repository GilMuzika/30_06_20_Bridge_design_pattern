using System;

namespace _30_06_20_Bridge_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(100, 100, 50, new RedCircle());

            Shape greenCircle = new Circle(100, 100, 50, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();
        }
    }
}
