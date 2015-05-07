using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;

namespace Heroes5MapAPI.MapscriptGen
{
    public class MapscriptXDBWriter
    {
        private string _mapScriptXDBPath;

        public MapscriptXDBWriter(string mapScriptXDBPath)
        {
            this._mapScriptXDBPath = mapScriptXDBPath.Replace("map.xdb", "mapscript.xdb");
        }

        public FileInfo CreateMapscriptXDBFile()
        {
            string mapScriptXDBBaseContents =
                @"<?xml version=""1.0"" encoding=""UTF-8""?>
                    <Script>
	                    <FileName href=""mapscript.lua""/>
	                    <ScriptText/>
                    </Script>
            ";
            using (StreamWriter writer = new StreamWriter(_mapScriptXDBPath, true, Encoding.UTF8))
            {
                writer.Write(mapScriptXDBBaseContents);
            }
            FileInfo mapScriptXDBFile = new FileInfo(_mapScriptXDBPath);
            
            return mapScriptXDBFile;
        }
    }
}
