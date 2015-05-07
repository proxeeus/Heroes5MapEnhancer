using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes5MapAPI.MapMiscDataStructures
{
    public class Color
    {
        private decimal _x;
        private decimal _y;
        private decimal _z;

        public decimal X
        {
            get { return _x; }
            set { _x = value; }
        }

        public decimal Y
        {
            get { return _y; }
            set { _y = value; }
        }
        

        public decimal Z
        {
            get { return _z; }
            set { _z = value; }
        }

        public Color()
        {
            this._x = 0;
            this._y = 0;
            this._z = 0;
        }

        public Color(decimal x, decimal y, decimal z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }
    }
}
