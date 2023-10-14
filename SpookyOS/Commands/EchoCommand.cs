using Cosmos.Debug.Kernel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    public class EchoCommand : Command
    {
        public EchoCommand()
        {
            identifier = "echo";
        }
        public override void Run(Kernel k, string[] args)
        {
            k.mDebugger.Send("sdfdsf");
            Console.WriteLine(string.Join(" ", args));
        }
    }
}
