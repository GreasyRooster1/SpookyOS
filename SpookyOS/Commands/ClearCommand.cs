using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    public class ClearCommand :Command
    {
        public ClearCommand() {
            identifier = "clear";
            description = "clears the screen";
            usage = "clear";
        }
        public override void Run(Kernel k, string[] args)
        {
            Console.Clear();
        }
    }
}
