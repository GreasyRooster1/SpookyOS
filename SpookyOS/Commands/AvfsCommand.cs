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
            canHaveArgs = false;
        }
        public void Run() {
            var available_space = Files.fs.GetAvailableFreeSpace(@"0:\");
            Console.WriteLine("Available Free Space: " + available_space);
        }
    }
}
