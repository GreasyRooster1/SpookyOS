using System;
using System.Collections.Generic;
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
            canHaveArgs = true;
        }
        public void Run(string args)
        {
            Console.WriteLine(string.Join(" ", args));
        }
    }
}
