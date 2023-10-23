using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    public class CdCommand :Command
    {
        public CdCommand() {
            identifier = "cd";
            description = "moves the pointer to a directory";
            usage = "cd {path}";
        }
        public override void Run(Kernel k, string[] args)
        {
            Files.pointer = Files.getPath(string.Join(" ", args)[1..]);
        }
    }
}
