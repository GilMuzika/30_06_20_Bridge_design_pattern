using System;
using System.Collections.Generic;
using System.Text;

namespace _30_06_20_Bridge_design_pattern
{
    public class GreenCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int X, int Y)
        {
            Console.WriteLine($"Drawing circle: [ color: Green, radius: {radius}, X: {X}, Y: {Y} ]");
        }
    }
}
