using System;
using System.Collections.Generic;
using System.Text;

namespace _30_06_20_Bridge_design_pattern
{
    public class RedCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int X, int Y)
        {
            Console.WriteLine($"Drawing circle: [ color: Red, radius: {radius}, X: {X}, Y: {Y} ]");
        }
    }
}
