using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Heroes5MapAPI.PAK;
using Heroes5MapEnhancerDAL.Configuration;
using Heroes5MapAPI.MapscriptGen;
using Heroes5MapAPI;

namespace Heroes5MapEnhancer
{
    public class MapEnhancer
    {
        private bool _mapHasBeenChosen;
        private DirectoryInfo _currentUnPAKedDirectory;
        private FileInfo _mapScriptXDB;
        private FileInfo _mapScriptLUA;
        private DirectoryInfo _finalSubDirectory;

        public MapEnhancer() { }

        public void EnhanceMap()
        {
            this._mapHasBeenChosen = false;
            DirectoryInfo mapDirectory = new DirectoryInfo(Configuration.Instance.H5MapFolder);
            FileInfo[] mapFiles = mapDirectory.GetFiles("*.h5m");
            do
            {
                for (int i = 0; i < mapFiles.Length; i++)
                {
                    Console.WriteLine("{0} - {1}\n", i, mapFiles[i].Name);
                }
                Console.WriteLine("Please enter the number corresponding to the map you wish to enhance...\n");
                string input = Console.ReadLine();

                short parse;
                bool correctParse = Int16.TryParse(input, out parse);
                if ((correctParse) && (parse < mapFiles.Length))
                {
                    this._mapHasBeenChosen = true;
                    this.ProcessMap(mapFiles[parse]);

                }

            } while (!this._mapHasBeenChosen);
        }

        private void ProcessMap(FileInfo mapFile)
        {
            Console.WriteLine("Processing map file.");
            // 1. Unpak map
            this.UnPAKMap(mapFile);

            // 2. Get folder paths relative to mapscript.xdb/lua or create them if they don't exist.
            this._finalSubDirectory = Utils.GetFinalSubDirectory(this._currentUnPAKedDirectory.FullName);
            this._mapScriptXDB = Utils.GetMapScriptXDBFromMapFile(this._finalSubDirectory.FullName);
            if (this._mapScriptXDB != null)
            {
                MapscriptXDBReader mapScriptXDBReader = new MapscriptXDBReader(this._mapScriptXDB.FullName);
                string luaScriptName = mapScriptXDBReader.GetMapScriptLUAFileName();
                this._mapScriptLUA = new FileInfo(Path.Combine(this._mapScriptXDB.Directory.FullName, luaScriptName));
            }
            else
            {
                this.CreateMapscripts();
            }

            MapscriptLUAWriter mapScriptLUAWriter = new MapscriptLUAWriter(this._finalSubDirectory.FullName);
            mapScriptLUAWriter.WriteScript();


            // ??. Repak map
            this.PAKMap(mapFile);

        }

        private void CreateMapscripts()
        {
            Console.WriteLine("Writing reference to mapscript.xdb into map.xdb...");
            Utils.CreateMapScriptXDBInMapFile(this._finalSubDirectory.FullName);
            MapscriptXDBWriter mapScriptXDBWriter = new MapscriptXDBWriter(this._finalSubDirectory.FullName);
            Console.WriteLine("Creating mapscript.xdb file...");
            this._mapScriptXDB = mapScriptXDBWriter.CreateMapscriptXDBFile();
            Console.WriteLine("Creating mapscript.lua file...");
            MapscriptLUAWriter mapScriptLUAWriter = new MapscriptLUAWriter(this._finalSubDirectory.FullName);
            this._mapScriptLUA = mapScriptLUAWriter.CreateMapscriptLUAFile();
        }

        private void PAKMap(FileInfo mapFile)
        {
            Console.WriteLine("PAKing map file...");
            MapPAKer paker = new MapPAKer(this._currentUnPAKedDirectory.FullName);
            paker.PAK();
            Console.WriteLine("Map PAKed successfully.\nHave fun! :)");
        }

        private void UnPAKMap(FileInfo mapFile)
        {
            Console.WriteLine("UnPAKing map...");
            MapUnPAKer unpaker = new MapUnPAKer(mapFile.FullName);
            unpaker.UnPAK();
            this._currentUnPAKedDirectory = new DirectoryInfo(unpaker.UnPAKedRootPath);
            Console.WriteLine("Map file UnPAKed successfully.\n");
        }
    }
}
