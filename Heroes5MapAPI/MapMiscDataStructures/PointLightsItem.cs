using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Heroes5MapAPI.MapMiscDataStructures;

namespace Heroes5MapAPI.MapMiscDataStructures
{
    public class PointLightsItem
    {
        private Pos _pos;
        private Color _color;
        private int _radius;


        public Pos Pos
        {
            get { return _pos; }
            set { _pos = value; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }


        public PointLightsItem()
        {
            this._pos = new Pos();
            this._color = new Color();
            this._radius = 0;
        }
    }
}
