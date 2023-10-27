using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpookyOS.Commands
{
    public class ColorCommand :Command
    {
        public ColorCommand() {
            identifier = "color";
            description = "change console color, colorId is a int from 0-15";
            usage = "color {colId}";
        }
        public override void Run(Kernel k, string[] args)
        {
            //its too late for this
            if (args[0] == "0") {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            if (args[0] == "1")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
            if (args[0] == "2")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            if (args[0] == "3")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            if (args[0] == "4")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            if (args[0] == "5")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            if (args[0] == "6")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            if (args[0] == "7")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            if (args[0] == "8")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            if (args[0] == "9")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (args[0] == "10")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            if (args[0] == "11")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (args[0] == "12")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (args[0] == "13")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            if (args[0] == "14")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            if (args[0] == "15")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
    }
}
