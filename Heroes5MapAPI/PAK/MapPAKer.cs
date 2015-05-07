using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;
using Heroes5MapEnhancerDAL.Configuration;

namespace Heroes5MapAPI.PAK
{
    public class MapPAKer
    {
        private string _pakRootDirectory;

        public MapPAKer(string pakRootDirectory)
        {
            this._pakRootDirectory = pakRootDirectory;
        }

        public void PAK()
        {
            FastZip pak = new FastZip();
            DirectoryInfo dInfo = new DirectoryInfo(this._pakRootDirectory);
            string publishDirectory = Directory.GetCurrentDirectory() + "\\publish\\";
            if (!Directory.Exists(publishDirectory))
                Directory.CreateDirectory(publishDirectory);
            pak.CreateZip(Path.Combine(publishDirectory,dInfo.Name), this._pakRootDirectory , true, "");
            if (Configuration.Instance.DeleteUnPAKedMaps)
                Directory.Delete(this._pakRootDirectory, true);
        }
    }
}
