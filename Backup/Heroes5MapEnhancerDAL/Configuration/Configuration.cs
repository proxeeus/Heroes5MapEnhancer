using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Heroes5MapEnhancerDAL.Configuration
{
    [Serializable()]
    [XmlRoot("Configuration")]
    public class Configuration
    {
        private static volatile Configuration _instance;
        private static object syncRoot = new object();

        private string _h5MapFolder;
        private string _deleteUnPAKedMaps;

        [XmlElement("H5MapFolder")]
        public string H5MapFolder
        {
            get { return this._h5MapFolder; }
            set { this._h5MapFolder = value; }
        }

        [XmlElement("DeleteUnPAKedMaps")]
        public bool DeleteUnPAKedMaps
        {
            get { return Convert.ToBoolean(this._deleteUnPAKedMaps); }
            set { this._deleteUnPAKedMaps = Convert.ToString(value); }
        }

        private Configuration() { }

        public static Configuration Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                        {
                            using (StreamReader reader = new StreamReader("Configuration.xml"))
                            {
                                XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
                                _instance = (Configuration)serializer.Deserialize(reader);
                            }
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
