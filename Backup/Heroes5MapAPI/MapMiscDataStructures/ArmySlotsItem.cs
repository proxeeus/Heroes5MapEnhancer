using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes5MapAPI.MapMiscDataStructures
{
    public class ArmySlotsItem
    {
        private string _creature;
        private int _count;

        public string Creature
        {
            get { return _creature; }
            set { _creature = value; }
        }

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public ArmySlotsItem()
        {
            this._count = 0;
            this._creature = string.Empty;
        }

        public ArmySlotsItem(string creature, int count)
        {
            this._creature = creature;
            this._count = count;
        }
    }
}
