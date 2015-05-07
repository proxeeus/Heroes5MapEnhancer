using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Heroes5MapAPI.MapscriptGen
{
    public class MapscriptXDBReader
    {
        private string _mapScriptXDBPath;

        public MapscriptXDBReader(string mapScriptXDBPath)
        {
            this._mapScriptXDBPath = mapScriptXDBPath;
        }

        public string GetMapScriptLUAFileName()
        {
            string luaFileName = string.Empty;
            XElement rootElement = XElement.Load(this._mapScriptXDBPath);

            foreach (XElement element in rootElement.Elements())
            {
                if ((element.FirstAttribute != null))
                {
                    luaFileName = element.FirstAttribute.Value;
                }
            }

            return luaFileName;
        }
    }
}
