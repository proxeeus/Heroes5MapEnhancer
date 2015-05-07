using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Heroes5MapEnhancerDAL
{
    [Serializable()]
    [XmlRootAttribute("Artifact")]
    public class DArtifact
    {
        private string _id;
        private string _sound;
        private List<string> _texts;


        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Sound
        {
            get { return this._sound; }
            set { this._sound = value; }
        }

        [XmlArrayAttribute("Texts")]
        [XmlArrayItemAttribute("Text")]
        public List<string> Texts
        {
            get { return this._texts; }
            set { this._texts = value; }
        }
    }
}
