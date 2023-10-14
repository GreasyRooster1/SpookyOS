using Cosmos.System.FileSystem;
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
        public static void setupFileSystem()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.WriteLine("Sucussfuly initalized CosmosVFS");
        }
    }
}
