using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpookyOS.Spooks
{
    public class MainSpooks
    {
        public static void basicSpook()
        {
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(SpookData.basicSpookText);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(SpookData.basicSpookText);
                }
                Thread.Sleep(7);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(SpookData.basicSpookText);
                Thread.Sleep(7);
            }
            Console.Clear();
        }
    }
}
