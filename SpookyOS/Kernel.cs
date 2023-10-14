using Cosmos.System.FileSystem;
using System;
using System.Linq;
using Sys = Cosmos.System;
using static SpookyOS.Files;
using SpookyOS.Commands;
using System.ComponentModel.Design;

namespace SpookyOS
{
    public class Kernel : Sys.Kernel
    {
        public Command[] commands = new Command[100];
        
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
            commands[0]=(new EchoCommand());
            commands[1]=(new AvfsCommand());
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
                mDebugger.Send("with args");
                string[] args = new string[cmd.Split(new char[0]).Length];
                for(int i = 0; i < args.Length; i++)
                {
                    args[i] = args[i].Replace(" ", "");
                }
                Array.Copy(cmd.Split(new char[0]), 1, args, 1, cmd.Split(new char[0]).Length - 1);
                findCommandWithArgs(identifier, args);
            }
            else
            {
                mDebugger.Send("without args");
                findCommandWithArgs(identifier,null);
            }
        }
        protected void findCommandWithArgs(string cmd, string[] args)
        {
            foreach (Command c in commands)
            {
                if (c != null)
                {
                    if (c.identifier == cmd)
                    {
                        c.Run(this, args);
                        return;
                    }
                }
            }
            Console.WriteLine("Could not locate command: " + cmd);
        }

    }
    
}
