using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Cosmos.HAL.BlockDevice.ATA_PIO;

namespace SpookyOS.Commands
{
    public class HelpCommand : Command
    {
        public HelpCommand()
        {
            identifier = "help";
            description = "displays the help menu";
            usage = "help [(command),-all]";
        }
        public override void Run(Kernel k, string[] args)
        {
            Console.WriteLine("use help (command) to see specific info about a command or help -all for all help");
            if (args == null)
            {
                int i = 1;
                foreach (Command c in k.commands)
                {
                    if (c != null)
                    {
                        Console.Write(c.identifier);
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
                }
                Console.Write("\n");
            }
            else
            {
                if (args[0] == "-all")
                {
                    foreach (Command c in k.commands)
                    {
                        if (c != null)
                        {
                            Console.WriteLine(c.identifier + " - usage: " + c.usage + ", description: " + c.description);
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    foreach (Command c in k.commands)
                    {
                        if (c.identifier == args[0])
                        {
                            Console.WriteLine(c.identifier + " - usage: " + c.usage + ", description: " + c.description);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
