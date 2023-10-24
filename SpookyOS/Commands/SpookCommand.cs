using Cosmos.Debug.Kernel;
using SpookyOS.Spooks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    public class SpookCommand : Command
    {
        public SpookCommand()
        {
            identifier = "spook";
            description = "spook test";
            usage = "spook";
        }
        public override void Run(Kernel k, string[] args)
        {
            MainSpooks.basicSpook();
        }
    }
}
