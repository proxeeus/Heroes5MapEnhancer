using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Heroes5MapAPI.PAK;
using Heroes5MapEnhancerDAL;
using Heroes5MapEnhancerDAL.Configuration;

namespace Heroes5MapEnhancer
{
    static class Program
    {
        private static bool _done = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if ((args.Length>0) && (args[0].Equals("gui")))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                Console.Title = "HOMM V Tribes of the East - Map Enhancer";

                Console.WriteLine("HOMM V Tribes of the East Map Enhancer\n======================================\n");
                Console.WriteLine("Loading Database.xml contents...\n");
                Console.WriteLine("There are {0} artifacts configured in total.\n", Database.Instance.Artifacts.Count);
                Console.WriteLine("Current configured path for maps is:\n{0}\n", Heroes5MapEnhancerDAL.Configuration.Configuration.Instance.H5MapFolder);
                do
                {

                    Console.WriteLine("Menu\n====\n");
                    Console.WriteLine("1. Enhance a map\n");
                    Console.WriteLine("2. Quit");
                    string input = Console.ReadLine();
                    ParseConsoleInput(input);
                }
                while (!_done);
            }
        }

        private static void ParseConsoleInput(string input)
        {
            short parse;
            bool correctParse =Int16.TryParse(input, out parse);

            switch (parse)
            {
                case 0:
                    Console.WriteLine("An error has occured, please try again.");
                    break;
                case 1:
                    MapEnhancer enhancer = new MapEnhancer();
                    enhancer.EnhanceMap();
                    break;
                case 2:
                    _done = true;
                    break;
            }
        }
    }
}
