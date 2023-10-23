using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    public class DelCommand:Command
    {
        public DelCommand()
        {
            identifier = "del";
            description = "delete a file";
            usage = "del {path}";
        }
        public override void Run(Kernel k, string[] args)
        {
            try
            {
                File.Delete(Files.pointer + string.Join(" ", args)[1..]);
            }
            catch (Exception e)
            {
                try
                {
                    Directory.Delete(Files.pointer + string.Join(" ", args)[1..]);

                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1.ToString());
                }
            }
        }
    }
}
