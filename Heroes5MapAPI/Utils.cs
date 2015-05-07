using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;

namespace Heroes5MapAPI
{
    public static class Utils
    {
        public static DirectoryInfo GetFinalSubDirectory(string pakRootDirectory)
        {
            DirectoryInfo finalSubDirectory = null;

            DirectoryInfo rootDirectory = new DirectoryInfo(pakRootDirectory);
            DirectoryInfo[] subDirectories = rootDirectory.GetDirectories();
            if (subDirectories.Count() > 0)
            {
                foreach (DirectoryInfo subDirectory in subDirectories)
                {

                    finalSubDirectory = Utils.GetFinalSubDirectory(subDirectory.FullName);
                }
            }
            else
            {
                finalSubDirectory = rootDirectory;
            }

            return finalSubDirectory;
        }

        public static FileInfo GetMapScriptXDBFromMapFile(string pakRootDirectory)
        {
            FileInfo mapScript = null;

            FileInfo mapFile = new FileInfo(Path.Combine(pakRootDirectory, "map.xdb"));
            if (mapFile.Exists)
            {
                XElement mapRootElement = XElement.Load(mapFile.FullName);
                if (mapRootElement.Element("MapScript").HasAttributes)
                {
                    string[] name = mapRootElement.Element("MapScript").FirstAttribute.Value.Split(new char[] { '#' });
                    mapScript = new FileInfo(Path.Combine(pakRootDirectory, name[0]));
                }
            }

            return mapScript;
        }

        public static void CreateMapScriptXDBInMapFile(string pakRootDirectory)
        {
            FileInfo mapFile = new FileInfo(Path.Combine(pakRootDirectory, "map.xdb"));
            if (mapFile.Exists)
            {
                XElement mapRootElement = XElement.Load(mapFile.FullName);
                mapRootElement.Element("MapScript").Add(new XAttribute("href", "mapscript.xdb#xpointer(/Script)"));
                mapRootElement.Save(mapFile.FullName);
            }
        }
    }
}
