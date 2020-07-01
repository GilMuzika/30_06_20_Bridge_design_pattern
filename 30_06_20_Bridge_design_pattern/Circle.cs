using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _30_06_20_Bridge_design_pattern
{
    public class Circle : Shape
    {
        private int _X, _Y, _radius;

        public Circle(int x, int y, int radius, IDrawAPI drawApi) : base(drawApi)
        {
            base._drawAPI = drawApi;
            this._X = x;
            this._Y = y;
            this._radius = radius;
        }


        public override void Draw()
        {
            _drawAPI.DrawCircle(_radius, _X, _Y);
        }
    }
}
