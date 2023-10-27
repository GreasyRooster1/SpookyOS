using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    public class WriteCommand : Command
    {
        public WriteCommand()
        {
            identifier = "write";
            description = "write to a file, {path} must be the full path,  \\n is a return";
            usage = "write {path} {content}";
        }
        public override void Run(Kernel k, string[] args)
        {
            //Im so sorry about this too
            //Console.WriteLine("V.1.1? please?");
            try
            {
                File.WriteAllText(args[0], string.Join(" ", args[1..]).Replace("\\n","\n"));
                //File.WriteAllText(Files.getPath(args[0]), string.Join(" ", args[1..]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
