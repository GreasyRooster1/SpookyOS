using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    public class CatCommand :Command
    {
        public CatCommand() {
            identifier = "cat";
            description = "view a file";
            usage = "cat {path}";
        }
        public override void Run(Kernel k, string[] args)
        {
            try
            {
                string[] lines = File.ReadAllLines(Files.pointer + string.Join(" ", args)[1..]);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
