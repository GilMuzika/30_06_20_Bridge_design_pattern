using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace _30_06_20_Bridge_design_pattern
{
    public abstract class Shape
    {
        protected IDrawAPI _drawAPI;

        protected Shape(IDrawAPI drawAPI)
        {
            this._drawAPI = drawAPI;
        }

        public abstract void Draw();
    }
}
