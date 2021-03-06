﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Heroes5MapAPI.MapscriptGen.Scripting;

namespace Heroes5MapAPI.MapscriptGen
{
    public class MapscriptLUAWriter
    {
        private string _mapScriptLuaPath;

        public MapscriptLUAWriter(string mapScriptLuaPath)
        {
            this._mapScriptLuaPath = mapScriptLuaPath.Replace("map.xdb", "mapscript.lua");
        }

        public FileInfo CreateMapscriptLUAFile()
        {
            string scriptHeader = "-- mapscript.lua, generated by HOMMV Map Enhancer";
            using (StreamWriter writer = new StreamWriter(_mapScriptLuaPath, true))
            {
                writer.WriteLine(scriptHeader);
            }

            FileInfo mapScriptLUAFile = new FileInfo(_mapScriptLuaPath);
            return mapScriptLUAFile;
        }

        public void WriteScript(string mapXDBPath)
        {
            Script script = new Script(mapXDBPath);
            script.GenerateScript();

            using (StreamWriter writer = new StreamWriter(_mapScriptLuaPath, true, Encoding.ASCII))
            {
                writer.Write(script.ToString());
            }
        }
    }
}
