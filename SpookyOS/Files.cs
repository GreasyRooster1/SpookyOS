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
        public static CosmosVFS fs;
        public static void setupFileSystem()
        {
            fs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
        }
    }
}
