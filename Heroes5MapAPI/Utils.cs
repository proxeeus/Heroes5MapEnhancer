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
        public static string GetMapXDBPath(string pakRootDirectory)
        {
            var directoryInfo = new DirectoryInfo(pakRootDirectory);
            var fileList = directoryInfo.GetFiles("*.xdb", SearchOption.AllDirectories);
            var query =
                from file in fileList
                where file.Name == "map.xdb"
                select file;

            return query.First().FullName;
        }

        public static string GetMapScriptXDBPath(string pakRootDirectory)
        {
            var directoryInfo = new DirectoryInfo(pakRootDirectory);
            var fileList = directoryInfo.GetFiles("*.xdb", SearchOption.AllDirectories);
            var query =
                from file in fileList
                where file.Name == "mapscript.xdb"
                select file;

            if(query.Any())
                return query.First().FullName;
            else
            {
                return string.Empty;
            }
        }

        public static void CreateMapScriptXDBInMapFile(string mapXDBPath)
        {
            FileInfo mapFile = new FileInfo(mapXDBPath);
            if (mapFile.Exists)
            {
                XElement mapRootElement = XElement.Load(mapFile.FullName);
                mapRootElement.Element("MapScript").Add(new XAttribute("href", "mapscript.xdb#xpointer(/Script)"));
                mapRootElement.Save(mapFile.FullName);
            }
        }
    }
}
