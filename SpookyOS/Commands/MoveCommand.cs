using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    public class MoveCommand:Command
    {
        public MoveCommand()
        {
            identifier = "move";
            description = "move a file";
            usage = "move {file} {path}";
        }
        public override void Run(Kernel k, string[] args)
        {
            try
            {
                File.Copy(args[0], Files.getPath(args[1]));
                File.Delete(args[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
