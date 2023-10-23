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
            description = "returns the available free space on the 0 disk";
            usage = "avfs [-kb,-mb,-gb,-tb]";
        }
        public override void Run(Kernel k, string[] args) {
            var available_space = Files.fs.GetAvailableFreeSpace(@"0:\");
            if (args == null)
            {
                Console.WriteLine("Available Free Space: " + available_space + " bytes");
                return;
            }
            if (args.Contains("-kb"))
            {
                Console.WriteLine("Available Free Space: " + (available_space / 1000d) + "Kb");
                return;
            }
            if (args.Contains("-mb"))
            {
                Console.WriteLine("Available Free Space: " + (available_space / 1000)/1000d + "Mb");
                return;
            }
            if (args.Contains("-gb"))
            {
                Console.WriteLine("Available Free Space: " + (available_space / 1000000)/1000d + "Gb");
                return;
            }
            if (args.Contains("-tb"))
            {
                Console.WriteLine("Available Free Space: " + (available_space / 1000000000)/1000d + "Tb");
                return;
            }

        }
    }
}
