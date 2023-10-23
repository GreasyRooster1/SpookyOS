using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    public class LsCommand : Command
    {
        public LsCommand()
        {
            identifier = "ls";
            description = "shows all files in a directory";
            usage = "ls [ARGS]";
        }
        public override void Run(Kernel k, string[] args)
        {

            var files_list = Directory.GetFiles(Files.pointer);
            int i = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var f in files_list)
            {
                Console.Write(f);
                if (i % 3 == 0)
                {
                    Console.Write("\n");
                }
                else
                {
                    Console.Write(" ");
                }
                i++;
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            var dir_list = Directory.GetDirectories(Files.pointer);
            foreach (var f in dir_list)
            {
                
                Console.Write(f);
                if (i % 3 == 0)
                {
                    Console.Write("\n");
                }
                else
                {
                    Console.Write(" ");
                }
                i++;
            }
            
            Console.Write("\n");
        }
    }
}
