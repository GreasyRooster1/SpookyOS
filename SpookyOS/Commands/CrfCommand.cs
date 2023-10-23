using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    public class CrfCommand : Command
    {
        public CrfCommand()
        {
            identifier = "crf";
            description = "create a file";
            usage = "crf {path}";
        }
        public override void Run(Kernel k, string[] args)
        {
            try
            {
                var file_stream = File.Create(Files.pointer+string.Join(" ", args)[1..]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
