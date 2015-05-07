using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes5MapAPI.MapObjects
{
    /// <summary>
    /// The Map class defines the main data structure representing a given Heroes V map.xdb file and allows easy access to
    /// most of its properties & items.
    /// NOT IMPLEMENTED YET.
    /// </summary>
    public class Map
    {
        // Private fields.
        private bool _customGameMap;
        private int _version;
        private int _tileX;
        private int _tileY;
        private bool _hasUnderground;
        private bool _hasSurface;
        private int _initialFloor;
    }
}
