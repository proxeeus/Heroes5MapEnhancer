using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Heroes5MapEnhancerDAL
{
    [Serializable()]
    public class Database
    {
        private static volatile Database _instance;
        private static object syncRoot = new Object();

        private List<DArtifact> _artifacts;

        private Database() { }

        public static Database Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                        {
                            using (StreamReader reader = new StreamReader("Database.xml"))
                            {
                                XmlSerializer serializer = new XmlSerializer(typeof(Database));
                                _instance = (Database)serializer.Deserialize(reader);
                            }
                        }
                    }
                }

                return _instance;

            }
        }

        [XmlArrayAttribute("Artifacts")]
        [XmlArrayItemAttribute("Artifact")]
        public List<DArtifact> Artifacts
        {
            get { return this._artifacts; }
            set { this._artifacts = value; }
        }
    }
}
