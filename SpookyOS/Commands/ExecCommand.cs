using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    public class ExecCommand : Command
    {
        public ExecCommand()
        {
            identifier = "exec";
            description = "execute a file as a command line script (.spookycls)";
            usage = "exec {path}";
        }
        public override void Run(Kernel k, string[] args)
        {
            try
            {
                string[] lines = File.ReadAllLines(Files.getPath(string.Join(" ", args)[1..]));
                int l = 0;
                foreach (string line in lines)
                {
                    l++;
                    try
                    {
                        k.runCommand(line);
                    }catch (Exception ex)
                    {
                        Console.WriteLine("Line "+l.ToString()+": Exception in script execute: "+ex.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }
        }
    }
}
