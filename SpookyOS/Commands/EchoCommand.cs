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
            description = "echoes something to the terminal";
            usage = "echo [ARGS]";
        }
        public override void Run(Kernel k, string[] args)
        {
            Console.WriteLine(string.Join(" ", args)[1..]);
        }
    }
}
