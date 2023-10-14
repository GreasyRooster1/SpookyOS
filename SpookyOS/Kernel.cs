using Cosmos.System.FileSystem;
using System;
using System.Linq;
using Sys = Cosmos.System;
using static SpookyOS.Files;
using SpookyOS.Commands;

namespace SpookyOS
{
    public class Kernel : Sys.Kernel
    {
        protected Command[] commands = {};
        
        protected override void BeforeRun()
        {
            Files.setupFileSystem();
            registerCommands();
            Console.WriteLine("SpookyOS has booted up!");
            Cosmos.HAL.Global.PIT.Wait(1000);
            Console.Clear();
            Console.WriteLine("----SpookyOS V1.0----");
            Console.WriteLine("SpookyOs by Dillon Wilson");
            Console.WriteLine("made with COSMOS");
            
        }

        protected void registerCommands()
        {
            commands.Append(new EchoCommand());
            commands.Append(new AvfsCommand());
            mDebugger.Send(commands.ToString());
        } 

        protected override void Run()
        {
            commandLine();
        }
        protected void commandLine()
        {
            Console.Write("/> $");
            string input = Console.ReadLine();
            //if(input.Split('$').Length > 2)
            // {
            //    Console.WriteLine("Invalid command syntax: unexpected token $");
            //}
            runCommand(input.Substring(input.LastIndexOf('$') + 1));

        }
        protected void runCommand(string cmd)
        {
            string identifier = cmd.Split(new char[0])[0];
            mDebugger.Send(identifier);
            if (cmd.Split(new char[0]).Length > 1)
            {
                string[] args = new string[cmd.Split(new char[0]).Length];
                Array.Copy(cmd.Split(new char[0]), 1, args, 1, cmd.Split(new char[0]).Length - 1);
                findCommandWithArgs(identifier, args);
            }
            else
            {
                findCommand(identifier);
            }
        }
        protected void findCommandWithArgs(string cmd, string[] args)
        {
            foreach(Command c in commands)
            {
                mDebugger.Send(c.identifier);
                if (c.identifier == cmd&&c.canHaveArgs)
                {
                    c.Run(args);
                }
            }
        }

        protected void findCommand(string cmd)
        {
            foreach (Command c in commands)
            {
                if (c.identifier == cmd && !c.canHaveArgs)
                {
                    c.Run();
                }
            }
        }

    }
    
}
