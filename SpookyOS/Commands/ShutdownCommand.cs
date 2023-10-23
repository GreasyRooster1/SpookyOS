using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System;

namespace SpookyOS.Commands
{
    public class ShutdownCommand : Command
    {
        public ShutdownCommand()
        {
            identifier = "shutdown";
            description = "shutdowns the computer";
            usage = "shutdown";
        }
        public override void Run(Kernel k, string[] args)
        {
            Power.Shutdown();
        }
    }
}
