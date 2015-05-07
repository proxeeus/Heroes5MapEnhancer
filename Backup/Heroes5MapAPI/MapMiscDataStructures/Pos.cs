using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes5MapAPI.MapMiscDataStructures
{
    public class Pos
    {
        private int _x;
        private int _y;
        private int _z;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Z
        {
            get { return _z; }
            set { _z = value; }
        }

        public Pos(int x, int y, int z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        public Pos()
        {
            this._x = 0;
            this._y = 0;
            this._z = 0;
        }
    }
}
