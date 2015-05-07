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
        private string _rootDirectory;

        public MapscriptXDBWriter(string rootDirectory)
        {
            this._rootDirectory = rootDirectory;
        }

        public FileInfo CreateMapscriptXDBFile()
        {
            string mapScriptXDBPath = Path.Combine(this._rootDirectory, "mapscript.xdb");
            string mapScriptXDBBaseContents =
                @"<?xml version=""1.0"" encoding=""UTF-8""?>
                    <Script>
	                    <FileName href=""mapscript.lua""/>
	                    <ScriptText/>
                    </Script>
            ";
            using (StreamWriter writer = new StreamWriter(mapScriptXDBPath, true, Encoding.UTF8))
            {
                writer.Write(mapScriptXDBBaseContents);
            }
            FileInfo mapScriptXDBFile = new FileInfo(mapScriptXDBPath);
            
            return mapScriptXDBFile;
        }
    }
}
