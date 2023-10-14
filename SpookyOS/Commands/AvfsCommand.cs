using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS
{
    public class AvfsCommand : Command
    {
        public AvfsCommand()
        {
            identifier = "avfs";
        }
        public override void Run(Kernel k, string[] args) {
            var available_space = Files.fs.GetAvailableFreeSpace(@"0:\");
            if (args == null)
            {
                Console.WriteLine("Available Free Space: " + available_space + " bytes");
                return;
            }
            /*if (args.Contains("-kb"))
            {
                Console.WriteLine("Available Free Space: " + available_space / 1000 + "Kb");
                return;
            }
            if (args.Contains("-mb"))
            {
                Console.WriteLine("Available Free Space: " + available_space/ 1000000 + "Mb");
                return;
            }
            if (args.Contains("-gb"))
            {
                Console.WriteLine("Available Free Space: " + available_space / 1000000000 + "Gb");
                return;
            }
            if (args.Contains("-tb"))
            {
                Console.WriteLine("Available Free Space: " + available_space / 1000000000000 + "Tb");
                return;
            }*/
            
        }
    }
}
