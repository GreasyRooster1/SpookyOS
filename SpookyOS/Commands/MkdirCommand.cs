using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    internal class MkdirCommand :Command
    {
        public MkdirCommand() {
            identifier = "mkdir";
            description = "creates a directory";
            usage = "mkdir {Name}";

        }
        public override void Run(Kernel k, string[] args)
        {
            try
            {
                Directory.CreateDirectory(Files.getPath(string.Join(" ", args)[1..]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
