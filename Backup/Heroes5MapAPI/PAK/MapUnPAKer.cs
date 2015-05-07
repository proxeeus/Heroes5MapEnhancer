using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;

namespace Heroes5MapAPI.PAK
{
    public class MapUnPAKer
    {
        private string _pakPath;
        private string _unpakedRootPath;

        public MapUnPAKer(string pakPath)
        {
            this._pakPath = pakPath;
        }

        public string UnPAKedRootPath
        {
            get { return this._unpakedRootPath; }
        }

        public void UnPAK()
        {
            FastZip pak = new FastZip();
            FileInfo fileInfo = new FileInfo(this._pakPath);
            string directory = Path.Combine(Directory.GetCurrentDirectory(), "unpak");
            string unpakedRootPath = directory+"\\" + fileInfo.Name;
            pak.ExtractZip(this._pakPath, directory+"\\" + fileInfo.Name, "");
            this._unpakedRootPath = unpakedRootPath;
            
        }
    }
}
