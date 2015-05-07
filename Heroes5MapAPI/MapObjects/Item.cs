using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes5MapAPI.MapObjects
{
    /// <summary>
    /// This is the basic representation of a Map item.
    /// </summary>
    public abstract class Item
    {
        private string _href;
        private string _id;

        public string Href
        {
            get { return this._href; }
            set { this._href = value; }
        }

        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public Item() { }
    }
}
