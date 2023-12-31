﻿using Cosmos.System.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace SpookyOS
{
    internal class Files
    {
        public static CosmosVFS fs = new CosmosVFS();
        public static string pointer = @"0:\";
        public static void setupFileSystem()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Press enter to confirm that you ARE NOT running SpookyOs on a real machine\npressing enter will confirm VFS initialization\nTHIS IS VERY LIKELY TO PERMANTLY MESS UP REAL HARD DRIVES\nwould you like to continue? ");
            string cont = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sucussfuly initalized CosmosVFS");
        }
        public static string getPath(string inp) {
            string path = "";
            inp = inp.Replace("/", "\\");
            if (inp.StartsWith(".\\"))
            {
                path = pointer + inp.Replace(".\\", "")+@"\";
                return path;
            }
            if (inp.StartsWith("\\"))
            {
                path = "0:\\"+inp+@"\";
                return path;
            }
            if (inp.StartsWith(@"0:\"))
            {
                path = inp;
                return path;
            }
            path = pointer + inp + @"\";
            return path;
        }
    }
}
